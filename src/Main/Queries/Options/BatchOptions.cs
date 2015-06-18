using System;
using TAMU.GeoInnovation.PointIntersectors.Census.Metadata.OutputFields;
using USC.GISResearchLab.Common.Databases.FieldMappings;
using USC.GISResearchLab.Common.Databases.Runners.Metadata.OutputFields;
using USC.GISResearchLab.Geocoding.Core.Metadata.OutputFields;

namespace USC.GISResearchLab.Common.Core.Geocoders.GeocodingQueries.Options
{
    [Serializable]
    public class BatchOptions : BaseOptions
    {
        #region Properties

        public OutputDatabaseFieldMappings OutputGeocodeFieldMappings { get; set; }
        public OutputDatabaseFieldMappings OutputParsedAddressFieldMappings { get; set; }
        public OutputDatabaseFieldMappings OutputInputAddressFieldMappings { get; set; }
        public OutputDatabaseFieldMappings OutputMatchedAddressFieldMappings { get; set; }
        public OutputDatabaseFieldMappings OutputReferenceFeatureFieldMappings { get; set; }
        public OutputDatabaseFieldMappings OutputCensusFieldMappings { get; set; }
        public OutputDatabaseFieldMappings OutputBookKeepingFieldMappings { get; set; }

        #endregion


        public BatchOptions()
        {
            OutputGeocodeFieldMappings = new OutputDatabaseFieldMappings(OutputGeocodeFields.GetOutputFields());
            OutputParsedAddressFieldMappings = new OutputDatabaseFieldMappings(OutputParsedAddressFields.GetOutputFields());
            OutputInputAddressFieldMappings = new OutputDatabaseFieldMappings(OutputInputAddressFields.GetOutputFields());
            OutputMatchedAddressFieldMappings = new OutputDatabaseFieldMappings(OutputMatchedAddressFields.GetOutputFields());
            OutputReferenceFeatureFieldMappings = new OutputDatabaseFieldMappings(OutputReferenceFeatureFields.GetOutputFields());
            OutputCensusFieldMappings = new OutputDatabaseFieldMappings(OutputCensusFields.GetOutputFields());
            OutputBookKeepingFieldMappings = new OutputDatabaseFieldMappings(OutputBookKeepingFields.GetOutputFields());

        }
    }
}
