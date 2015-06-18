using System;

namespace USC.GISResearchLab.Common.Core.Geocoders.GeocodingQueries.Options
{
    [Serializable]
    public class BatchNonParsed : BatchOptions
    {
        #region Properties

        public string FieldAddress { get; set; }
        public string FieldCity { get; set; }
        public string FieldState { get; set; }
        public string FieldZip { get; set; }
        public string FieldOther{ get; set; }

        #endregion

    }
}
