using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectReferredCommon.Collection
{
    public class TollSTart
    {
        private int cost;
        private string gate;

        public TollSTart(string gate,int cost)
        {
            this.cost = cost;
            this.gate = gate;
        }
        public string TollGate() { return gate; }
        public int Cost() { return cost; }
        public string Vehicle() { return "4 Wheelers"; }

    }
}
