using System;
using System.Collections.Generic;

namespace Dio.Bank
{
    public class Conta
    {
        private TipodeConta tipodeConta { get; set; }

        private decimal saldo { get; set; }
        private decimal credito { get; set; }
        private string nome { get; set; }

        private List<string> transacoes = new List<string>();

        public Conta(TipodeConta tipodeConta, decimal credito, decimal saldo, string nome)
        {
            this.tipodeConta = tipodeConta;
            this.credito = credito;
            this.saldo = saldo;
            this.nome = nome;
            transacoes.Add($" + {saldo}");
        }

        public bool sacar(decimal valor)
        {
            if (saldo - valor < (credito * -1))
            {
                Console.WriteLine("\nSaldo Insuficente\n");
                return false;
            }

            saldo -= valor;
            transacoes.Add($" - {valor}");
            Console.WriteLine($"\nConta de: {nome} \nSaldo Atual: {saldo.ToString("N2")} \n");
            return true;

        }

        public void depositar(decimal valor)
        {
            saldo += valor;
            transacoes.Add($" + {valor}");
            Console.WriteLine($"\nConta de: {nome} \nSaldo Atual: {saldo.ToString("N2")} \n");
        }

        public void tranferir(decimal valor, Conta contaTranferir)
        {
            if (this.sacar(valor))
            {
                contaTranferir.depositar(valor);

            }
        }

        public void extrato()
        {
            Console.Clear();

            Console.WriteLine($"Extrato - Conta {nome}");
            Console.WriteLine();
            foreach (string transacao in transacoes)
            {
                Console.WriteLine(transacao);
            }
            Console.ReadKey();
            Console.Clear();

        }
        public string getNome()
        {
            return this.nome;
        }



        public override string ToString()
        {
            string retorno;
            retorno = $"------------------------------------\n";
            retorno += $"Tipo da conta: {this.tipodeConta}\n";
            retorno += $"Nome da conta: {this.nome}\n";
            retorno += $"Saldo atual..: {this.saldo.ToString("N2")}\n";
            retorno += $"Credito......: {this.credito.ToString("N2")}\n";
            retorno += $"------------------------------------";

            return retorno;
        }


    }
}