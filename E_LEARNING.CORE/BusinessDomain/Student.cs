using E_LEARNING.CORE.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.CORE.BusinessDomain
{
    public class Student : BaseEntityWithDateModified
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
        /// Gmail
        /// </summary>
        public string Gmail { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public bool Gender { get; set; }

        /// <summary>
        /// Birth
        /// </summary>
        public DateTime Birth { get; set; }

        /// <summary>
        /// AccountId
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// Class Id
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// Refs
        /// </summary>
        public virtual Account Account { get; set; }
        public virtual ICollection<ScoreLearning> ScoreLearnings { get; set; }
        public virtual Class Class { get; set; }
    }
}
