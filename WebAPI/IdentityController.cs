﻿using System.Linq;
using System.Security.Claims;
using System.Web.Http;

namespace WebAPI
{
    public class IdentityController: ApiController
    {
        [Route("identity")]
        [Authorize]
        public IHttpActionResult Get()
        {
            var user = User as ClaimsPrincipal;
            var claims = from c in user.Claims
                         select new
                         {
                             type = c.Type,
                             value = c.Value
                         };

            return Json(claims);
        }
    }

}