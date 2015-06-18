using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.Exceptions.Geocoding.Parameters;
using USC.GISResearchLab.Common.Exceptions.Geocoding.Parameters.Addresses;
using USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators.DataSources.Interfaces;

namespace USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators.DataSources.Implementations
{

    public class TigerLinesConflated : SourceValidator
	{
		public static int[] m_supportedMethods = {
													 IneterpolationMethodNames.METHOD_ADDRESS_RANGE,
													 IneterpolationMethodNames.METHOD_UNIFORM_LOT_SIZE,
													 IneterpolationMethodNames.METHOD_ACTUAL_LOT_SIZE,
													 IneterpolationMethodNames.METHOD_ACTUAL_GEOMETRY
												 };

		public string getName()
		{
			return DataSourceNames.SOURCE_NAME_TIGERLINES_CONFLATED;
		}

		public int[] getAllSupportedMethods()
		{
			return m_supportedMethods;
		}

		public bool validateMethodForAddress(int method, ValidateableStreetAddress address, bool shouldThrowError)
		{
			bool ret = true;
			// check if this source supports the requested method
			if (!IneterpolationMethodNames.methodIsSupported(method, getAllSupportedMethods()))
			{
				ret = false;
				if (shouldThrowError)
				{
					throw new InvalidMethodException("Source: " + getName() + " Only Supports Methods: " + IneterpolationMethodNames.getMethodListFromIntArray(getAllSupportedMethods()));
				}
			}
			else
			{
				if ((!address.City.ToLower().Equals("el segundo")) && (!address.ZIP.Equals("90245")))
				{
					ret = false;
					if (shouldThrowError)
					{
						throw new ZipcodeException(getName() + " only works for addresses in el segundo, ca 90245");
					}
				}
			}
			return ret;
		}

		public bool validateParameters(ValidateableStreetAddress address, bool shouldThrowException)
		{
			bool ret = true;

			ret = ret && address.HasValidZIP;

			// check that the state is there
			if (!address.HasState)
			{
				ret = false;
				if (shouldThrowException)
				{
					throw new RequiredParameterException(getName() + ": " + "state is required");
				}
			}

			// check that it has either a city+state or zip
			if (!address.HasValidZIP && !address.HasCityState)
			{
				ret = false;
				if (shouldThrowException)
				{
					throw new RequiredParameterException (getName() + ": " + "Either city and state or zip code are required");
				}
			}

			return ret;
		}


	}
}
