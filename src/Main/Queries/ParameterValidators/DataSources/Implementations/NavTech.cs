using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.Exceptions.Geocoding.Parameters;
using USC.GISResearchLab.Common.Exceptions.Geocoding.Parameters.Addresses;
using USC.GISResearchLab.Common.Utils.Strings;
using USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators.DataSources.Interfaces;

namespace USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators.DataSources.Implementations
{

    public class NavTech : SourceValidator
    {

        public static int[] m_supportedMethods = {
                                                     IneterpolationMethodNames.METHOD_ADDRESS_RANGE,
                                                     IneterpolationMethodNames.METHOD_UNIFORM_LOT_SIZE,
                                                     IneterpolationMethodNames.METHOD_ACTUAL_LOT_SIZE,
                                                     IneterpolationMethodNames.METHOD_ACTUAL_GEOMETRY
                                                 };

        public string getName()
        {
            return DataSourceNames.SOURCE_NAME_NAVTECH;
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
                if ((!address.City.ToLower().Equals("washington")) && (!address.State.ToLower().Equals("dc")))
                {
                    ret = false;
                    if (shouldThrowError)
                    {
                        throw new ParameterException(getName() + " only works for addresses in washington, dc");
                    }

                }
            }
            return ret;
        }



        public bool validateParameters(ValidateableStreetAddress address, bool shouldThrowException)
        {
            bool ret = true;

            ret = ret && address.HasValidZIP;


            // // check that the city state are washington, dc if they are present
            if (address.HasCity)
            {
                bool isWashington = StringUtils.AreEqualIgnoreCase(address.City, "washington");
                if (!isWashington)
                {
                    ret = false;
                    if (shouldThrowException)
                    {
                        throw new AddressException(getName() + ": " + "only presently contains data for Washington, DC");
                    }
                }
            }

            if (address.HasState)
            {
                bool isDC = StringUtils.AreEqualIgnoreCase(address.State, "dc");
                if (!isDC)
                {
                    ret = false;
                    if (shouldThrowException)
                    {
                        throw new AddressException(getName() + ": " + "only presently contains data for Washington, DC");
                    }
                }
            }

            if (!address.HasValidZIP)
            {
                ret = false;
                if (shouldThrowException)
                {
                    throw new RequiredParameterException(getName() + ": " + "Corrrectly formatted Zipcode is required");
                }
            }

            return ret;
        }



    }
}
