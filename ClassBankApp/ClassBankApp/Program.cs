using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using System.Text;
using System.Threading.Tasks;
namespace ClassBankApp
{
    class Asiakas
    {
        public string etunimi;
        public string sukunimi;
        public string Name()
        {
            return etunimi + " " + sukunimi;
        }
        public string WholeName
        {
            get { return etunimi + " " + sukunimi; }
        }
        public void GetPersonInfo(out string etu, out string suku)
        {
            etu = this.etunimi;
            suku = this.sukunimi;
        }
        public void mymethod()
        {
            string vastaus = this.Name();
            string vastaustoo = this.WholeName;
            string etuA, sukuA;
            this.GetPersonInfo(out etuA, out sukuA);
        }
        public string name { get; set; } = "unknown";
        public int customerNumber { get; }
        public List<int> accountList = new List<int>();
        Asiakas() { }
        public Asiakas(string nimi)
        {
            name = nimi;
            customerNumber = BankDefaults.createCustomerNumber();
        }
        public void ResetCustomer()
        {
            name = "unknown";
            accountList.Clear();
        }
    }
    class PankkiTili
    {
        public int accountNumber = default;
        public int customerNumber = default;
        protected double saldo = default;
        public double currentsaldo
        {
            get { return saldo; }
        }
        public PankkiTili()
        {
            accountNumber = BankDefaults.createAccountNumber();
        }
        public PankkiTili(double initialSaldo)
        {
            accountNumber = BankDefaults.createAccountNumber();
            saldo = initialSaldo;
        }
        public virtual void ShowAccountInfo()
        {
            Console.WriteLine(accountNumber + " " +
                customerNumber + " " +
                "Saldo is " + saldo + " "
                );
        }
        public virtual void ChangeSaldo(double nosto)
        {
            if ((saldo + nosto) < 0)
            {
                Console.WriteLine("Bank Account cannot be negative");
                return;
            }
            saldo += nosto;
            Console.WriteLine($"new saldo is {saldo}");
        }
    }
    class LuottoTili : PankkiTili
    {
        double creditLimit = default;
        LuottoTili() { }
        public LuottoTili(double saldo, double creditLimit)
        {
            this.saldo = saldo;
            this.creditLimit = creditLimit;
        }
        public override void ShowAccountInfo()
        {
            Console.WriteLine(accountNumber + " " +
                customerNumber + " " +
                "Saldo is " + saldo + " " +
                "Credit Limit is " + creditLimit
                );
        }
        public override void ChangeSaldo(double nosto)
        {
            if ((saldo + nosto) < -creditLimit)
            {
                Console.WriteLine("You cannot go over creditlimit!");
                return;
            }
            saldo += nosto;
            Console.WriteLine($"new saldo is {saldo}");
        }
    }
    class YhteisöTili : PankkiTili
    {
        public List<int> customerList = new List<int>();
        public YhteisöTili(double newsaldo, List<int> newcustomers)
        {
            saldo = newsaldo;
            if (newcustomers.Count > 0)
            {
                customerNumber = newcustomers[0];
                foreach (int iter in newcustomers)
                {
                    customerList.Add(iter);
                }
            }
        }
        public override void ShowAccountInfo()
        {
            Console.Write(accountNumber + " " +
                customerNumber + " " +
               "Saldo is " + saldo + " " +
                "Customers are ");
            foreach (int iter in customerList)
            {
                Console.Write(iter + "  ");
            }
            Console.WriteLine("");
        }
        public void ResetAccount()
        {
            // remove all customers from account
            customerNumber = default;
            customerList.Clear();
        }
    }
    public static class BankDefaults
    {
        public const int maxCredit = 500;
        static int customerNumber = 0;
        static int accountNumber = 0;
        public static int createCustomerNumber()
        {
            return ++customerNumber;
        }
        public static int createAccountNumber()
        {
            return ++accountNumber;
        }
    }
    class Program
    {
        static List<Asiakas> customerList;
        static List<PankkiTili> accountList;
        static void Main(string[] args)
        {
            customerList = new List<Asiakas>();
            accountList = new List<PankkiTili>();
            // App title
            Console.WriteLine("BANK");
            Console.WriteLine("====");
            bool leaveBank = default;
            do
            {
                switch (GUIMainDisplay())
                {
                    case 0:
                        leaveBank = true;
                        Console.WriteLine("Leaving Bank...");
                        break;
                    case 1:
                        GUICreateCustomer();
                        break;
                    case 2:
                        GUICreateBankAccount();
                        break;
                    case 3:
                        GUICreateCreditAccount();
                        break;
                    case 4:
                        GUIJoinCustomerAccount();
                        break;
                    case 5:
                        GUIResetCustomer();
                        break;
                    case 6:
                        GUIShowCustomer();
                        break;
                    case 7:
                        GUIShowAccount();
                        break;
                    case 8:
                        GUIDeleteCustomer();
                        break;
                    case 9:
                        GUIDeleteAccount();
                        break;
                    case 10:
                        GUIChangeSaldo();
                        break;
                    case 11:
                        GUICreateCommunityAccount();
                        break;
                    case 12:
                        GUIJoinCustomerCommunityAccount();
                        break;
                    default:
                        break;
                }
            } while (!leaveBank);
            // end program
            Console.ReadLine();
        }
        private static int GUIMainDisplay()
        {
            bool validResponse = false;
            int response;
            do
            {
                Console.WriteLine(@"
                           Select Activity (0 to 10)
                           0) Lopetus
                           1) Uusi Asiakas
                           2) Uusi Pankkitili
                           3) Uusi Luottotili
                           4) Liitä tili asiakkaalle
                           5) Resetoi asiakkaan tiedot
                           6) Näytä asiakkaat
                           7) Näytä tilit
                           8) Poista asiakas
                           9) Poista tili
                           10) Tee tilitapahtumia (nosto ja talletus)
                           11) Uusi Yhteisötili
                           12) Liitä asiakas Yhteisötiliin
                        ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = int.TryParse(guessInput, out response);
            } while (!validResponse);
            return response;
        }
        private static void GUICreateCustomer()
        {
            Console.WriteLine(@"
                           Customer Name?
            ");
            string guessInput = Console.ReadLine();
            if (confirmInput())
            {
                Asiakas newCustomer = new Asiakas(guessInput);
                customerList.Add(newCustomer);
            }
        }
        private static void GUICreateBankAccount()
        {
            bool validResponse = false;
            double response = default;
            do
            {
                Console.WriteLine(@"
                           Initial saldo?
            ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = double.TryParse(guessInput, out response);
            } while (!validResponse);
            if (confirmInput())
            {
                PankkiTili newAccount = new PankkiTili(response);
                accountList.Add(newAccount);
            }
        }
        private static void GUICreateCreditAccount()
        {
            bool validResponse = false;
            double response = default;
            double response2 = default;
            do
            {
                Console.WriteLine(@"
                           Initial saldo?
            ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = double.TryParse(guessInput, out response);
            } while (!validResponse);
            do
            {
                Console.WriteLine(@"
                           Initial creditlimit (0 to inifinity)?
            ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = double.TryParse(guessInput, out response2);
            } while (!validResponse);
            if (confirmInput())
            {
                LuottoTili newAccount = new LuottoTili(saldo: response, creditLimit: response2);
                accountList.Add(newAccount);
            }
        }
        private static void GUIJoinCustomerAccount()
        {
            bool validResponse = false;
            int response = default;
            int response2 = default;
            GUIShowAccount();
            GUIShowCustomer();
            do
            {
                Console.WriteLine(@"
                           Select account number?
            ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = int.TryParse(guessInput, out response);
            } while (!validResponse);
            do
            {
                Console.WriteLine(@"
                           Select customer number?
            ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = int.TryParse(guessInput, out response2);
            } while (!validResponse);
            if (confirmInput())
            {
                foreach (PankkiTili iter in accountList)
                {
                    if (iter.accountNumber == response)
                    {
                        iter.customerNumber = response2;
                        Console.WriteLine($"Account {response} has new owner {response2}...");
                        break;
                    }
                }
                foreach (Asiakas iter in customerList)
                {
                    if (iter.customerNumber == response2)
                    {
                        iter.accountList.Add(response);
                        Console.WriteLine($"Customer {response2} has new account {response}...");
                        break;
                    }
                }
            }
        }
        private static void GUIResetCustomer()
        {
            GUIShowCustomer();
            bool validResponse = false;
            int response;
            do
            {
                Console.WriteLine(@"
                           Select Customernumber to be reset
                        ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = int.TryParse(guessInput, out response);
            } while (!validResponse);
            if (confirmInput())
            {
                foreach (Asiakas iter in customerList)
                {
                    if (iter.customerNumber == response)
                    {
                        iter.name = "unknown";
                    }
                    // go thought
                    foreach (PankkiTili itertoo in accountList)
                    {
                        if (itertoo.customerNumber == response)
                        {
                            itertoo.customerNumber = 0;
                            Console.WriteLine($"Customer {response} accounts removed...");
                        }
                    }
                }
            }
        }
        private static void GUIShowCustomer()
        {
            Console.WriteLine(@"
                           Customer List:
            ");
            PankkiTili dummy;
            foreach (Asiakas iter in customerList)
            {
                Console.Write("  " + iter.customerNumber + " " + iter.name);
                Console.Write(" Tilisi ovat: ");
                foreach (int account in iter.accountList)
                {
                    dummy = accountList.Find(x => x.accountNumber == account);
                    Console.Write(account + ": " + dummy.currentsaldo + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Press Key to continue");
            Console.ReadLine();
        }
        private static void GUIShowAccount()
        {
            Console.WriteLine(@"
                           Account List:
            ");
            foreach (PankkiTili iter in accountList)
            {
                iter.ShowAccountInfo();
            }
            Console.WriteLine("Press Key to continue");
            Console.ReadLine();
        }
        private static void GUIDeleteCustomer()
        {
            GUIShowCustomer();
            bool validResponse = false;
            int response;
            do
            {
                Console.WriteLine(@"
                           Select Customernumber to be deleted
                        ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = int.TryParse(guessInput, out response);
            } while (!validResponse);
            if (confirmInput())
            {
                Asiakas dummy = customerList.
                    Find(x => x.customerNumber == response);
                Console.WriteLine($"Account {response} removed...");
                customerList.Remove(dummy);
            }
        }
        private static void GUIDeleteAccount()
        {
            GUIShowAccount();
            bool validResponse = false;
            int response;
            do
            {
                Console.WriteLine(@"
                           Select Account number to be deleted
                        ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = int.TryParse(guessInput, out response);
            } while (!validResponse);
            if (confirmInput())
            {
                foreach (PankkiTili iter in accountList)
                {
                    if (iter.accountNumber == response)
                    {
                        Console.WriteLine($"Account {response} removed...");
                        accountList.Remove(iter);
                        break;
                    }
                }
            }
        }
        private static void GUIChangeSaldo()
        {
            GUIShowAccount();
            bool validResponse = false;
            int response = default;
            double response2 = default;
            do
            {
                Console.WriteLine(@"
                           Select Account?
            ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = int.TryParse(guessInput, out response);
            } while (!validResponse);
            do
            {
                Console.WriteLine(@"
                           Initial change in saldo (negative for withdrawal)?
            ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = double.TryParse(guessInput, out response2);
            } while (!validResponse);
            if (confirmInput())
            {
                foreach (PankkiTili iter in accountList)
                {
                    if (iter.accountNumber == response)
                    {
                        iter.ChangeSaldo(response2);
                        Console.WriteLine($"Account {response} saldo changed...");
                        break;
                    }
                }
            }
        }
        private static void GUICreateCommunityAccount()
        {
            bool validResponse = false;
            double response = default;
            do
            {
                Console.WriteLine(@"
                           Initial saldo?
            ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = double.TryParse(guessInput, out response);
            } while (!validResponse);
            // Luo lista asiakkaita!
            GUIShowCustomer();
            List<int> dummyList = new List<int>();
            int response2;
            do
            {
                Console.WriteLine(@"
                           Add customer to communityaccount (0 = to stop)?
            ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = int.TryParse(guessInput, out response2);
                if (validResponse && response2 != 0)
                {
                    dummyList.Add(response2);
                    validResponse = false;
                }
            } while (!validResponse);
            if (confirmInput())
            {
                YhteisöTili newAccount = new YhteisöTili(response, dummyList);
                accountList.Add(newAccount);
            }
        }
        private static void GUIJoinCustomerCommunityAccount()
        {
            bool validResponse = false;
            int response = default;
            int response2 = default;
            GUIShowAccount();
            GUIShowCustomer();
            do
            {
                Console.WriteLine(@"
                           Select account number?
            ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = int.TryParse(guessInput, out response);
            } while (!validResponse);
            // Luo lista asiakkaita!
            List<int> dummyList = new List<int>();
            do
            {
                Console.WriteLine(@"
                           Add customer to communityaccount (0 = to stop)?
            ");
                string guessInput = Console.ReadLine();
                // convert string to number
                validResponse = int.TryParse(guessInput, out response2);
                if (validResponse && response2 != 0)
                {
                    dummyList.Add(response2);
                    validResponse = false;
                }
            } while (!validResponse);
            if (confirmInput())
            {
                foreach (PankkiTili iter in accountList)
                {
                    if (iter.accountNumber == response)
                    {
                        iter.customerNumber = response2;
                        if (iter is YhteisöTili)
                        {
                            ((YhteisöTili)iter).customerList.AddRange(dummyList);
                        }
                        Console.WriteLine($"Account {response} has new owner {response2}...");
                        break;
                    }
                }
                foreach (Asiakas iter in customerList)
                {
                    if (iter.customerNumber == response2)
                    {
                        iter.accountList.Add(response);
                        Console.WriteLine($"Customer {response2} has new account {response}...");
                        break;
                    }
                }
            }
        }
        private static bool confirmInput()
        {
            bool response = default;
            Console.WriteLine("Confirm Y/N?");
            string confirmInput = Console.ReadLine();
            if (confirmInput.ToUpper() == "Y")
            {
                return true;
            }
            return response;
        }
    }
}
