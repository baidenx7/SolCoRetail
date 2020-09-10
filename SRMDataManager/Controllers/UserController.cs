﻿using Microsoft.AspNet.Identity;
using SRMDataManager.Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TRMDataManager.Library.Models;

namespace SRMDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        [HttpGet]
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();

            return data.GetUserById(userId).First();

        }
    }
}