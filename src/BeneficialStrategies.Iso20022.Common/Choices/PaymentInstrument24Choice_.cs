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
    /// Choice of payment instruments.
    /// </summary>
    [KnownType(typeof(PaymentInstrument24Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument24Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument24Choice.Cheque))]
    [KnownType(typeof(PaymentInstrument24Choice.BankersDraft))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument24Choice.PaymentCardDetails),nameof(PaymentInstrument24Choice.PaymentCardDetails))]
    [JsonDerivedType(typeof(PaymentInstrument24Choice.DirectDebitDetails),nameof(PaymentInstrument24Choice.DirectDebitDetails))]
    [JsonDerivedType(typeof(PaymentInstrument24Choice.Cheque),nameof(PaymentInstrument24Choice.Cheque))]
    [JsonDerivedType(typeof(PaymentInstrument24Choice.BankersDraft),nameof(PaymentInstrument24Choice.BankersDraft))]
    #endif
    [IsoId("_JSXkMZTBEemqYPWMBuVawg")]
    [DisplayName("Payment Instrument 24 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument24Choice_
    #else
    public abstract partial class PaymentInstrument24Choice_
    #endif
    {
    }
}
