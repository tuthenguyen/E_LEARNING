using E_LEARNING.CORE.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.CORE.BusinessDomain
{
    public class ScoreLearning : BaseEntityWithDateModified
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Scorediligence
        /// </summary>
        public double Scorediligence { get; set; }

        /// <summary>
        /// Scoreoral
        /// </summary>
        public double Scoreoral { get; set; }

        /// <summary>
        /// Score15min
        /// </summary>
        public double Score15min { get; set; }

        /// <summary>
        /// Scorecorfficient2
        /// </summary>
        public double Scorecorfficient2 { get; set; }

        /// <summary>
        /// Scorecorfficient3
        /// </summary>
        public double Scorecorfficient3 { get; set; }

        /// <summary>
        /// Mediumscore
        /// </summary>
        public double Mediumscore { get; set; }

        /// <summary>
        /// Totalscore
        /// </summary>
        public double Totalscore { get; set; }

        /// <summary>
        /// Result
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// StudentId
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// SubjectId
        /// </summary>
        public int SubjectId { get; set; }

        //relationship
        public virtual Student Student { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
