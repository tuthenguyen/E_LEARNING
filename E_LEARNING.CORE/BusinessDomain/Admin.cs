using E_LEARNING.CORE.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.CORE.BusinessDomain
{
    public class Admin : BaseEntityWithDateModified
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public bool Gender { get; set; }

        /// <summary>
        /// AccountId
        /// </summary>
        public int AccountId { get; set; }


        /// <summary>
        /// refs
        /// </summary>
        public virtual Account Account { get; set; }
    }
}
