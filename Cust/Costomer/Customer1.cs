
namespace Customer
{
    class Customer
    {
        public string Name { get; set; }
        public double Balance { get; private set; }
        public int NTarif { get; private set; }

        public Customer(string name, double balance = 100, int tarif = 1)
        {
            Name = name;
            Balance = balance;
            NTarif = tarif;
        }

        public override string ToString()
        {
            return string.Format("Клиент: {0} имеет баланс: {1}",Name, Balance);
        }

        public void RecordPayment(double amountPaid)
        {
            if (amountPaid > 0)
                Balance += amountPaid;
        }

        public void RecordCall(char callType, int minutes)
        {
            Tarif call = new Tarif();
            switch (NTarif)
            {              
                case 2:
                    Balance -= call.Tarif2(callType, minutes); break;
                case 3:
                    Balance -= call.Tarif3(callType, minutes); break;
                default:                
                    Balance -= call.Tarif1(callType, minutes); break;
            }            
        }
    }
    class Tarif
    {
        private double СallCost;

        public double Tarif1 (char callType, int minutes)
        {            
            if (callType == 'Г')
            {
                СallCost += minutes * 5;
            }               
            else if (callType == 'М')
            {                
                СallCost += minutes * 1;
            }                
            return СallCost;
        }

        public double Tarif2 (char callType, int minutes)
        {
            if (callType == 'Г')
            {
                for (int i = 0; i < minutes; i++)
                {
                    if (i < 10 || i%2==0) { continue; }
                    else
                    {
                        СallCost += 5;
                    }
                }
            }
            else if (callType == 'М')
            {
                СallCost += minutes * 1;
            }            
            return СallCost;
        }

        public double Tarif3(char callType, int minutes)
        {
            if (callType == 'Г')
            {
                for(int i = 0; i < minutes;i++)
                {
                    if (i < 5) 
                    {
                        СallCost += (5/2);
                    }
                    else
                    {
                        СallCost += (5*2);
                    }
                }               
            }
            else if (callType == 'М')
            {
                for (int i = 0; i < minutes; i++)
                {
                    if (i < 5)
                    {
                        СallCost += (1 / 2);
                    }
                    else
                    {
                        СallCost += (1 * 2);
                    }
                }
            }
            return СallCost;
        }
    }

    class Customer1
    {
        static void Main(string[] args)
        {
            Customer Ivan = new Customer("Иван Петров", 500, 2);
            Customer Elena = new Customer("Елена Иванова");
            Ivan.RecordCall('Г', 12);
            Elena.RecordCall('М', 25);
                     

            Console.WriteLine(Ivan);
            Console.WriteLine(Elena);

        }
    }
}
