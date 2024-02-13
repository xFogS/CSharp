using bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bank
{
    public class CreditCard
    {
        private string NumberCard { get; }
        private string NamePerson { get; set; }
        private string PINCode { get; set; } //error about set.lenght(4 - default PinCode) ?: - going 
        private int CreditLimit { get; set; } = 0;
        private int Balance { get; set; } = 0;

        public CreditCard(string number, string person, string pin, int limit)
        {
            NumberCard = number; NamePerson = person;
            _ = pin.Length == 4 ? PINCode = pin : PINCode = "1111";
            CreditLimit = limit;
        }
        public void AddSummOnBalance(int summ)
        {
            Balance += summ;
            string msg = $"{DateTime.Now} ~ Summ [{summ}] / new Balance [{Balance}]";
            MainPushMessage?.Invoke($"{msg}");
        }
        public void UsingSummOnBalance(int summ)
        {
            if (Balance >= summ)
            {
                Balance -= summ;
                string msg = $"You take money. Now your Balance: [{Balance}]";
                MainPushMessage?.Invoke(msg);
            }
            else if (CreditLimit >= summ && CreditLimit >= Balance)
            {
                Balance += summ;/*Беремо кошти зарахунок Кредитного Ліміту*/ CreditLimit -= summ;
                string msg = $"You starts using credit money. Credit Limite: [{CreditLimit}]";
                StartUsingCreditMoney?.Invoke(msg);
            }
            else if (summ > Balance && summ > CreditLimit)
            {
                int tempBalance = Balance + CreditLimit;
                if (tempBalance >= summ)
                {
                    tempBalance -= summ;
                    Balance = 0; CreditLimit = 0;
                    MainPushMessage?.Invoke($"You take money. Now your Balance: [{Balance}]");
                }
                else MainPushMessage?.Invoke("You cannot withdraw your money.You don't have them!");
            }
        }
        public void NewChangePINCode(string pin)
        {
            if (pin.Length <= 4)
            {
                PINCode = pin;
                string msg = $"\tYour set new PinCode: [{PINCode}]\n\tPlease don't say nobody";
                MainPushMessage?.Invoke(msg);
            }
        }
        public void NewCreditLimit(int limit = 1500)
        {
            if (CreditLimit == 0 && limit >= 1500)
            {
                CreditLimit += limit;
                Console.WriteLine($"New Credit Limite: {CreditLimit}");
            }
            else Console.WriteLine("Private Person has Credit. It should be closed");
        }
        public void ClientInfo()
        {
            Console.WriteLine($"Number: {NumberCard}\nPerson: {NamePerson}\nPIN: {PINCode}\nLimit: {CreditLimit}\nBalance: {Balance}");
        }

        public event Action<string> MainPushMessage;
        public event Action<string> PushOnEmail;
        public event Action<string> StartUsingCreditMoney;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        CreditCard card = new CreditCard("9342 5325 2394 3249", "FDS SDF ASD", "43823", 1500);
        card.MainPushMessage += Card_PushOnPhone;
        card.MainPushMessage += Card_PushOnEmail;
        card.StartUsingCreditMoney += Card_StartUsingCreditMoney;

        card.ClientInfo();
        card.AddSummOnBalance(200);
        card.AddSummOnBalance(30);
        card.UsingSummOnBalance(500);
        card.AddSummOnBalance(500);
        card.UsingSummOnBalance(200);
        card.NewChangePINCode("9321");
        card.UsingSummOnBalance(2030);
        card.UsingSummOnBalance(1000);
        card.ClientInfo();
    }


    private static void Card_PushOnPhone(string obj) => Console.WriteLine($"Phone: {obj}");
    private static void Card_PushOnEmail(string obj) => Console.WriteLine($"Email: {obj}");
    private static void Card_StartUsingCreditMoney(string obj) => Console.WriteLine(obj);
}
