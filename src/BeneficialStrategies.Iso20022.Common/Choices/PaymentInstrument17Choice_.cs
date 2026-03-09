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
    [KnownType(typeof(PaymentInstrument17Choice.CashAccountDetails))]
    [KnownType(typeof(PaymentInstrument17Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument17Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument17Choice.Cheque))]
    [KnownType(typeof(PaymentInstrument17Choice.BankersDraft))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument17Choice.CashAccountDetails),nameof(PaymentInstrument17Choice.CashAccountDetails))]
    [JsonDerivedType(typeof(PaymentInstrument17Choice.PaymentCardDetails),nameof(PaymentInstrument17Choice.PaymentCardDetails))]
    [JsonDerivedType(typeof(PaymentInstrument17Choice.DirectDebitDetails),nameof(PaymentInstrument17Choice.DirectDebitDetails))]
    [JsonDerivedType(typeof(PaymentInstrument17Choice.Cheque),nameof(PaymentInstrument17Choice.Cheque))]
    [JsonDerivedType(typeof(PaymentInstrument17Choice.BankersDraft),nameof(PaymentInstrument17Choice.BankersDraft))]
    #endif
    [IsoId("_dK0IcxdHEeK5g-3oYI0_9Q")]
    [DisplayName("Payment Instrument 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument17Choice_
    #else
    public abstract partial class PaymentInstrument17Choice_
    #endif
    {
    }
}
