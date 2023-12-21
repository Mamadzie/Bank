using Bank;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Schyot_banka;

class program
{

    static void Main(string[] args)
    {
        int account;
        Console.WriteLine("Введите количество аккаунтов(1 или 2): ");
        bool Isvalidnumber = int.TryParse(Console.ReadLine(), out account);

        while (account > 2)
        {
            Console.WriteLine("Ошибка! Введите заново: ");
            Isvalidnumber = int.TryParse(Console.ReadLine(), out account);
        }

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
        foreach (Bank_Account a in akk)
        {
            a.INFO();
            Console.WriteLine("\n");
        }

        if (account == 1)
        {
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1.Добавить сумму.");
            Console.WriteLine("2.Вычесть сумму.");
            int vibor = int.Parse(Console.ReadLine());

            switch (vibor)
            {
                case 1:
                    Console.Write("Введите сумму которое хотите добавить: ");
                    int summa_dob = int.Parse(Console.ReadLine());
                    akk[0].DOB(summa_dob);
                    break;
                case 2:
                    Console.Write("Введите сумму которое хотите вычесть: ");
                    int summa_vichest = int.Parse(Console.ReadLine());
                    akk[0].UMEN(summa_vichest);
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }

            Console.Clear();
            foreach (Bank_Account a in akk)
            {
                a.INFO();
                Console.WriteLine("\n");
            }
        }

        if (account == 2)
        {
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1.Добавить сумму.");
            Console.WriteLine("2.Вычесть сумму.");
            int vibor2 = int.Parse(Console.ReadLine());

            switch (vibor2)
            {
                case 1:
                    Console.Write("Введите сумму которое хотите добавить у 1ого аккаунта: ");
                    int summa_dob1 = int.Parse(Console.ReadLine());
                    akk[0].DOB(summa_dob1);
                    Console.Write("Введите сумму которое хотите добавить у второго аккаунта: ");
                    int summa_dob2 = int.Parse(Console.ReadLine());
                    akk[1].DOB(summa_dob2);
                    break;
                case 2:
                    Console.WriteLine("Введите сумму которое хотите вычесть у 1ого аккаунта: ");
                    int summa_vich1 = int.Parse(Console.ReadLine());
                    akk[0].UMEN(summa_vich1);
                    Console.WriteLine("Введите сумму которое хотите вычесть у 2ого аккаунта: ");
                    int summa_vichest2 = int.Parse(Console.ReadLine());
                    akk[1].UMEN(summa_vichest2);
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }
            Console.Clear();
            foreach (Bank_Account a in akk)
            {
                a.INFO();
                Console.WriteLine("\n");
            }

            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1.с 1ого на 2рой.");
            Console.WriteLine("2.c 2ого на 1ий.");
            int vibor3 = int.Parse(Console.ReadLine());

            switch (vibor3)
            {
                case 1:
                    Console.WriteLine("Введите сумму для перевода: ");
                    int perevod = int.Parse(Console.ReadLine());
                    akk[0].PEREVOD_CHYOTA(akk[1], perevod);
                    Console.Clear();
                    Console.WriteLine("Обновлённая инфа.");
                    foreach (Bank_Account a in akk)
                    {
                        a.INFO();
                        Console.WriteLine("\n");
                    }
                    break;

                case 2:
                    Console.WriteLine("Введите сумму для перевода: ");
                    int perevod2 = int.Parse(Console.ReadLine());
                    akk[1].PEREVOD_CHYOTA(akk[0], perevod2);
                    Console.Clear();
                    Console.WriteLine("Обновлённая инфа.");
                    foreach (Bank_Account a in akk)
                    {
                        a.INFO();
                        Console.WriteLine("\n");
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }
        }
    }
}