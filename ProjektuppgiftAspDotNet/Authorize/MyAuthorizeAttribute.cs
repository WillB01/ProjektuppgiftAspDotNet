using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProjektuppgiftAspDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjektuppgiftAspDotNet.Authorize
{
    //    public class MyAuthorizeAttribute : AuthorizationHandler<MyAuthorizeAttribute>, IAuthorizationRequirement
    //    {

    //        public override void Handle(AuthorizationHandlerContext context, MyAuthorizeAttribute requirement)
    //        {
    //            if (!context.User.HasClaim(c => c.Type == ClaimTypes.DateOfBirth))
    //            {
    //                context.Fail();
    //                return;
    //            }

    //            var dateOfBirth = Convert.ToDateTime(context.User.FindFirst(c => c.Type == ClaimTypes.DateOfBirth).Value);
    //            int age = DateTime.Today.Year - dateOfBirth.Year;
    //            if (dateOfBirth > DateTime.Today.AddYears(-age))
    //            {
    //                age--;
    //            }

    //            if (age >= 18)
    //            {
    //                context.Succeed(requirement);
    //            }
    //            else
    //            {
    //                context.Fail();
    //            }
    //        }






    //        protected override bool Authorize(string user, int itemId)
    //        {
    //            var userName = HttpContext.User.Identity.Name;

    //            var authUsers = SubmissionRepository.GetAuthoriedUsers(itemId);

    //            return authUsers.Contains(user);
    //        }
    //    }

    //    public class ClaimRequirementAttribute : TypeFilterAttribute
    //    {
    //        public ClaimRequirementAttribute(string claimType, string claimValue) : base(typeof(ClaimRequirementFilter))
    //        {
    //            Arguments = new object[] { new Claim(claimType, claimValue) };
    //        }
    //    }

    //    public class ClaimRequirementFilter : IAuthorizationFilter
    //    {
    //        readonly Claim _claim;

    //        public ClaimRequirementFilter(Claim claim)
    //        {
    //            _claim = claim;
    //        }

    //        public void OnAuthorization(AuthorizationFilterContext context)
    //        {
    //            var hasClaim = context.HttpContext.User.Claims.Any(c => c.Type == _claim.Type && c.Value == _claim.Value);
    //            if (!hasClaim)
    //            {
    //                context.Result = new ForbidResult();
    //            }
    //        }
    //    }
    //}
}