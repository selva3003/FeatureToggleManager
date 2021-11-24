using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggleManager
{
    /// <summary>
    /// The atrributes listed in the class will be sent in a customized dictionary to LD
    /// </summary>
    public class ToggleConfiguration
    {
        public string AppVersion = string.Empty;
        public string Groups = string.Empty;
        public string PreLoginID = string.Empty;
        public string MID = string.Empty;

        public Dictionary<string, object> GetToggles()
        {
            return null;
        }
    }
}
