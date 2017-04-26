using System;
using System.Collections.Generic;
using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.Geographics.Units;
//using USC.GISResearchLab.Geocoding.Core.Algorithms.FeatureMatchScorers;
using USC.GISResearchLab.Geocoding.Core.Configurations;
using USC.GISResearchLab.Geocoding.Core.Algorithms.FeatureMatchScorers;

namespace USC.GISResearchLab.Geocoding.Core.Queries.Parameters
{
    public class ParameterSet : ICloneable
    {
        //public GeocoderConfiguration GeocoderConfiguration { get; set; }
        public string MethodStr { get; set; }
        public int MethodInt { get; set; }
        public string SourceStr { get; set; }
        public int SourceInt { get; set; }
        public bool HasZip { get; set; }
        public bool HasCityState { get; set; }
        public StreetAddress StreetAddress { get; set; }
        public StreetAddress AttemptedStreetAddress { get; set; }
        public RelaxableStreetAddress RelaxableStreetAddress { get; set; }
        public DBQueryParameters DbQueryParameters { get; set; }
        public string AgentServerUrl { get; set; }
        public LinearUnitTypes OutputUnits { get; set; }
        public LinearUnitTypes DropbackUnits { get; set; }
        public double DropbackValue { get; set; }
        public bool ShouldUseRelaxation { get; set; }
        public bool shouldUseSubstring { get; set; }
        public bool ShouldUseSoundex { get; set; }
        public bool ShouldUseCaching { get; set; }
        public bool ShouldAllowNearbyMatches { get; set; }
        public List<AddressComponents> RelaxableAttributes { get; set; }
        public List<AddressComponents> SoundexAttributes { get; set; }
        public AttributeWeightingScheme AttributeWeightingScheme { get; set; }
        public double MinimumMatchScore { get; set; }
        public int ConfidenceLevels { get; set; }


        public static ParameterSet buildParameterSet(StreetAddress address)
        {
            return buildParameterSet(address, LinearUnitTypes.Meters);
        }

        public static ParameterSet buildParameterSet(StreetAddress address, LinearUnitTypes outputUnits)
        {

            ParameterSet ret = new ParameterSet();
            ret.StreetAddress = address;
            ret.OutputUnits = outputUnits;

            //if (StringUtils.IsEmpty(agentServerUrl))
            //{
            //    agentServerUrl = AgentUtils.getAgentServerUrl();
            //}

            //agentServerUrl = StringUtils.Sanitize(agentServerUrl);




            //// check that the method parameter is acceptable
            //bool validMethod = IneterpolationMethodNames.validateMethod(method);
            //if (validMethod)
            //{
            //    parameterSet.methodInt = IneterpolationMethodNames.getMethod(method);
            //}
            //else
            //{
            //    throw new InvalidMethodException("Valid methods are address range (r), uniform lot size (u), and actual lot size (a)");
            //}

            //// check that the source parameter is acceptable
            //bool validSource = DataSourceNames.validateSource(source);
            //if (validSource)
            //{
            //    parameterSet.sourceInt = DataSourceNames.getSource(source);
            //}
            //else
            //{
            //    throw new InvalidSourceException("Valid sources are tigerlines (t) and navtech (n)");
            //}



            //parameterSet.agentServerUrl = agentServerUrl;

            return ret;
        }

        #region ICloneable Members

        object ICloneable.Clone()
        {
            return Clone();
        }

        public virtual ParameterSet Clone()
        {
            return (ParameterSet)MemberwiseClone();
        }

        #endregion

    }
}
