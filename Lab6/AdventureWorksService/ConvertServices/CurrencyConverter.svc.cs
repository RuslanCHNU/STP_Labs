using System.ServiceModel.Activation;

namespace ConvertServices
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CurrencyConverter : ICurrencyConverter
    {
        // Для прикладу візьмемо фіксований курс:
        private const double UahToUsdRate = 0.024;

        public double ToUsd(double uah)
        {
            return uah * UahToUsdRate;
        }
    }
}
