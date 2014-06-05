using System;
using System.Collections.Generic;

namespace DaVinci.Condor
{
    public class ScoreSheet
    {
        public ScoreSheet()
        {
            Criteria = new List<Criterion>();
        }

        public int Id
        {
            get;
            set;
        }

        public IList<Criterion> Criteria
        {
            get;
            private set;
        }
    }
}