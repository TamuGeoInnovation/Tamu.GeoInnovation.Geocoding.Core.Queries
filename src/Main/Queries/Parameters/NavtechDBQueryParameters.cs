namespace USC.GISResearchLab.Geocoding.Core.Queries.Parameters
{
    /// <summary>
    /// Summary description for NavtechDBQueryParameters.
    /// </summary>
    public class NavtechDBQueryParameters : DBQueryParameters
    {
        public NavtechDBQueryParameters(ParameterSet parameterSet)
        {
            value_number = parameterSet.StreetAddress.Number;
            value_preDirectional = parameterSet.StreetAddress.PreDirectional;
            value_name = parameterSet.StreetAddress.StreetName;
            value_postDirectional = parameterSet.StreetAddress.PostDirectional;
            value_city = parameterSet.StreetAddress.City;
            value_state = parameterSet.StreetAddress.State;
            value_zip = parameterSet.StreetAddress.ZIP;

            // these are not finished yet

            this.name_fromNumberRight = "fraddl";
            this.name_toNumberRight = "toaddl";
            this.name_fromNumberRight = "fraddr";
            this.name_toNumberRight = "toaddr";
            this.name_preDirectional = "fedirp";
            this.name_name = "ST_NM_BASE";
            this.name_suffix = "ST_TYP_AFT";
            this.name_postDirectional = "ST_NM_SUFF";
            this.name_city = "name";
            this.name_state = "state";
            this.name_zipRight = "zipr";
            this.name_zipLeft = "zipl";
            this.name_fips = "fips";
            this.name_cousubRight = "cousubr";
            this.name_cousubRight = "cousubl";

            /* 
			 * These should be filled in once we have figured out if the key is going to be zip or cousubr
			 * 
			this.name_keyLeft = 
			this.name_keyLeft = 
			*
			*/
        }
    }
}
