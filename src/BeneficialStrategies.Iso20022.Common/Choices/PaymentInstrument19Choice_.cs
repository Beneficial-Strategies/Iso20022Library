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
    [KnownType(typeof(PaymentInstrument19Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument19Choice.BankersDraftDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument19Choice.ChequeDetails),nameof(PaymentInstrument19Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument19Choice.BankersDraftDetails),nameof(PaymentInstrument19Choice.BankersDraftDetails))]
    #endif
    [IsoId("_-J8xYSC1EeWJd9HF2tO7BA")]
    [DisplayName("Payment Instrument 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument19Choice_
    #else
    public abstract partial class PaymentInstrument19Choice_
    #endif
    {
    }
}
