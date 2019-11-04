using USC.GISResearchLab.Common.Utils.Strings;

namespace USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators
{
    /// <summary>
    /// Summary description for IneterpolationMethodNames.
    /// </summary>
    public class IneterpolationMethodNames
    {

        public const int METHOD_ADDRESS_RANGE = 0;
        public const int METHOD_UNIFORM_LOT_SIZE = 1;
        public const int METHOD_ACTUAL_LOT_SIZE = 2;
        public const int METHOD_ACTUAL_GEOMETRY = 3;

        public const int METHOD_ZIP_CODE_CENTROID = 4;
        public const int METHOD_CITY_CENTROID = 5;
        public const int METHOD_COUNTY_SUBREGION_CENTROID = 6;
        public const int METHOD_COUNTY_CENTROID = 7;
        public const int METHOD_STATE_CENTROID = 8;

        public const string METHOD_NAME_ADDRESS_RANGE = "METHOD_ADDRESS_RANGE";
        public const string METHOD_NAME_UNIFORM_LOT_SIZE = "METHOD_UNIFORM_LOT_SIZE";
        public const string METHOD_NAME_ACTUAL_LOT_SIZE = "METHOD_ACTUAL_LOT_SIZE";
        public const string METHOD_NAME_ACTUAL_GEOMETRY = "METHOD_ACTUAL_GEOMETRY";

        public const string METHOD_NAME_ZIP_CODE_CENTROID = "METHOD_ZIP_CODE_CENTROID";
        public const string METHOD_NAME_CITY_CENTROID = "METHOD_CITY_CENTROID";
        public const string METHOD_NAME_COUNTY_SUBREGION_CENTROID = "METHOD_COUNTY_SUBREGION_CENTROID";
        public const string METHOD_NAME_COUNTY_CENTROID = "METHOD_COUNTY_CENTROID";
        public const string METHOD_NAME_STATE_CENTROID = "METHOD_STATE_CENTROID";

        public IneterpolationMethodNames()
        {
        }

        public static int getMethodFromString(string s)
        {
            int ret = -1;
            s = s.ToLower();
            if ((s.Equals(METHOD_NAME_ADDRESS_RANGE.ToLower())) || (s.Equals("address range")) || (s.Equals("address-range")) || (s.Equals("range")) || (s.Equals("r")))
            {
                ret = METHOD_ADDRESS_RANGE;
            }
            else if ((s.Equals(METHOD_NAME_UNIFORM_LOT_SIZE.ToLower())) || (s.Equals("uniform lot size")) || (s.Equals("uniform lot")) || (s.Equals("uniform-lot")) || (s.Equals("uniform")) || (s.Equals("u")))
            {
                ret = METHOD_UNIFORM_LOT_SIZE;
            }
            else if ((s.Equals(METHOD_NAME_ACTUAL_LOT_SIZE.ToLower())) || (s.Equals("actual lot size")) || (s.Equals("actual lot")) || (s.Equals("actual-lot")) || (s.Equals("actual")) || (s.Equals("a")))
            {
                ret = METHOD_ACTUAL_LOT_SIZE;
            }
            else if ((s.Equals(METHOD_NAME_ACTUAL_GEOMETRY.ToLower())) || (s.Equals("actual geometry")) || (s.Equals("actual-geometry")) || (s.Equals("geom")) || (s.Equals("g")))
            {
                ret = METHOD_ACTUAL_GEOMETRY;
            }

            else if ((s.Equals(METHOD_NAME_ZIP_CODE_CENTROID.ToLower())) || (s.Equals("zip code centroid")) || (s.Equals("zip")) || (s.Equals("z")))
            {
                ret = METHOD_ZIP_CODE_CENTROID;
            }
            else if ((s.Equals(METHOD_NAME_CITY_CENTROID.ToLower())) || (s.Equals("city centroid")) || (s.Equals("city")) || (s.Equals("cty")))
            {
                ret = METHOD_CITY_CENTROID;
            }
            else if ((s.Equals(METHOD_NAME_COUNTY_SUBREGION_CENTROID.ToLower())) || (s.Equals("county subregion centroid")) || (s.Equals("countysub")) || (s.Equals("cousbr")))
            {
                ret = METHOD_COUNTY_SUBREGION_CENTROID;
            }
            else if ((s.Equals(METHOD_NAME_COUNTY_CENTROID.ToLower())) || (s.Equals("county centroid")) || (s.Equals("county")))
            {
                ret = METHOD_COUNTY_CENTROID;
            }
            else if ((s.Equals(METHOD_NAME_STATE_CENTROID.ToLower())) || (s.Equals("state centroid")) || (s.Equals("state")) || (s.Equals("s")))
            {
                ret = METHOD_STATE_CENTROID;
            }

            return ret;
        }

        public static bool validateMethod(string method)
        {
            // return true if method is blank or a valid one
            bool ret = true;
            if (!StringUtils.IsEmpty(method))
            {
                int methodInt = getMethodFromString(method);
                if (methodInt < 0)
                {
                    ret = false;
                }
            }
            return ret;
        }

        public static int getMethod(string method)
        {
            // method will default to address range unless otherwise specified
            int ret = -1;
            if (StringUtils.IsEmpty(method))
            {
                ret = METHOD_ADDRESS_RANGE;
            }
            else
            {
                ret = getMethodFromString(method);
            }
            return ret;
        }

        public static string getMethodstringFromInt(int i)
        {
            string ret = "";
            switch (i)
            {
                case METHOD_ADDRESS_RANGE:
                    ret = METHOD_NAME_ADDRESS_RANGE;
                    break;
                case METHOD_UNIFORM_LOT_SIZE:
                    ret = METHOD_NAME_UNIFORM_LOT_SIZE;
                    break;
                case METHOD_ACTUAL_LOT_SIZE:
                    ret = METHOD_NAME_ACTUAL_LOT_SIZE;
                    break;
                case METHOD_ACTUAL_GEOMETRY:
                    ret = METHOD_NAME_ACTUAL_GEOMETRY;
                    break;
                case METHOD_ZIP_CODE_CENTROID:
                    ret = METHOD_NAME_ZIP_CODE_CENTROID;
                    break;
                case METHOD_CITY_CENTROID:
                    ret = METHOD_NAME_CITY_CENTROID;
                    break;
                case METHOD_COUNTY_SUBREGION_CENTROID:
                    ret = METHOD_NAME_COUNTY_SUBREGION_CENTROID;
                    break;
                case METHOD_COUNTY_CENTROID:
                    ret = METHOD_NAME_COUNTY_CENTROID;
                    break;
                case METHOD_STATE_CENTROID:
                    ret = METHOD_NAME_STATE_CENTROID;
                    break;
                default:
                    break;
            }
            return ret;
        }


        public static string getMethodListFromIntArray(int[] methods)
        {
            string ret = "";
            for (int i = 0; i < methods.Length; i++)
            {
                ret += getMethodstringFromInt(methods[i]) + ", ";
            }
            ret = StringUtils.TrimCSVList(ret);
            return ret;
        }

        public static bool methodIsSupported(int method, int[] methodList)
        {
            bool ret = false;
            for (int i = 0; i < methodList.Length; i++)
            {
                if (method == methodList[i])
                {
                    ret = true;
                }
            }
            return ret;
        }
    }
}
