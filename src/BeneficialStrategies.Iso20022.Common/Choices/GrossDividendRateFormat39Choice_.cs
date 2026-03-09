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
    [KnownType(typeof(GrossDividendRateFormat39Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat39Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat39Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat39Choice.Amount),nameof(GrossDividendRateFormat39Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat39Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat39Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat39Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat39Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_-lkhhAVSEeqjd8n6wD9JVw")]
    [DisplayName("Gross Dividend Rate Format 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat39Choice_
    #else
    public abstract partial class GrossDividendRateFormat39Choice_
    #endif
    {
    }
}
