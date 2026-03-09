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
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat25Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat25Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat25Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat25Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat25Choice.Amount),nameof(GrossDividendRateFormat25Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat25Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat25Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat25Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat25Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat25Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat25Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_ctdaz5KQEeWHWpTQn1FFVg")]
    [DisplayName("Gross Dividend Rate Format 25 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat25Choice_
    #else
    public abstract partial class GrossDividendRateFormat25Choice_
    #endif
    {
    }
}
