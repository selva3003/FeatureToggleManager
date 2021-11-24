using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggleManager
{
    class Toggle
    {
        private string Name;
        private bool State;

        public Toggle(string name, bool state)
        {
            Name = name;
            State = state;
        }
    }
}
