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
    [KnownType(typeof(GrossDividendRateFormat41Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat41Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat41Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat41Choice.Amount),nameof(GrossDividendRateFormat41Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat41Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat41Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat41Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat41Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_bZ6BFwVTEeqjd8n6wD9JVw")]
    [DisplayName("Gross Dividend Rate Format 41 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat41Choice_
    #else
    public abstract partial class GrossDividendRateFormat41Choice_
    #endif
    {
    }
}
