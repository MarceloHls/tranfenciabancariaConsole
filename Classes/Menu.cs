using System;

namespace Dio.Bank
{
    public static class Menu
    {
        public static string obterOpcao()
        {

            Console.WriteLine();
            Console.WriteLine("Dio Bank a seu dispor");
            Console.WriteLine("Informe a opcao desejada");

            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Tranferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("6- Extrato");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            return Console.ReadLine().ToUpper();

        }


    }

}