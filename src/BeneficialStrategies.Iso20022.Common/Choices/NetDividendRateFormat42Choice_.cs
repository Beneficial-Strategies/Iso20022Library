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
    [KnownType(typeof(NetDividendRateFormat42Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat42Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat42Choice.Amount),nameof(NetDividendRateFormat42Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat42Choice.AmountAndRateStatus),nameof(NetDividendRateFormat42Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_-lxHHwVSEeqjd8n6wD9JVw")]
    [DisplayName("Net Dividend Rate Format 42 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat42Choice_
    #else
    public abstract partial class NetDividendRateFormat42Choice_
    #endif
    {
    }
}
