using ExercicioServico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExercicioServico
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IAdvWorksWcf" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IAdvWorksWcf
    {
        [OperationContract]
        List<string> ClientePaisLista();
        [OperationContract]
        List<string> ClienteEstadoLista(string pais);
        [OperationContract]
        List<ClienteAvulso> ClientesAvulsosPorPaisEstado(string pais, string estado);
    }
}
