using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.Exceptions.Geocoding.Parameters;
using USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators.DataSources.Interfaces;

namespace USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators.DataSources.Implementations
{

    public class ZipCode : SourceValidator
	{
		public static int[] m_supportedMethods = {
													 IneterpolationMethodNames.METHOD_ZIP_CODE_CENTROID
												 };

		public string getName()
		{
			return DataSourceNames.SOURCE_NAME_ZIP_CODE_CENTROIDS;
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

			if (!address.HasValidZIP)
			{
				ret = false;
				if (shouldThrowException)
				{
					throw new RequiredParameterException (getName() + ": " + "Correctly Formatted Zip code is required");
				}
			}

			return ret;
		}

	}
}
