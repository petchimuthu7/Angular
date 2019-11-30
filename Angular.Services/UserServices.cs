using Angular.Core.IRepository;
using Angular.Core.IServices;
using System;

namespace Angular.Services
{
    public class UserServices : IUserServices
    {
        #region Declaration
        private readonly IUserRepository _userRepository;
        #endregion

        #region Constructor
        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion

        #region Get User Details
        /// <summary>
        /// Get User Details
        /// </summary>
        /// <returns></returns>
        public string GetUserDetails()
        {
            return _userRepository.GetUserDetails();
        }
        #endregion

    }
}
