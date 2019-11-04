using USC.GISResearchLab.Common.Utils.Strings;

namespace USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators
{
    /// <summary>
    /// Summary description for SourceUtils.
    /// </summary>
    public class DataSourceNames
    {

        public const int SOURCE_TIGERLINES = 0;
        public const int SOURCE_NAVTECH = 1;
        public const int SOURCE_TIGERLINES_CONFLATED = 2;

        public const int SOURCE_ZIP_CODE_CENTROIDS = 3;
        public const int SOURCE_CITY_CENTROIDS = 4;
        public const int SOURCE_COUNTY_SUBREGION_CENTROIDS = 5;
        public const int SOURCE_COUNTY_CENTROIDS = 6;
        public const int SOURCE_STATE_CENTROIDS = 7;
        public const int SOURCE_PARCELS = 8;


        public const string SOURCE_NAME_TIGERLINES = "SOURCE_TIGERLINES";
        public const string SOURCE_NAME_NAVTECH = "SOURCE_NAVTECH";
        public const string SOURCE_NAME_TIGERLINES_CONFLATED = "SOURCE_NAME_TIGERLINES_CONFLATED";

        public const string SOURCE_NAME_ZIP_CODE_CENTROIDS = "SOURCE_ZIP_CODE_CENTROIDS";
        public const string SOURCE_NAME_CITY_CENTROIDS = "SOURCE_CITY_CENTROIDS";
        public const string SOURCE_NAME_COUNTY_SUBREGION_CENTROIDS = "SOURCE_COUNTY_SUBREGION_CENTROIDS";
        public const string SOURCE_NAME_COUNTY_CENTROIDS = "SOURCE_COUNTY_CENTROIDS";
        public const string SOURCE_NAME_STATE_CENTROIDS = "SOURCE_STATE_CENTROIDS";
        public const string SOURCE_NAME_PARCELS = "SOURCE_PARCELS";


        public DataSourceNames()
        {
        }

        public static int getSourceFromString(string s)
        {
            int ret = -1;
            s = s.ToLower();
            if ((s.Equals(SOURCE_NAME_TIGERLINES.ToLower())) || (s.Equals("tigerlines")) || (s.Equals("tiger")) || (s.Equals("t")))
            {
                ret = SOURCE_TIGERLINES;
            }
            else if ((s.Equals(SOURCE_NAME_PARCELS.ToLower())) || (s.Equals("parcels")))
            {
                ret = SOURCE_PARCELS;
            }
            else if ((s.Equals(SOURCE_NAME_TIGERLINES_CONFLATED.ToLower())) || (s.Equals("tigerlinesconflated")) || (s.Equals("conflated")) || (s.Equals("tc")))
            {
                ret = SOURCE_TIGERLINES_CONFLATED;
            }
            else if ((s.Equals(SOURCE_NAME_NAVTECH.ToLower())) || (s.Equals("navtech")) || (s.Equals("nav")) || (s.Equals("n")))
            {
                ret = SOURCE_NAVTECH;
            }
            else if ((s.Equals(SOURCE_NAME_ZIP_CODE_CENTROIDS.ToLower())) || (s.Equals("zips")))
            {
                ret = SOURCE_ZIP_CODE_CENTROIDS;
            }
            else if ((s.Equals(SOURCE_NAME_CITY_CENTROIDS.ToLower())) || (s.Equals("cities")))
            {
                ret = SOURCE_CITY_CENTROIDS;
            }
            else if ((s.Equals(SOURCE_NAME_COUNTY_SUBREGION_CENTROIDS.ToLower())) || (s.Equals("cousubs")))
            {
                ret = SOURCE_COUNTY_SUBREGION_CENTROIDS;
            }
            else if ((s.Equals(SOURCE_NAME_COUNTY_CENTROIDS.ToLower())) || (s.Equals("counties")))
            {
                ret = SOURCE_COUNTY_CENTROIDS;
            }
            else if ((s.Equals(SOURCE_NAME_STATE_CENTROIDS.ToLower())) || (s.Equals("states")))
            {
                ret = SOURCE_STATE_CENTROIDS;
            }

            return ret;
        }

        public static bool validateSource(string source)
        {
            // source will default to tigerline range unless otherwise specified
            bool ret = true;
            if (!StringUtils.IsEmpty(source))
            {
                int sourceInt = getSourceFromString(source);
                if (sourceInt < 0)
                {
                    ret = false;
                }
            }
            return ret;
        }

        public static int getSource(string source)
        {
            // source will default to tigerline range unless otherwise specified
            int ret = -1;

            if (StringUtils.IsEmpty(source))
            {
                ret = SOURCE_TIGERLINES;
            }
            else
            {
                ret = getSourceFromString(source);
            }
            return ret;
        }
    }
}
