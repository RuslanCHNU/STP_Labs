using System.ServiceModel.Activation;

namespace ConvertServices
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class WeightConverter : IWeightConverter
    {
        public double ToKilograms(double lbs)
            => lbs * 0.45359237;

        public double ToPounds(double kg)
            => kg / 0.45359237;
    }
}
