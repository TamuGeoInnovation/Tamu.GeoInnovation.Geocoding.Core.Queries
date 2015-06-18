using USC.GISResearchLab.Common.Addresses;

namespace USC.GISResearchLab.Geocoding.Core.Queries.ParameterValidators.DataSources.Interfaces
{

    public interface SourceValidator
	{
		// info about the source capabilities
		string getName();
		int[] getAllSupportedMethods();

		// methods to validate input
		bool validateParameters(ValidateableStreetAddress address, bool shouldThrowException);
		bool validateMethodForAddress(int method, ValidateableStreetAddress address, bool shouldThrowException);

	}
}
