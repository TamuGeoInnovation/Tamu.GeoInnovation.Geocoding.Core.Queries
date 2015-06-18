namespace USC.GISResearchLab.Common.Core.Geocoders.GeocodingQueries.Options
{
    public class SingleNonParsed : BaseOptions
    {
        #region Properties

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private string _City;
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        private string _State;
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }

        private string _Zip;
        public string Zip
        {
            get { return _Zip; }
            set { _Zip = value; }
        }
        #endregion

        public SingleNonParsed()
        {
            Address = "";
            City = "";
            State = "";
            Zip = "";
        }
    }
}
