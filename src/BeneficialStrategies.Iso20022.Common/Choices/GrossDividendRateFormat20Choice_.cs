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
    [KnownType(typeof(GrossDividendRateFormat20Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat20Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat20Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat20Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat20Choice.Amount),nameof(GrossDividendRateFormat20Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat20Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat20Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat20Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat20Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat20Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat20Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_wnN5YWOWEeWYYI9c62RCjw")]
    [DisplayName("Gross Dividend Rate Format 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat20Choice_
    #else
    public abstract partial class GrossDividendRateFormat20Choice_
    #endif
    {
    }
}
