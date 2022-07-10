using E_LEARNING.CORE.Base;

namespace E_LEARNING.CORE.BusinessDomain
{
    public class Test : BaseEntityWithDateModified
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
        /// Content
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Time
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Score
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// SubjectId
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// Refs
        /// </summary>
        public virtual Subject Subject { get; set; }
    }
}
