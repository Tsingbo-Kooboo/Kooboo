﻿using Kooboo.Sites.DataTrace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kooboo.Sites.DataTraceAndModify
{
    public class RepeatItemTrace : ITraceability
    {
        readonly string _alias;
        public RepeatItemTrace(string alias)
        {
            _alias = alias;
        }

        public string Source => "repeatitem";


        public IDictionary<string, string> GetTraceInfo()
        {
            return new Dictionary<string, string>{
                {"alias",_alias}
            };
        }
    }
}
