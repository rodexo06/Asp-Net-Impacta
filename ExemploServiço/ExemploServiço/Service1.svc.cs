using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExemploServiço
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IService1
    {
        public DateTime DataHoraServidor()
        {
            return DateTime.Now;
        }

        public string Mensagem()
            {
                return "isto é uma mensagem do servidor...";
            }

        public Produto OfertaDoDia()
        {
            var produto = new Produto()
            {
                Nome = "Caneta",
                ID = 12,
                Preco = 1
            };
            return produto;
        }

        public int Somar(int a, int b)
        {
            return a + b;
        }
    }
}
