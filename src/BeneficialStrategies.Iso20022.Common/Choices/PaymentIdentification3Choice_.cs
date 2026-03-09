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
    [KnownType(typeof(PaymentIdentification3Choice.PaymentInstructionReference))]
    [KnownType(typeof(PaymentIdentification3Choice.QueueIdentification))]
    [KnownType(typeof(PaymentIdentification3Choice.LongBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification3Choice.ShortBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification3Choice.ProprietaryReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentIdentification3Choice.PaymentInstructionReference),nameof(PaymentIdentification3Choice.PaymentInstructionReference))]
    [JsonDerivedType(typeof(PaymentIdentification3Choice.QueueIdentification),nameof(PaymentIdentification3Choice.QueueIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification3Choice.LongBusinessIdentification),nameof(PaymentIdentification3Choice.LongBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification3Choice.ShortBusinessIdentification),nameof(PaymentIdentification3Choice.ShortBusinessIdentification))]
    [JsonDerivedType(typeof(PaymentIdentification3Choice.ProprietaryReference),nameof(PaymentIdentification3Choice.ProprietaryReference))]
    #endif
    [IsoId("_RbYW59p-Ed-ak6NoX_4Aeg_-1132471784")]
    [DisplayName("Payment Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentIdentification3Choice_
    #else
    public abstract partial class PaymentIdentification3Choice_
    #endif
    {
    }
}
