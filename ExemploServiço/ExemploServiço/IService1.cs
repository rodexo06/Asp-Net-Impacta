using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExemploServiço
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Mensagem();

        [OperationContract]
        int Somar(int a, int b);

        [OperationContract]
        DateTime DataHoraServidor();

        [OperationContract]
        Produto OfertaDoDia();
    }
}
