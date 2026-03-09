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
    [KnownType(typeof(GrossDividendRateFormat5Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat5Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat5Choice.Amount),nameof(GrossDividendRateFormat5Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat5Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat5Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_e26LIeEREd-1Ktb5rVaajw")]
    [DisplayName("Gross Dividend Rate Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat5Choice_
    #else
    public abstract partial class GrossDividendRateFormat5Choice_
    #endif
    {
    }
}
