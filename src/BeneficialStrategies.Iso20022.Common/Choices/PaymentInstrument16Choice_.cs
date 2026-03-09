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
    [KnownType(typeof(PaymentInstrument16Choice.CashAccountDetails))]
    [KnownType(typeof(PaymentInstrument16Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument16Choice.BankersDraftDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument16Choice.CashAccountDetails),nameof(PaymentInstrument16Choice.CashAccountDetails))]
    [JsonDerivedType(typeof(PaymentInstrument16Choice.ChequeDetails),nameof(PaymentInstrument16Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument16Choice.BankersDraftDetails),nameof(PaymentInstrument16Choice.BankersDraftDetails))]
    #endif
    [IsoId("_kj1SgRdJEeK5g-3oYI0_9Q")]
    [DisplayName("Payment Instrument 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument16Choice_
    #else
    public abstract partial class PaymentInstrument16Choice_
    #endif
    {
    }
}
