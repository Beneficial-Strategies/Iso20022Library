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
    /// Choice of a payment instrument for the cash-in flow or cash-out flow.
    /// </summary>
    [KnownType(typeof(CashInOrOut5Choice.CashInPaymentInstrument))]
    [KnownType(typeof(CashInOrOut5Choice.CashOutPaymentInstrument))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CashInOrOut5Choice.CashInPaymentInstrument),nameof(CashInOrOut5Choice.CashInPaymentInstrument))]
    [JsonDerivedType(typeof(CashInOrOut5Choice.CashOutPaymentInstrument),nameof(CashInOrOut5Choice.CashOutPaymentInstrument))]
    #endif
    [IsoId("_SBq60tp-Ed-ak6NoX_4Aeg_1170439952")]
    [DisplayName("Cash In Or Out 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashInOrOut5Choice_
    #else
    public abstract partial class CashInOrOut5Choice_
    #endif
    {
    }
}
