using System;
using USC.GISResearchLab.Census.Core.Configurations.ServerConfigurations;
using USC.GISResearchLab.Common.Core.Geocoders.FeatureMatching;
using USC.GISResearchLab.Common.Databases.Runners.Options;
using USC.GISResearchLab.Geocoding.Core.Configurations;
using USC.GISResearchLab.Geocoding.Core.ExternalGeocoders;


namespace USC.GISResearchLab.Common.Core.Geocoders.GeocodingQueries.Options
{
    [Serializable]
    public class BaseOptions : BatchDatabaseWebOptions
    {
        #region Properties

        public ExternalGeocoderType ExternalGeocoderType { get; set; }
        //public GeocoderConfiguration GeocoderConfiguration { get; set; }

        

        public bool ShouldOutputCensusFields { get; set; }
        public CensusYear CensusYear { get; set; }
        public bool ShouldOutputReferenceFeatureGeometry { get; set; }
       


        #endregion

        public BaseOptions()
        {
           
        }

        public BaseOptions(FeatureMatchingSelectionMethod featureMatchingHierarchy, bool shouldUseRelaxation, bool shouldUseFuzzy, bool shouldUseCaching, bool shouldReturnExhaustiveGeocodes, bool shouldUseDynamicComposition, bool shouldOutputCensusFields)
        {
          
        }
    }
}
