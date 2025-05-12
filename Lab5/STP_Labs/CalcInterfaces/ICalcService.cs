using System;
using System.ServiceModel;

namespace CalcInterfaces
{
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract]
        int Sum(int firstNumber, int secondNumber);

        [OperationContract]
        string GetZodiacSign(DateTime birthDate);
    }
}