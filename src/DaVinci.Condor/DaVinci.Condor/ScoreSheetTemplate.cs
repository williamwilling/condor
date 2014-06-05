using System;
using System.Collections.Generic;

namespace DaVinci.Condor
{
    /// <summary>Represents the score sheet template. This template contains the list of criteria
    /// on which a candidate is assessed. Based on this template, you can create a
    /// <see cref="ScoreSheet" /> for each assessor.</summary>
    public class ScoreSheetTemplate
    {
        /// <summary>Initializes a new instance of the ScoreSheetTemplate class.</summary>
        public ScoreSheetTemplate()
        {
            Criteria = new List<Criterion>();
        }

        /// <summary>Gets or sets score sheet template's unique identifier.</summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>Gets the list of criteria on which a candidate is assessed.</summary>
        public IList<Criterion> Criteria
        {
            get;
            private set;
        }
    }
}