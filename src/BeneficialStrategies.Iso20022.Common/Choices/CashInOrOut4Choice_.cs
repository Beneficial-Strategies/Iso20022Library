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
    [KnownType(typeof(CashInOrOut4Choice.CashInPaymentInstrument))]
    [KnownType(typeof(CashInOrOut4Choice.CashOutPaymentInstrument))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CashInOrOut4Choice.CashInPaymentInstrument),nameof(CashInOrOut4Choice.CashInPaymentInstrument))]
    [JsonDerivedType(typeof(CashInOrOut4Choice.CashOutPaymentInstrument),nameof(CashInOrOut4Choice.CashOutPaymentInstrument))]
    #endif
    [IsoId("_VKP1Utp-Ed-ak6NoX_4Aeg_-1582566074")]
    [DisplayName("Cash In Or Out 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashInOrOut4Choice_
    #else
    public abstract partial class CashInOrOut4Choice_
    #endif
    {
    }
}
