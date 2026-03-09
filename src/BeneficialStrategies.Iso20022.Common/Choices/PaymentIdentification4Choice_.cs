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
    [KnownType(typeof(PaymentIdentification4Choice.TransactionIdentification))]
    [KnownType(typeof(PaymentIdentification4Choice.QueueIdentification))]
    [KnownType(typeof(PaymentIdentification4Choice.LongBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification4Choice.ShortBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification4Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentIdentification4Choice.TransactionIdentification),nameof(PaymentIdentification4Choice.TransactionIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification4Choice.QueueIdentification),nameof(PaymentIdentification4Choice.QueueIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification4Choice.LongBusinessIdentification),nameof(PaymentIdentification4Choice.LongBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification4Choice.ShortBusinessIdentification),nameof(PaymentIdentification4Choice.ShortBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification4Choice.ProprietaryIdentification),nameof(PaymentIdentification4Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_74nuuKMgEeCJ6YNENx4h-w_753155238")]
    [DisplayName("Payment Identification 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentIdentification4Choice_
    #else
    public abstract partial class PaymentIdentification4Choice_
    #endif
    {
    }
}
