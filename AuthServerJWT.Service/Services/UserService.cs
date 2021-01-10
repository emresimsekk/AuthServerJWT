﻿using AuthServerJWT.Core.Dtos;
using AuthServerJWT.Core.Entity;
using AuthServerJWT.Core.Services;
using AuthServerJWT.Service.Mapping;
using AuthServerJWT.Shared.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServerJWT.Service.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<UserApp> _userManager;
        public UserService(UserManager<UserApp> userManager)
        {
            _userManager = userManager;
        }
        public async Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new UserApp
            {
                Email = createUserDto.Email,
                UserName = createUserDto.UserName,
            };
            var result = await _userManager.CreateAsync(user, createUserDto.Password);
            if(!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();
                return Response<UserAppDto>.Fail(new ErrorDto(errors, true), 400);
            }
            return Response<UserAppDto>.Success(ObjectMapper.Mapper.Map<UserAppDto>(user), 200);
            
        }

        public async Task<Response<UserAppDto>> GetUserByNameAsync(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if(user==null)
            {
                return Response<UserAppDto>.Fail("Username bulunamadı", 404, true);
            }
            return Response<UserAppDto>.Success(ObjectMapper.Mapper.Map<UserAppDto>(user), 200);
        }
    }
}
