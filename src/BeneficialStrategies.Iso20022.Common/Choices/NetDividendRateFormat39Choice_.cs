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
    [KnownType(typeof(NetDividendRateFormat39Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat39Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat39Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat39Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat39Choice.Amount),nameof(NetDividendRateFormat39Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat39Choice.AmountAndRateStatus),nameof(NetDividendRateFormat39Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat39Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat39Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat39Choice.NotSpecifiedRate),nameof(NetDividendRateFormat39Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_h-ht8eXsEemEj48jhmlA0Q")]
    [DisplayName("Net Dividend Rate Format 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat39Choice_
    #else
    public abstract partial class NetDividendRateFormat39Choice_
    #endif
    {
    }
}
