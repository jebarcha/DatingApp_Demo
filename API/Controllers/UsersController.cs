using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using API.Interfaces;
using API.DTOs;
using AutoMapper;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _mapper;
        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _UserRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers() 
        {
            // var users = await _UserRepository.GetUsersAsync();
            // var usersToReturn = _mapper.Map<IEnumerable<MemberDto>>(users);
            //return Ok(usersToReturn);
            var users = await _UserRepository.GetMembersAsync();
            return Ok(users);
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username) 
        {
            //var user = await _UserRepository.GetUserByUsernameAsync(username);
            //return _mapper.Map<MemberDto>(user);
            return await _UserRepository.GetMemberAsync(username);
        }
    }
}