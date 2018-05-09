using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace transFormat
{
    class Rule
    {
        public Rule()
        {
            this.RuleGroup = new List<SingleRule>();
        }

        public List<SingleRule> RuleGroup { get; set; }
    }
}
