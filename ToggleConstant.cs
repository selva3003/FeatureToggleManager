using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggleManager
{
    public class ToggleConstant
    {
        public const bool DEFAULT_TOGGLE_VALUE = false;
        public const string PRE_LOGIN_IDENTIFIER = "PRE-LOGIN";
        public const double LD_SERVICE_TIMEOUT = 5.0;
        public const double IDENTIFY_API_TIMEOUT = 5.0;
        public const string MID_REGEX_PATTERN = "ee[\\d\\w]{32}";
        public const string USER_GROUP_EMPLOYEE = "EMPLOYEE";
        public const string USER_GROUP_NONEMPLOYEE = "NON-EMPLOYEE";

    }
}
