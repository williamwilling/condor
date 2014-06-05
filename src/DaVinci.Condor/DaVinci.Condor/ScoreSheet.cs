using System;
using System.Collections.Generic;

namespace DaVinci.Condor
{
    public class ScoreSheet
    {
        public ScoreSheet(ScoreSheetTemplate template)
        {
            Template = template;
            Observations = new Dictionary<Criterion, ObservationState>();

            foreach (var criterion in template.Criteria)
            {
                Observations.Add(criterion, ObservationState.Pending);
            }
        }

        public int Id
        {
            get;
            set;
        }

        public ScoreSheetTemplate Template
        {
            get;
            private set;
        }

        public IDictionary<Criterion, ObservationState> Observations
        {
            get;
            private set;
        }
    }
}