namespace StatePattern;


public interface IInvoiceState
{
    void Pay(Invoice invoice);
    void Cancel(Invoice invoice);
    void Refund(Invoice invoice);
}

public class Invoice
{
    public int Number
    {
        get;
    }
    public decimal Amount
    {
        get;
    }
    public string Description
    {
        get;
    }
    public IInvoiceState State
    {
        get; set;
    }

    public Invoice(int number, decimal amount, string description)
    {
        Number = number;
        Amount = amount;
        Description = description;

        // Set the invoice as Unpaid
        State = new UnpaidState();
    }


    public void Pay()
    {
        State.Pay(this);
        State = new PaidState();
    }

    public void Cancel()
    {
        State.Cancel(this);
        State = new CanceledState();
    }

    public void Refund()
    {
        State.Refund(this);
        State = new RefundedState();
    }
}


public class UnpaidState : IInvoiceState
{
    public void Pay(Invoice invoice)
    {
        Console.WriteLine($"Paying invoice {invoice.Number}...");

    }

    public void Cancel(Invoice invoice)
    {
        Console.WriteLine($"Canceling invoice {invoice.Number}...");

    }

    public void Refund(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} is unpaid and cannot be refunded.");

    }
}

public class PaidState : IInvoiceState
{
    public void Pay(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} has already been paid.");
    }

    public void Cancel(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} cannot be cancelled.");
    }

    public void Refund(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} has been refunded.");
    }
}

public class CanceledState : IInvoiceState
{
    public void Pay(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} has been canceled and cannot be paid.");
    }

    public void Cancel(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} has already been canceled and cannot be canceled again.");
    }

    public void Refund(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} has been canceled and cannot be refunded.");
    }
}

public class RefundedState : IInvoiceState
{
    public void Cancel(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} was refunded and cannot be cancelled.");

    }
    public void Pay(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} was refunded and cannot be paid.");

    }
    public void Refund(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} cannot be refunded again.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var invoice = new Invoice(123, 1000m, "Software Dev Services");

        invoice.Pay();
        invoice.Refund();
    }
}