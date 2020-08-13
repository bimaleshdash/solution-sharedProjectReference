using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWithoutReference.Modular
{
    public class variation
    {
        private string puppet;

        public variation(string puppet)
        {
            this.puppet = puppet;
        }

        public variation Newvariant() { return new variation("test"); }
    }
}
