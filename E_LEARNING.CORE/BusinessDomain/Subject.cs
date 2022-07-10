using E_LEARNING.CORE.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.CORE.BusinessDomain
{
    public class Subject : BaseEntityWithDateModified
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
        /// Refs
        /// </summary>
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<ScoreLearning> ScoreLearning { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
