using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular.Core.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Angular.com.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Declaration
        private readonly IUserServices _userServices;
        #endregion

        #region Constructor
        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        #endregion

        #region Get User Details
        /// <summary>
        /// Get User Details
        /// </summary>
        /// <returns></returns>
        public string GetUserDetails()
        {
            return _userServices.GetUserDetails();
        }
        #endregion
    }
}