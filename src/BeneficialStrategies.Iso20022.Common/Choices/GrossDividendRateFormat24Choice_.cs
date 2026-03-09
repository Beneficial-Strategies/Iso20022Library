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
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat24Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat24Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat24Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat24Choice.Amount),nameof(GrossDividendRateFormat24Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat24Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat24Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat24Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat24Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_ckMw4ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Gross Dividend Rate Format 24 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat24Choice_
    #else
    public abstract partial class GrossDividendRateFormat24Choice_
    #endif
    {
    }
}
