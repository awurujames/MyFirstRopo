namespace AccountTest3
{
    public class Account
    {
        private string name;
        private decimal balance;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0.0M)
                {
                    balance = 0;
                }
                else
                {
                    balance = value;
                }
            }
        }
    }
}