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
    [KnownType(typeof(CashInOrOut3Choice.CashInPaymentInstrument))]
    [KnownType(typeof(CashInOrOut3Choice.CashOutPaymentInstrument))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CashInOrOut3Choice.CashInPaymentInstrument),nameof(CashInOrOut3Choice.CashInPaymentInstrument))]
    [JsonDerivedType(typeof(CashInOrOut3Choice.CashOutPaymentInstrument),nameof(CashInOrOut3Choice.CashOutPaymentInstrument))]
    #endif
    [IsoId("_VKGEX9p-Ed-ak6NoX_4Aeg_2056585648")]
    [DisplayName("Cash In Or Out 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashInOrOut3Choice_
    #else
    public abstract partial class CashInOrOut3Choice_
    #endif
    {
    }
}
