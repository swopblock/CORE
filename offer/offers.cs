using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace offer
{
   //public interface IConstructable
   // {
   //     IConstructing New(IConstructable order);
   // }

   // public interface IConstructing
   // {
   //     IConstructed Execute(IConstructing order);
   // }

   // public interface IConstructed
   // {
   //     IComposable Verify(IConstructed order);
   // }

   // public interface IComposable
   // {

   // }

 
    //public interface IConstruct : IConstructing, IConstructable
    //{
    //    IConstruct 
    //    IConstructed Construct(IConstruct order)
    //    {
    //        IConstructing New();

    //        IConstructed Execute
    //        return 
    //    }
    //}

    public record Confirmations() : Deliveries;

    public record Deliveries() : Invoices;

    public record Invoices() : Offers;

    public record Offers() : IOrder;


    public record Orders()// : IOffer
    {
        Constructions Construction;

        Compositions Composition;

        Signatures Signature;

        Broadcasts Broadcast;

        Confirmations Confirmation;

        Enforcements Enforcement;
    }

    public class Constructions// : IConstruction
    {

    }

    public class Compositions
    {

    }

    public class Signatures
    {

    }

    public class Broadcasts
    {

    }

    //public class Confirmations
    //{

    //}

    public class Enforcements
    {

    }

    public interface IOrder// : IOffer 
    {
        //IOrder New(IOrder order)

    }

    public interface IOffer : IConstruction
    { 
        ISignable Compose(IComposable order);

        IBroadcastable Sign(ISignable order);

        IConfirmable Broadcast(IBroadcastable order);

        IEnforcable Enforce(IConfirmable order);
    }

    public interface IConstruction 
    { 
        IComposable Construct(IConstructable order);    
    }

    public interface IConstructable : IConstruction 
    { 
        //IConstructable New()
    }

    public interface IConstructing : IConstruction { }

    public interface IConstucted : IConstruction { }

    public interface IComposable { }

    public interface ISignable { }

    public interface IBroadcastable { }

    public interface IConfirmable { }

    public interface IEnforcable { }

}
