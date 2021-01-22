using System;
using System.Collections.Generic;
using System.Linq;

namespace Dio.Bank
{
    public class DataContas
    {
        public List<Conta> contas = new List<Conta>();
        public void extrato()
        {

            Console.Write("Digite o nome da conta...........................: ");
            string nome = Console.ReadLine();

            try
            {
                Conta conta = contas.First(x => x.getNome().Equals(nome));
                conta.extrato();
            }
            catch
            {

            }

        }
        public void depositar()
        {
            Console.Write("Digite o nome da conta...........................: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor a ser depositado..................: ");
            decimal valor = int.Parse(Console.ReadLine());

            try
            {
                Conta conta = contas.First(x => x.getNome().Equals(nome));
                conta.depositar(valor);
            }
            catch
            {

            }


        }
        public void listarContas()
        {
            Console.Clear();
            contas.ForEach(x =>
            {
                Console.WriteLine(x);
            });
            Console.ReadKey();
            Console.Clear();
        }
        public void inseriConta()
        {
            Console.Clear();

            Console.WriteLine("Inserir nova conta");

            try
            {

                Console.Write("Digite o tipo de conta [1- Fisica /2 - Juridica] : ");
                TipodeConta tipodeConta = (TipodeConta)int.Parse(Console.ReadLine());

                Console.Write("Digite o nome da conta...........................: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o saldo inicial...........................: ");
                decimal saldo = int.Parse(Console.ReadLine());

                Console.Write("Digite o credito.................................: ");
                decimal credito = int.Parse(Console.ReadLine());

                contas.Add(new Conta(tipodeConta, credito, saldo, nome));
                Console.Clear();

            }
            catch
            {

            }

        }
        public void tranferir()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Tranferir");

                Console.Write("Digite o nome da conta a ser debitada.................: ");
                string inputDeb = Console.ReadLine();

                Console.Write("Digite o valor a ser transferido.....................: ");
                decimal valor = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome da conta a ser creditada................: ");
                string inputCred = Console.ReadLine();
                try
                {

                    Conta contaDeb = contas.First(x => x.getNome().Equals(inputDeb));
                    Conta contaCred = contas.First(x => x.getNome().Equals(inputCred));
                    contaDeb.tranferir(valor, contaCred);
                }
                catch
                {

                }
            }
            catch
            {

            }

        }
        public void sacar()
        {
            Console.Write("Digite o nome da conta...........................: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor a ser sacado..................: ");
            decimal valor = int.Parse(Console.ReadLine());

            try
            {
                Conta conta = contas.First(x => x.getNome().Equals(nome));
                conta.sacar(valor);
            }
            catch
            {

            }
        }

    }
}