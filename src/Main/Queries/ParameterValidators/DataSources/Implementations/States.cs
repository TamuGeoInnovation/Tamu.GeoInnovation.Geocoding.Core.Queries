using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.Exceptions.Geocoding.Parameters;
using USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators.DataSources.Interfaces;

namespace USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators.DataSources.Implementations
{

    public class States : SourceValidator
	{
		public static int[] m_supportedMethods = {
													 IneterpolationMethodNames.METHOD_STATE_CENTROID
												 };

		public string getName()
		{
			return DataSourceNames.SOURCE_NAME_STATE_CENTROIDS;
		}

		public int[] getAllSupportedMethods()
		{
			return m_supportedMethods;
		}

		public bool validateMethodForAddress(int method, ValidateableStreetAddress address, bool shouldThrowError)
		{
			bool ret = true;
			if (!IneterpolationMethodNames.methodIsSupported(method, getAllSupportedMethods()))
			{
				ret = false;
				if (shouldThrowError)
				{
					throw new InvalidMethodException("Source: " + getName() + " Only Supports Methods: " + IneterpolationMethodNames.getMethodListFromIntArray(getAllSupportedMethods()));
				}
			}
			return ret;
		}


		public bool validateParameters(ValidateableStreetAddress address, bool shouldThrowException)
		{
			bool ret = true;

			if (!address.HasState)
			{
				ret = false;
				if (shouldThrowException)
				{
					throw new RequiredParameterException (getName() + ": " + "State name is required");
				}
			}

			return ret;
		}
		

	}
}
