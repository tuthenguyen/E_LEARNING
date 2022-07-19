using E_LEARNING.CORE.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.CORE.BusinessDomain
{
    public class Account : BaseEntityWithDateModified
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gmail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// StudentId
        /// </summary>
        public int? StudentId { get; set; }

        /// <summary>
        /// AdminId
        /// </summary>
        public int? AdminId { get; set; }

        /// <summary>
        /// TeacherId
        /// </summary>
        public int? TeacherId { get; set; }

        /// <summary>
        /// refs
        /// </summary>
        public virtual Admin Admin { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
