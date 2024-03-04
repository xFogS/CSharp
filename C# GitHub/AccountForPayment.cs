using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace payment
{
    [Serializable]
    public class AccountForPayment : ISerializable
    {
        static public bool FullSerialization = false;
        /* set, get + */
        public int PaymentForDay { get; set; } = 0;
        public int CountDays { get; set; } = 0;
        public int SanctionForDay { get; set; } = 0;
        public int SanctionDelaysDays { get; set; } = 0;
        /* only get */
        public int SumWithoutSanction { get { return PaymentForDay * CountDays; } set { } }
        public int SumSanction { get { return SanctionForDay * SanctionDelaysDays; } set { } }
        public int SumAllSanction { get { return PaymentForDay * CountDays; } set { } }

        /* ~~~~~~~~ Start complited programs ~~~~~~~~ */
        public AccountForPayment() { }
        private AccountForPayment(SerializationInfo info, StreamingContext context)
        {
            PaymentForDay = info.GetInt32("Payment");
            CountDays = info.GetInt32("CountDays");
            SanctionForDay = info.GetInt32("SanctionForDay");
            SanctionDelaysDays = info.GetInt32("SanctionDelaysDays");
            if (FullSerialization == true)
            {
                SumWithoutSanction = info.GetInt32("SumWithoutSanction");
                SumSanction = info.GetInt32("SumSanction");
                SumAllSanction = info.GetInt32("SumAllSanction");
            }
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Payment", PaymentForDay);
            info.AddValue("CountDays", CountDays);
            info.AddValue("SanctionForDay", SanctionForDay);
            info.AddValue("SanctionDelaysDays", SanctionDelaysDays);
            if (FullSerialization == true)
            {
                info.AddValue("SumWithoutSanction", SumWithoutSanction);
                info.AddValue("SumSanction", SumSanction);
                info.AddValue("SumAllSanction", SumAllSanction);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            AccountForPayment.FullSerialization = true;
            List<AccountForPayment> accpay = new List<AccountForPayment>()
            {
                new AccountForPayment
                {
                    PaymentForDay = 120,
                    CountDays = 3,
                    SanctionForDay = 50,
                    SanctionDelaysDays = 66,
                },
                new AccountForPayment
                {
                    PaymentForDay = 100,
                    CountDays = 1,
                    SanctionForDay = 44,
                    SanctionDelaysDays = 54
                },
                new AccountForPayment
                {
                    PaymentForDay = 230,
                    CountDays = 6,
                    SanctionForDay = 100,
                    SanctionDelaysDays = 130
                },
            };
            try
            {
                BinaryFormatter xml = new BinaryFormatter();         
                using (Stream stream = File.Create("AccountForPayment_0.xml"))
                {
                    foreach (AccountForPayment item in accpay)
                    {
                        xml.Serialize(stream, item);
                    }
                }
                List<AccountForPayment> objTemp = new();
                using (Stream stream = File.OpenRead("AccountForPayment_0.xml"))
                {
                    while (stream.Position != stream.Length)
                    {
                        AccountForPayment a = (AccountForPayment)xml.Deserialize(stream);
                        objTemp.Add(a);
                    }
                    objTemp.ForEach(x => Console.WriteLine($"{x.PaymentForDay} | {x.CountDays} | {x.SanctionForDay} | {x.SanctionDelaysDays}\n" +
                                 $"{x.SumWithoutSanction} | {x.SumSanction} | {x.SumAllSanction}\n"));
                }
            }
            catch (Exception? error) { Console.WriteLine($"{error.Message}"); }

            //for me
            /*foreach (MethodInfo i in typeof(AccountForPayment).GetMethods())
            {
                foreach (Attribute item in typeof(List<AccountForPayment>).GetCustomAttributes())
                {
                    Console.WriteLine(i.Name);
                    Console.WriteLine(item.TypeId);
                }
            }*/
        }
    }
}