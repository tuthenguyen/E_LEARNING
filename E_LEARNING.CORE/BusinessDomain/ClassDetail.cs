using E_LEARNING.CORE.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.CORE.BusinessDomain
{
    public class ClassDetail : BaseEntityWithDateModified
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// PasswordClass
        /// </summary>
        public string PasswordClass { get; set; }

        /// <summary>
        /// Teacher
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        /// Lesson
        /// </summary>
        public string Lesson { get; set; }

        /// <summary>
        /// StudyTime
        /// </summary>
        public string StudyTime { get; set; }

        /// <summary>
        /// Schedule
        /// </summary>
        public string Schedule { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Class Id
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// Refs
        /// </summary>
        public virtual Class Class { get; set; }
        public virtual ICollection<ClassTeacherReference> ClassTeacherReferences { get; set; }
    }
}
