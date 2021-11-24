using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggleManager
{
    internal class LocalToggleDataSourcce : IToggleManagerQueryable
    {
        public Dictionary<string, object> TogglesDictionary = null;

        public LocalToggleDataSourcce()
        {
            TogglesDictionary = new Dictionary<string, object>();
        }

        public void Update(Dictionary<string, object> togglesDictionary)
        {
        }
        public Dictionary<string, object> AllToggles()
        {
            throw new NotImplementedException();
        }

        public bool IsON(string toggleName)
        {
            throw new NotImplementedException();
        }

        public string GetString(string toggleName)
        {
            throw new NotImplementedException();
        }

        public double GetNumber(string toggleName)
        {
            throw new NotImplementedException();
        }

        public string GetJSON(string toggleName)
        {
            throw new NotImplementedException();
        }
    }
}
