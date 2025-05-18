using System.ServiceModel;

namespace ConvertServices
{
    [ServiceContract(Namespace = "ConvertServices")]
    public interface ICurrencyConverter
    {
        [OperationContract]
        double ToUsd(double uah);
    }
}
