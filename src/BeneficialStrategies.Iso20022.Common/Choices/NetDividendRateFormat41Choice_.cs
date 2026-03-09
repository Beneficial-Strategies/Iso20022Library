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
    [KnownType(typeof(NetDividendRateFormat41Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat41Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat41Choice.Amount),nameof(NetDividendRateFormat41Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat41Choice.AmountAndRateStatus),nameof(NetDividendRateFormat41Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_-lkh7AVSEeqjd8n6wD9JVw")]
    [DisplayName("Net Dividend Rate Format 41 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat41Choice_
    #else
    public abstract partial class NetDividendRateFormat41Choice_
    #endif
    {
    }
}
