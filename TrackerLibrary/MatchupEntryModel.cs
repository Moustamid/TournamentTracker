﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; }

        public double ParentMatchup { get; set; }
    }
}