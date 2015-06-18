using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.Exceptions.Geocoding.Parameters;
using USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators.DataSources.Interfaces;

namespace USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators.DataSources.Implementations
{

    public class TigerLines : SourceValidator
	{
		public static int[] m_supportedMethods = {
													 IneterpolationMethodNames.METHOD_ADDRESS_RANGE,
													 IneterpolationMethodNames.METHOD_UNIFORM_LOT_SIZE,
													 IneterpolationMethodNames.METHOD_ACTUAL_LOT_SIZE,
													 IneterpolationMethodNames.METHOD_ACTUAL_GEOMETRY
												 };

		public string getName()
		{
			return DataSourceNames.SOURCE_NAME_TIGERLINES;
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
				// tiger - address_range works for all addresses
				if (method == IneterpolationMethodNames.METHOD_ADDRESS_RANGE)
				{
					ret = true;
				}
				// tiger uniform lot only works for addresses where an assessor exists
				else if (method == IneterpolationMethodNames.METHOD_UNIFORM_LOT_SIZE)
				{
					// right now we will hard code the assessor to work only for laassessor
					// need to factor this out into a factory assessor and other types of sources which can return wether an address is valid
					// los angeles county zips:   90001 to 90899     91001 to 93599

					// Should be :
					// AddressValidator av = AddressValidatorFactory.new()
					// bool ret = av.validate(address)
					//
					// where an AddressValidator is anything which can say whether an address exists,
					// including an assessor site
					//


					// need to handle cases based on geogrhapic region instead of hardcoding zips because addresses can be cities/mcds without zips
					/*
					if ( ((address.zipInt >= 90001) && (address.zipInt <= 90899)) || ((address.zipInt >= 91001) && (address.zipInt <= 93599)))
					{
						ret = true;
					}
					else
					{
						ret = false;
						if (shouldThrowError)
						{
							throw new ZipcodeException(getName() + ": " + IneterpolationMethodNames.getMethodstringFromInt(method) + ":  only works for addresses in LA County - zips: 90001 to 90899 and 91001 to 93599");
						}
					}
					*/

					ret = true;

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
