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
    [KnownType(typeof(NetDividendRateFormat44Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat44Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat44Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat44Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat44Choice.Amount),nameof(NetDividendRateFormat44Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat44Choice.AmountAndRateStatus),nameof(NetDividendRateFormat44Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat44Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat44Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat44Choice.NotSpecifiedRate),nameof(NetDividendRateFormat44Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_baDKfwVTEeqjd8n6wD9JVw")]
    [DisplayName("Net Dividend Rate Format 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat44Choice_
    #else
    public abstract partial class NetDividendRateFormat44Choice_
    #endif
    {
    }
}
