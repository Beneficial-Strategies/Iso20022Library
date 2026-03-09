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
    [KnownType(typeof(GrossDividendRateFormat27Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat27Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat27Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat27Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat27Choice.Amount),nameof(GrossDividendRateFormat27Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat27Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat27Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat27Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat27Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat27Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat27Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_y6LIHZb7Eee8S7xwGG7Veg")]
    [DisplayName("Gross Dividend Rate Format 27 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat27Choice_
    #else
    public abstract partial class GrossDividendRateFormat27Choice_
    #endif
    {
    }
}
