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
    [KnownType(typeof(NetDividendRateFormat25Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat25Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat25Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat25Choice.Amount),nameof(NetDividendRateFormat25Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat25Choice.AmountAndRateStatus),nameof(NetDividendRateFormat25Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat25Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat25Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_cj9gGZKQEeWHWpTQn1FFVg")]
    [DisplayName("Net Dividend Rate Format 25 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat25Choice_
    #else
    public abstract partial class NetDividendRateFormat25Choice_
    #endif
    {
    }
}
