using System.ServiceModel;

namespace ConvertServices
{
    [ServiceContract(Namespace = "ConvertServices")]
    public interface IWeightConverter
    {
        [OperationContract]
        double ToKilograms(double lbs);

        [OperationContract]
        double ToPounds(double kg);
    }
}
