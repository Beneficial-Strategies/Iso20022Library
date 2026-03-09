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
    [KnownType(typeof(PaymentInstrument18Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument18Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument18Choice.Cheque))]
    [KnownType(typeof(PaymentInstrument18Choice.BankersDraft))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument18Choice.PaymentCardDetails),nameof(PaymentInstrument18Choice.PaymentCardDetails))]
    [JsonDerivedType(typeof(PaymentInstrument18Choice.DirectDebitDetails),nameof(PaymentInstrument18Choice.DirectDebitDetails))]
    [JsonDerivedType(typeof(PaymentInstrument18Choice.Cheque),nameof(PaymentInstrument18Choice.Cheque))]
    [JsonDerivedType(typeof(PaymentInstrument18Choice.BankersDraft),nameof(PaymentInstrument18Choice.BankersDraft))]
    #endif
    [IsoId("_fNjxsSC1EeWJd9HF2tO7BA")]
    [DisplayName("Payment Instrument 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument18Choice_
    #else
    public abstract partial class PaymentInstrument18Choice_
    #endif
    {
    }
}
