using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggleManager
{
    /// <summary>
    /// IToggelManagerDataSource
    /// </summary>
    public interface IToggelManagerDataSource
    {
        Task<bool> ConnectToLD(string environmentKey, string appVersion);
        Task<bool> UpdateUser(string userMID, bool isEmployee);
    }
}
