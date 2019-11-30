using Angular.Core.IRepository;
using System;

namespace Angular.Repository
{
    public class UserRepository : IUserRepository
    {
        #region Get User Details
        /// <summary>
        /// Get User Details
        /// </summary>
        /// <returns></returns>
        public string GetUserDetails()
        {
            return "Petchimuthu";
        }
        #endregion
    }
}
