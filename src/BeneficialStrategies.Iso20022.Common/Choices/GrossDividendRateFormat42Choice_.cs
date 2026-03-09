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
    [KnownType(typeof(GrossDividendRateFormat42Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat42Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat42Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat42Choice.Amount),nameof(GrossDividendRateFormat42Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat42Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat42Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat42Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat42Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_bZ_lFwVTEeqjd8n6wD9JVw")]
    [DisplayName("Gross Dividend Rate Format 42 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat42Choice_
    #else
    public abstract partial class GrossDividendRateFormat42Choice_
    #endif
    {
    }
}
