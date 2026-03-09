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
    [KnownType(typeof(NetDividendRateFormat32Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat32Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat32Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat32Choice.Amount),nameof(NetDividendRateFormat32Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat32Choice.AmountAndRateStatus),nameof(NetDividendRateFormat32Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat32Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat32Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_S_-xNZb9Eee8S7xwGG7Veg")]
    [DisplayName("Net Dividend Rate Format 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat32Choice_
    #else
    public abstract partial class NetDividendRateFormat32Choice_
    #endif
    {
    }
}
