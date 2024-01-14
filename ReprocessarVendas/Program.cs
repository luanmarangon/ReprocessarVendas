using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. As vendas serão Reprocessadas a partir do diretório \"C:\\SUPER\\TEMP\".");
        Console.WriteLine("2. Copie o endereço do mapeamento para facilitar a inserção no caminho solicitado posteriormente.");
        Console.WriteLine("3. Tenha extrema cautela ao realizar este processo para evitar possíveis problemas nas transações de vendas.");
        Console.WriteLine("4. O período de reprocessamento deve seguir uma ordem cronológica, o periodo precisa estar dentro do mesmo ano. Por exemplo, se o intervalo desejado é de 20/12 a 15/01, informe primeiro de 20/12 a 31/12 e, em seguida, de 01/01 a 15/01.");
        Console.WriteLine("*");
        Console.WriteLine("*");
        Console.WriteLine("*");
        Console.WriteLine("*");

        Console.Write("Deseja continuar com o processo? S/N : ");
        string continuar = Console.ReadLine().Trim().ToUpper();

        // inclui uma condição para caso queira sair antes de iniciar
        if (continuar == "N")
        {
            Console.WriteLine("Processo encerrado pelo usuário.");
            return;
        }

        Console.Write("Informe o Caminho do MAPEAMENTO do Servidor para Reprocessar as vendas: ");
        string mapeamento = Console.ReadLine();

        // Condição para validar o caminho que está o mapeamento do Servidor.
        if (!Directory.Exists(mapeamento))
        {
            Console.WriteLine("Erro: Caminho não encontrado. Confirme o Caminho.");
            return;
        }
        else
        {
            Console.WriteLine("Caminho Encontrado.");
        }

        Console.WriteLine("Informe data Inicial {dd/MM/yyyy}!");
        string dataInicialStr = Console.ReadLine();

        Console.WriteLine("Informe data Final {dd/MM/yyyy}!");
        string dataFinalStr = Console.ReadLine();

        // Convertendo strings para objetos DateTime COMPLICADO...
        if (DateTime.TryParseExact(dataInicialStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataInicial)
            && DateTime.TryParseExact(dataFinalStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataFinal))
        {
            int diaInicial, mesInicial, diaFinal, mesFinal;

            if (dataFinal < dataInicial)
            {
                diaInicial = dataFinal.Day;
                mesInicial = dataFinal.Month;
                diaFinal = dataInicial.Day;
                mesFinal = dataInicial.Month;
            }
            else
            {
                diaInicial = dataInicial.Day;
                mesInicial = dataInicial.Month;
                diaFinal = dataFinal.Day;
                mesFinal = dataFinal.Month;
            }
            int i = 0;
            for (int mes = mesInicial; mes <= mesFinal; mes++)
            {
                int diaLimite = (mes == mesFinal) ? diaFinal : 31;

                for (int dia = diaInicial; dia <= diaLimite; dia++)
                {
                    string mesDia = $"{mes:D2}";
                    string diaDia = $"{dia:D2}";

                    string sourcePath = Path.Combine("C:\\SUPER\\TEMP", mesDia, diaDia);

                    Console.WriteLine(sourcePath);


                    if (Directory.Exists(sourcePath))
                    {
                        string[] files = Directory.GetFiles(sourcePath);
                        foreach (string file in files)
                        {
                            string destinationPath = Path.Combine(mapeamento, Path.GetFileName(file));
                            File.Copy(file, destinationPath, true);
                            i++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Caminho não encontrado {sourcePath}\\");
                    }
                }
            }

            Console.WriteLine($"Processo concluído. Verifique em '{mapeamento}' as vendas sendo Reprocessadas. Foram Reprocessados {i} Arquivos de vendas!");
            Console.ReadLine();
        }
    }
}
