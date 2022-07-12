using E_LEARNING.CORE.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.CORE.BusinessDomain
{
    public class Teacher : BaseEntityWithDateModified
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
        public int AccounId { get; set; }

        /// <summary>
        /// Refs
        /// </summary>
        public virtual Account Account { get; set; }
        public virtual ICollection<ClassTeacherReference> ClassTeacherReferences { get; set; }
    }
}
