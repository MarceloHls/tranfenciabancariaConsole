using System;
using System.Collections.Generic;
namespace Dio.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContas contas = new DataContas();
            string opcao = "";

            while (opcao != "X")
            {
                opcao = Menu.obterOpcao();
                switch (opcao)
                {
                    case "1":
                        contas.listarContas();
                        break;
                    case "2":
                        contas.inseriConta();
                        break;
                    case "3":
                        contas.tranferir();
                        break;
                    case "4":
                        contas.sacar();
                        break;
                    case "5":
                        contas.depositar();
                        break;
                    case "6":
                        contas.extrato();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        break;
                    default:
                        throw new Exception();
                }
            }
        }
    }
}
