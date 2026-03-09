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
    [KnownType(typeof(GrossDividendRateFormat29Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat29Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat29Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat29Choice.Amount),nameof(GrossDividendRateFormat29Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat29Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat29Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat29Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat29Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_6AoXsZb8Eee8S7xwGG7Veg")]
    [DisplayName("Gross Dividend Rate Format 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat29Choice_
    #else
    public abstract partial class GrossDividendRateFormat29Choice_
    #endif
    {
    }
}
