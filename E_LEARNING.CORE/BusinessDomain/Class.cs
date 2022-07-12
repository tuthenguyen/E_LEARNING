using E_LEARNING.CORE.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.CORE.BusinessDomain
{
    public class Class : BaseEntityWithDateModified
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
        /// Topic
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Semester
        /// </summary>
        public string Semester { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// Subject Id
        /// </summary>
        public int SubjectId { get; set; }

        //relationship
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<ClassDetail> ClassDetails { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
