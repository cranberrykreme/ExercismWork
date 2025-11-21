public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    // TODO: implement equality operators
    public static bool operator ==(CurrencyAmount a, CurrencyAmount b)
    {
        if(!String.Equals(a.currency, b.currency))
            throw new ArgumentException();
        return a.amount == b.amount;
    }

    public static bool operator !=(CurrencyAmount a, CurrencyAmount b) => !(a == b);

    // TODO: implement comparison operators
    public static bool operator >(CurrencyAmount a, CurrencyAmount b)
    {
        if(!String.Equals(a.currency, b.currency))
            throw new ArgumentException();
        return a.amount > b.amount;
    }

    public static bool operator <(CurrencyAmount a, CurrencyAmount b)
    {
        if(!String.Equals(a.currency, b.currency))
            throw new ArgumentException();
        return a.amount < b.amount;
    }

    // TODO: implement arithmetic operators
    public static CurrencyAmount operator +(CurrencyAmount a, CurrencyAmount b)
    {
        if(!String.Equals(a.currency, b.currency, StringComparison.OrdinalIgnoreCase))
            throw new ArgumentException();

        return new CurrencyAmount{amount = a.amount + b.amount, currency = a.currency};
    }

    public static CurrencyAmount operator -(CurrencyAmount a, CurrencyAmount b)
    {
        if(!String.Equals(a.currency, b.currency, StringComparison.OrdinalIgnoreCase))
            throw new ArgumentException();

        return new CurrencyAmount{amount = a.amount - b.amount, currency = a.currency};  
    }

        
    public static CurrencyAmount operator *(CurrencyAmount a, decimal b)
    {
        return new CurrencyAmount{amount = a.amount * b, currency = a.currency};  
    }

    public static CurrencyAmount operator *(decimal a, CurrencyAmount b)
    {
        return new CurrencyAmount{amount = a * b.amount, currency = b.currency};  
    }
    
    public static CurrencyAmount operator /(CurrencyAmount a, decimal b)
    {
        if(b == 0)
            throw new DivideByZeroException();

        return new CurrencyAmount{amount = a.amount / b, currency = a.currency};  
    }

    // TODO: implement type conversion operators
    public static explicit operator double(CurrencyAmount a) => (double)a.amount;

    public static implicit operator decimal(CurrencyAmount a) => a.amount;
}
