//Copyright (c) 2023 Swopblock

using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

//Console.WriteLine("Hello, Swopblock Core Ordering World!");

//var orderModel = new OrderModel(Console.Out, Console.In);

//orderModel.ProcessOrders();

//Invoice Invoice= new Invoice();

namespace Swopblock
{
    public partial interface IOfferable { }// : IReceipt { IOffer Make(); }

    public interface IOffer { IOfferable Make(); }

    public partial interface IOfferConfirmable { IInvoiceable Make(); }

 
    //public partial interface IInvoice { IDeliverable Make(); }

    //public partial interface IInvoiceDeliverable { IDeliveryNetworkable Make(); }

    public partial interface IDeliveryConfirmable { IReceiptable Make(); }

    public partial interface IDelivery { }


    public partial interface IReceiptable { }// { IOffer Make(); }

    //public partial interface IReceipt { }


    public interface ISignature { }






    public interface ISignable { void Sign(); }

    public interface IBroadcastable { void Broadcast(); }

    public interface IInvoiceable { }
    public interface IDeliverable { }
    public interface IConfirmable { }


    public record AnOffer() : ISignable, IBroadcastable, IInvoiceable
    {
        public void Sign() { throw new NotImplementedException(); }

        public void Broadcast() { throw new NotImplementedException(); }

        public void Confirm() { throw new NotImplementedException(); }

        public AnInvoice Invoice() { throw new NotImplementedException(); }

    }

    public record AnInvoice()// : ISignable, IDeliverable
    {

    }

    public record ADelivery() : IReceiptable
    {

    }

    public record AReceipt() : IOfferable
    {

    }

    public interface IAppSignOff
    {
        OfferModels SignOff(ReceiptModels order);

    }

    public interface IAutoSignOff
    {
        DeliveryModels SignOff(InvoiceModels order);
    }

    public interface IAppBroadcast
    {
        OfferModels Broadcast(OfferModels order);
    }

    public interface IAutoBroadcast
    {
        DeliveryModels Broadcast(DeliveryModels order);
    }

    public interface IAppConfirm
    {
        OfferModels Confirm(OfferModels order);
    }

    public interface IAutoConfirm
    { 
        DeliveryModels Confirm(DeliveryModels order);
    }

    public interface IInvoice
    {
    InvoiceModels Invoice(OfferModels order);
    }

    public interface IReceipt
    {
    ReceiptModels Receipt(DeliveryModels order);
    }


    //Offers = SignOff(Receipts)
    public class AppModels // : IAppSignOff
    {
        public IBroadcastable Sign(ISignable offer)
        {
            offer.Sign();

            throw new NotImplementedException();
        }

        public IConfirmable Broadcast(IBroadcastable offer) 
        {
            offer.Broadcast();

            throw new NotImplementedException(); 
        }

        public void Confirm() 
        { 
            throw new NotImplementedException(); 
        }

        public AnInvoice Invoice(IInvoiceable offer) 
        {
            //var anInvoice = offer.Invoice();

            throw new NotImplementedException(); 
        }
    }

    //Offers = Broadcast(Offers)
    public class OfferModels// : IOffer 
    { //public IOfferConfirmable Broadcast();
    }

    //Offers = Confirm(Offers)
    public class AppNetModels { }

    //Invoices = Invoice(Offers)
    public class InvoiceModels { }

    //Deliveries SignOff(Invoices)
    public class AutoModels { }

    //Deliveries = Broadcast(Deliveries)
    public class DeliveryModels { }

    //Deliveries = Confirm(Deliveries)
    public class AutoNetModels { }

    //Receipts = Receipt(Deliveries)
    public class ReceiptModels { }


    //public interface IOfferConfirmater
    public class Order2// : IUser2,
    {
        //IUsing2 User;

        IOffer User(IOfferable order) { return null; }

        IOfferConfirmable Offer(IOffer order) { return null; }

        IInvoiceable Confirm(IOffer order) { return null; }

        IInvoice Invoice(IInvoiceable order) { return null; }

        IDelivery Deliver(IInvoice order) { return null; }

        //IReceiptable Confirm();

        IReceipt Receipt(IDelivery order) { return null; }
    }
}
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

