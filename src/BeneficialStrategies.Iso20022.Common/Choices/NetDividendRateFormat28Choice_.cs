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
    [KnownType(typeof(NetDividendRateFormat28Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat28Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat28Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat28Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat28Choice.Amount),nameof(NetDividendRateFormat28Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat28Choice.AmountAndRateStatus),nameof(NetDividendRateFormat28Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat28Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat28Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat28Choice.NotSpecifiedRate),nameof(NetDividendRateFormat28Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_ctoZq5KQEeWHWpTQn1FFVg")]
    [DisplayName("Net Dividend Rate Format 28 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat28Choice_
    #else
    public abstract partial class NetDividendRateFormat28Choice_
    #endif
    {
    }
}
