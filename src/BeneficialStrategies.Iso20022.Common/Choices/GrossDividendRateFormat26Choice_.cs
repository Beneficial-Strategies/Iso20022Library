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
    [KnownType(typeof(GrossDividendRateFormat26Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat26Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat26Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat26Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat26Choice.Amount),nameof(GrossDividendRateFormat26Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat26Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat26Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat26Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat26Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat26Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat26Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_ctnLbZKQEeWHWpTQn1FFVg")]
    [DisplayName("Gross Dividend Rate Format 26 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat26Choice_
    #else
    public abstract partial class GrossDividendRateFormat26Choice_
    #endif
    {
    }
}
