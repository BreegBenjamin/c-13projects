namespace C13.lib
{
    public static  class ValiateCurrency
    {
        public static void ExecutePay(Money money) 
        {
            Console.WriteLine($"Valid Pay {money.Curreny}");
        }
    }

    public class User 
    {
        public int id { get; set; }
        public string userName { get; set; }
    }

    public record Money 
    {
        private readonly HashSet<string> _validCorrencies = new();
       public decimal Mount { get; init; }
       public string Curreny { get; init; }

        public Money(decimal mount, string currency) 
        {
            _validCorrencies = ["COP", "MXN","USD", "EUR"];
            validateCurrency(currency);
            validateMount(mount);
            Mount = mount;
            Curreny = currency;
        }

        private void validateMount(decimal mount) 
        {
            if (mount <= 0) 
            {
                throw new InvalidDataException("Invalid mount");
            }
        }

        private void validateCurrency(string currency)
        {
            if (!_validCorrencies.Contains(currency))
            {
                throw new InvalidDataException("Invalid currency");
            }
        }
    }
}
