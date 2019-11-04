namespace USC.GISResearchLab.Common.Core.Geocoders.GeocodingQueries.Options
{
    public class SingleParsed : BaseOptions
    {
        #region Properties

        private string _Number;
        public string Number
        {
            get { return _Number; }
            set { _Number = value; }
        }

        private string _Predirectional;
        public string Predirectional
        {
            get { return _Predirectional; }
            set { _Predirectional = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Postdirectional;
        public string Postdirectional
        {
            get { return _Postdirectional; }
            set { _Postdirectional = value; }
        }

        private string _Suffix;
        public string Suffix
        {
            get { return _Suffix; }
            set { _Suffix = value; }
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

        public SingleParsed()
        {
            Number = "";
            Predirectional = "";
            Name = "";
            Postdirectional = "";
            Suffix = "";
            City = "";
            State = "";
            Zip = "";
        }

    }
}
