using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeatureToggleManager
{
    /// <summary>
    /// IToggleManagerQueryable
    /// </summary>
    public interface IToggleManagerQueryable
    {
        Dictionary<string, object> AllToggles();
        bool IsON(string toggleName);
        string GetString(string toggleName);
        double GetNumber(string toggleName);
        string GetJSON(string toggleName);


    }
}
