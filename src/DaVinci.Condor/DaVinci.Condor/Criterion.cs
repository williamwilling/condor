using System;

namespace DaVinci.Condor
{
    /// <summary>Represents a criterion on which a candidate is assessed.</summary>
    public class Criterion
    {
        /// <summary>Gets or sets the criterion's unique identifier.</summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>Gets or sets the description that specifies the behavior an assessor should
        /// observe.</summary>
        public string Description
        {
            get;
            set;
        }

        /// <summary>Gets or sets the mark a candidate receives when he or she meets the criterion.
        /// </summary>
        public Mark Mark
        {
            get;
            set;
        }
    }
}