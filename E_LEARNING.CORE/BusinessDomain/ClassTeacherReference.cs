using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.CORE.BusinessDomain
{
    public class ClassTeacherReference
    {
        /// <summary>
        /// Class Id
        /// </summary>
        public int ClassDetailId { get; set; }

        /// <summary>
        /// Teacher Id
        /// </summary>
        public int TeacherId { get; set; }

        /// <summary>
        /// refs
        /// </summary>
        public virtual ClassDetail ClassDetail { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
