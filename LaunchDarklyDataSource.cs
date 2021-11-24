using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggleManager
{
    internal class LaunchDarklyDataSource : IToggelManagerDataSource, IToggleManagerQueryable
    {
        public async Task<bool> ConnectToLD(string environmentKey, string appVersion)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateUser(string userMID, bool isEmployee)
        {
            throw new NotImplementedException();
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
