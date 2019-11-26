using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ExemploServico2
{
    [ServiceContract]
    public interface IServico
    {
        [OperationContract]
        string Mensagem();
    }

    public class Servico : IServico
    {
        public string Mensagem()
        {
            return "Isso é um serviço wcf";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Define o endereço
            var url = new Uri("http://localhost:8989/Servico");
                                    //Cria um Host
            var host = new ServiceHost(typeof(Servico), url);

            //Adiciona um Behavior permitindo HttpGet
            var smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            //Inicia o serviço
            host.Open();
            Console.WriteLine("O serviço está no ar, no endereço:{0}",url);
            Console.WriteLine("Tecle ENTER para sair.");
            Console.ReadLine();
            // Fecha o serviço
            host.Close();
        }
    }
}
