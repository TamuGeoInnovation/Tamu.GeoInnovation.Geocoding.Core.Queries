using System;
using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.Core.Geocoders.GeocodingQueries.Options;

namespace USC.GISResearchLab.Common.Core.Geocoders.GeocodingQueries
{

    public enum QueryMedium { SoapApi, HttpApi, KmlApi, HtmlForm, BatchProcess}

    public class GeocodingQuery : ICloneable
    {
        #region Properties

        public StreetAddress StreetAddress { get; set; }
        public BaseOptions BaseOptions { get; set; }

        #endregion

        public GeocodingQuery(StreetAddress streetAddress)
        {
            StreetAddress = streetAddress;
        }

        public GeocodingQuery(BaseOptions baseOptions)
        {
            BaseOptions = baseOptions;
        }

        public GeocodingQuery(StreetAddress streetAddress, BaseOptions baseOptions)
        {
            StreetAddress = streetAddress;
            BaseOptions = baseOptions;
        }

        #region ICloneable Members

        object ICloneable.Clone()
        {
            return Clone();
        }

        #endregion

        public virtual GeocodingQuery Clone()
        {
            return (GeocodingQuery)MemberwiseClone();
        }
    }
}
