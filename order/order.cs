//Copyright (c) 2023 Swopblock

using System.Linq.Expressions;

//Console.WriteLine("Hello, Swopblock Core Ordering World!");

//var orderModel = new OrderModel(Console.Out, Console.In);

//orderModel.ProcessOrders();

//Invoice Invoice= new Invoice();

public class OrderModel
{
    TextWriter Writer;

    TextReader Reader;

    public OrderModel()
    {

    }

    public OrderModel(TextWriter writer, TextReader reader)
    {
        Writer = writer;

        Reader = reader;
    }

    public void ProcessOrders()
    {
        string message;

        while ((message = Reader.ReadLine()) != null)
        {
            message = ProcessOrder(message);

            Writer.WriteLine(message);
        }
    }

    public string ProcessOrder(string line) 
    {
        return null;
    }

    public void OrderSynthesizing()
    {
        for (int i = 0; i < 10; i++)
        {
            Writer.WriteLine("I am");
        }
    }
}

public class Offer
{
    public Amount Amount { get; init; }

    public Unit OfferUnit { get; init; }    

    public Unit UsingUnit { get; init; }

    public Address Address { get; init; }

    public string Text { get; init; }

    public Offer(Amount amount, Unit offerUnit, Unit usingUnit, Address address)
    {
        Amount = amount;
        OfferUnit = offerUnit;
        UsingUnit = usingUnit;
        Address = address;

        Text = Amount.Text + OfferUnit.Text + " using the" + UsingUnit.Text + Address.Text;
    }
}

public class Amount
{
    public decimal AtMost { get; init; }

    public string Text { get; init; }

    public Amount(decimal atMost)
    {
        AtMost = atMost;

        Text = " " + AtMost.ToString();
    }
}

public class Address
{
    public string Text { get; init; }

    public Address(string text)
    {
        Text = " address " + text;
    }
}

public class Order
{
    public Unit Unit { get; init; }
    public string Text { get; init; }

    public Order(Unit unit) 
    {
        Unit = unit;

        Text = Unit.Text + " using the market.";
    }
}

public abstract class Unit
{
    public string Text { get; init; }
}

public class BTC : Unit
{
    public BTC()
    {
        Text = " BTC";
    }
}

public class ETH : Unit
{
    public ETH()
    {
        Text = " ETH";
    }
}

public class USD : Unit
{
    public USD()
    {
        Text = " USD";
    }
}

public class SWOBL : Unit
{
    public SWOBL()
    {
        Text = " SWOBL";
    }
}
