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
    [KnownType(typeof(GrossDividendRateFormat19Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat19Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat19Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat19Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat19Choice.Amount),nameof(GrossDividendRateFormat19Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat19Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat19Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat19Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat19Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat19Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat19Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_xR_moWOUEeWYYI9c62RCjw")]
    [DisplayName("Gross Dividend Rate Format 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat19Choice_
    #else
    public abstract partial class GrossDividendRateFormat19Choice_
    #endif
    {
    }
}
