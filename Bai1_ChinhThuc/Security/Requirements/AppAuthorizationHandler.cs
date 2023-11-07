using Bai1_ChinhThuc.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Bai1_ChinhThuc.Security.Requirements
{
    public class AppAuthorizationHandler : IAuthorizationHandler
    {
        private readonly ILogger _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AppAuthorizationHandler(ILogger<AppAuthorizationHandler> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            var requirements = context.Requirements.ToList();
            foreach (var requirement in requirements)
            {
                if(requirement is GenZRequirement)
                {
                    if (IsGenZ(context.User, (GenZRequirement)requirement))
                        context.Succeed(requirement);
                }
                if(requirement is CanEditContactRequirement)
                {
                    if (CanEditContact(context.User, context.Resource, (CanEditContactRequirement)requirement))
                        context.Succeed(requirement);
                }
            }
            return Task.CompletedTask;
        }

        private bool CanEditContact(ClaimsPrincipal user,object resource ,CanEditContactRequirement requirement)
        {
            if (!_signInManager.IsSignedIn(user))
                return false;
            if (user.IsInRole("Admin"))
                return true;
            var contact = resource as Contact;
            DateTime dateTime = new DateTime(requirement.Year, requirement.Month, requirement.Day);
            DateTime dateCreate = contact.DateSent;
            if(dateCreate < dateTime)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsGenZ(ClaimsPrincipal user, GenZRequirement requirement)
        {
            var appUserTask = _userManager.GetUserAsync(user);
            Task.WaitAll(appUserTask);
            var AppUser = appUserTask.Result;
            if(!_signInManager.IsSignedIn(user))
                return false;
            if(AppUser.DateBirth == null)
            {
                _logger.LogInformation($"{AppUser.UserName} có năm sinh không có năm sinh để xét điều kiện lớn hơn " +
                    $"bằng {requirement.FromYear} và nhỏ hơn bằng {requirement.ToYear}");
                return false;
            }
            var yearOfBd = AppUser.DateBirth.Value.Year;
            var success = (yearOfBd >= requirement.FromYear && yearOfBd <= requirement.ToYear);
            if(success)
            {
                _logger.LogInformation($"{AppUser.UserName} có năm sinh thỏa mãn điều kiện lớn hơn " +
                    $"bằng {requirement.FromYear} và nhỏ hơn bằng {requirement.ToYear}");
            }
            else
            {
                _logger.LogInformation($"{AppUser.UserName} có năm sinh không thỏa mãn điều kiện lớn hơn " +
                    $"bằng {requirement.FromYear} và nhỏ hơn bằng {requirement.ToYear}");
            }
            return success;
        }
    }
}
