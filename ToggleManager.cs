using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeatureToggleManager
{
    /// <summary>
    /// Framework to manage local and remote toggles.
    /// </summary>
    public class ToggleManager
    {
        /// <summary>
        /// Used to determine which datastore should be pointed to.
        /// </summary>
        public bool ShouldUseLaunchDarklyToggles = true;

        //Launch Darkly data source.
        private LaunchDarklyDataSource launchDarklyDS = null;

        //Contains collection of local toggles sourced from all toggles in Launch Darkly.
        //private LocalDataStoreSlot localToggleDS = null;

        public ToggleManager()
        {
            launchDarklyDS = new LaunchDarklyDataSource();

        }
        /// <summary>
        /// Initializes Launch Darkly
        /// </summary>
        /// <param name="environment">to identify which project and environment to point in LD</param>
        /// <param name="appversion">used for app version strategy</param>
        public void Connect(string environment, string appversion)
        {

        }
        /// <summary>
        /// Returns if the requested toggle is on or off
        /// </summary>
        /// <param name="toggleName">Name of the toggle being checked</param>
        /// <returns></returns>
        public bool IsOn(string toggleName)
        {
            return false;
        }

        /// <summary>
        /// Returns if the requested toggle is on or off, specific for objc it does not return an optional.
        /// </summary>
        /// <param name="toggleName">Name of the toggle being checked</param>
        /// <returns></returns>
        public bool IsOnObjc(string toggleName, object defaultValue)
        {
            return false;
        }

        /// <summary>
        /// Returns string val for given toggle name.
        /// </summary>
        /// <param name="toggleName">Name of the toggle being checked</param>
        /// <returns></returns>
        public string GetString(string toggleName)
        {
            return "";
        }

        /// <summary>
        /// Object version of GetString
        /// </summary>
        /// <param name="toggleName">Name of the toggle being checked</param>
        /// <returns></returns>
        public string GetStringObjc(string toggleName, object defaultValue)
        {
            return "";
        }

        /// <summary>
        /// Returns Int val for given toggle name.
        /// </summary>
        /// <param name="toggleName">Name of the toggle being checked</param>
        /// <returns></returns>
        public int GetNumber(string toggleName)
        {
            return 0;
        }

        /// <summary>
        /// Returns Int val for given toggle name.
        /// </summary>
        /// <param name="toggleName">Name of the toggle being checked</param>
        /// <returns></returns>
        public int GetNumberObjc(string toggleName, object defaultValue)
        {
            return 0;
        }

        /// <summary>
        /// Returns json string for given toggle name.
        /// </summary>
        /// <param name="toggleName">Name of the toggle being checked</param>
        /// <returns></returns>
        public string GetJson(string toggleName)
        {
            return "";
        }

        /// <summary>
        /// Returns Int val for given toggle name.
        /// </summary>
        /// <param name="toggleName">Name of the toggle being checked</param>
        /// <returns></returns>
        public string GetJsonObjc(string toggleName, object defaultValue)
        {
            return "";
        }

        public Dictionary<string, object> GetAllToggles()
        {
            return null;
        }

        /// <summary>
        /// Updates the user which LD is retrieving toggles for. Before the user lgs in we cannot apply any target methods. After the user logs in we can update th user identity.
        /// </summary>
        /// <param name="userMID"></param>
        /// <param name="isEmployee"></param>
        public void UpdateUser(string userMID, bool isEmployee)
        {

        }

    }
}
