using Bank;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Schyot_banka;

class program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество аккаунтов: ");
        int account = int.Parse(Console.ReadLine());

        Bank_Account[] akk = new Bank_Account[account];

        for (int a = 0; a < account; a++)
        {
            Console.Write("Введите номер: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите начальную сумму: ");
            double balance = double.Parse(Console.ReadLine());

            akk[a] = new Bank_Account();
            akk[a].otk(number, name, balance);
        }
        Console.Clear();

        int i = 1;
        foreach (Bank_Account a in akk)
        {
            Console.WriteLine(i++);
            a.INFO();
            Console.WriteLine("\n");
        }

        while (true)
        {
            int schet = 0;

            if (account > 1)
            {
                Console.Write("Выберите аккаунт над которым хотите произвести действие: ");
                schet = int.Parse(Console.ReadLine()) - 1;
            }

            Console.Clear();

            akk[schet].INFO();
            Console.WriteLine("\n");

            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1.Добавить сумму.");
            Console.WriteLine("2.Вычесть сумму.");
            Console.WriteLine("3.Перевод денег на другой счёт.");
            int vibor = int.Parse(Console.ReadLine());

            switch (vibor)
            {
                case 1:
                    Console.Write("Введите сумму которое хотите добавить: ");
                    int summa_dob = int.Parse(Console.ReadLine());
                    akk[schet].DOB(summa_dob);
                    break;
                case 2:
                    Console.Write("Введите сумму которое хотите вычесть: ");
                    int summa_vichest = int.Parse(Console.ReadLine());
                    akk[schet].UMEN(summa_vichest);
                    break;
                case 3:
                    Console.Clear();
                    i = 1;
                    foreach (Bank_Account a in akk)
                    {
                        Console.WriteLine(i++);
                        a.INFO();
                        Console.WriteLine("\n");
                    }

                    Console.WriteLine("Введите номер счёт для перевода: ");
                    int perevod_schet = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Введите сумму: ");
                    double summa = double.Parse(Console.ReadLine());

                    akk[schet].PEREVOD_CHYOTA(akk[perevod_schet], summa);
                    
                    break;
                    
                default:
                    Console.WriteLine("Ошибка!");
                    Console.ReadLine();
                    break;
            }

            Console.Clear();
            i = 1;
            foreach (Bank_Account a in akk)
            {
                Console.WriteLine(i++);
                a.INFO();
                Console.WriteLine("\n");
            }
        }
    }
}