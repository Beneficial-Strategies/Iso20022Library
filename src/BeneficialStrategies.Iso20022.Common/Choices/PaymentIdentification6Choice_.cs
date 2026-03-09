// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways of identifying a payment instruction by its references and business identification.
    /// </summary>
    [KnownType(typeof(PaymentIdentification6Choice.TransactionIdentification))]
    [KnownType(typeof(PaymentIdentification6Choice.QueueIdentification))]
    [KnownType(typeof(PaymentIdentification6Choice.LongBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification6Choice.ShortBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification6Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentIdentification6Choice.TransactionIdentification),nameof(PaymentIdentification6Choice.TransactionIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification6Choice.QueueIdentification),nameof(PaymentIdentification6Choice.QueueIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification6Choice.LongBusinessIdentification),nameof(PaymentIdentification6Choice.LongBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification6Choice.ShortBusinessIdentification),nameof(PaymentIdentification6Choice.ShortBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification6Choice.ProprietaryIdentification),nameof(PaymentIdentification6Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_AW_FQ24-EeiU9cctagi5ow")]
    [DisplayName("Payment Identification 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentIdentification6Choice_
    #else
    public abstract partial class PaymentIdentification6Choice_
    #endif
    {
    }
}
