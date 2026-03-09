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
    [KnownType(typeof(GrossDividendRateFormat30Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat30Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat30Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat30Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat30Choice.Amount),nameof(GrossDividendRateFormat30Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat30Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat30Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat30Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat30Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat30Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat30Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_6wixtZb8Eee8S7xwGG7Veg")]
    [DisplayName("Gross Dividend Rate Format 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat30Choice_
    #else
    public abstract partial class GrossDividendRateFormat30Choice_
    #endif
    {
    }
}
