using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank_Account
    {
        private int shyot_number;
        private string name;
        private double summa_check;

        public void otk(int shyot_number, string name, double summa_check)
        {
            this.shyot_number = shyot_number;
            this.name = name;
            this.summa_check = summa_check;
        }

        private void info()
        {
            Console.WriteLine("Номер счёта: " + this.shyot_number + "\nФ.И.О. владельца счёта: " + this.name + "\nСумма на счету: " + this.summa_check);
        }

        public void INFO()
        {
            info();
        }

        private void dob(double amount)
        {
            this.summa_check += amount;
        }

        public void DOB(double amount)
        {
            dob(amount);
        }

        private void umen(double amount)
        {
            if (amount <= summa_check)
            {
                summa_check -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств.");
            }
        }

        public void UMEN(double amount)
        {
            umen(amount);
        }

        private void obnul()
        {
            summa_check = 0;
        }

        public void OBNUL()
        {
            obnul();
        }

        private void Perevod_chyota(Bank_Account Naznachenie_Account, double amount)
        {
            if (Naznachenie_Account.shyot_number != shyot_number)
            {
                if (amount <= summa_check)
                {
                    summa_check -= amount;
                    Naznachenie_Account.summa_check += amount;
                }
                else
                {
                    Console.WriteLine("Недостаточно средств.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Нельзя перевести средства себе");
                Console.ReadKey();
            }

        }

        public void PEREVOD_CHYOTA(Bank_Account Naznachenie_Account, double amount)
        {
            Perevod_chyota(Naznachenie_Account, amount);
        }
    }
}
