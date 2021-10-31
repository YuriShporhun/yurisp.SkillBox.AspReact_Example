using Application.User.Dto;
using Application.User.Exceptions;
using AutoMapper;
using FluentValidation;
using Infrastructure.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.User
{
    public class Login
    {
        public class Query : IRequest<UserDto>
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class QueryValidator : AbstractValidator<Query>
        {
            public QueryValidator()
            {
                RuleFor(x => x.Email).NotEmpty();
                RuleFor(x => x.Password).NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Query, UserDto>
        {
            private readonly UserManager<ApplicationUser> _userManager;
            private readonly SignInManager<ApplicationUser> _signInManager;
            private readonly IMapper _mapper;

            public Handler(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IMapper mapper)
            {
                _userManager = userManager;
                _signInManager = signInManager;
                _mapper = mapper;
            }

            public async Task<UserDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var user = await _userManager.FindByEmailAsync(request.Email);

                if(user == null)
                {
                    throw new UnauthorizedException(UnauthorizedException.Reason.UserNotFound);
                }

                var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

                var userDto = _mapper.Map<UserDto>(user);

                if(result.Succeeded)
                {
                    return userDto;
                }

                throw new UnauthorizedException(UnauthorizedException.Reason.WrongPassword);

            }
        }
    }
}
