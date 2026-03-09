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
    [KnownType(typeof(PaymentIdentification5Choice.TransactionIdentification))]
    [KnownType(typeof(PaymentIdentification5Choice.QueueIdentification))]
    [KnownType(typeof(PaymentIdentification5Choice.LongBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification5Choice.ShortBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification5Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentIdentification5Choice.TransactionIdentification),nameof(PaymentIdentification5Choice.TransactionIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification5Choice.QueueIdentification),nameof(PaymentIdentification5Choice.QueueIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification5Choice.LongBusinessIdentification),nameof(PaymentIdentification5Choice.LongBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification5Choice.ShortBusinessIdentification),nameof(PaymentIdentification5Choice.ShortBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification5Choice.ProprietaryIdentification),nameof(PaymentIdentification5Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_UhbRcZlQEee-Zps0fZQaFQ")]
    [DisplayName("Payment Identification 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentIdentification5Choice_
    #else
    public abstract partial class PaymentIdentification5Choice_
    #endif
    {
    }
}
