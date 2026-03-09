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
    /// Choice between different formats to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat34Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat34Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat34Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat34Choice.Amount),nameof(NetDividendRateFormat34Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat34Choice.AmountAndRateStatus),nameof(NetDividendRateFormat34Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat34Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat34Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_sk1htc3wEee5nJBZsW8MFQ")]
    [DisplayName("Net Dividend Rate Format 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat34Choice_
    #else
    public abstract partial class NetDividendRateFormat34Choice_
    #endif
    {
    }
}
