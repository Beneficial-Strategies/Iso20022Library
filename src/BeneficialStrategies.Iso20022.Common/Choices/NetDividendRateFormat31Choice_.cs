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
    [KnownType(typeof(NetDividendRateFormat31Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat31Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat31Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat31Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat31Choice.Amount),nameof(NetDividendRateFormat31Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat31Choice.AmountAndRateStatus),nameof(NetDividendRateFormat31Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat31Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat31Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat31Choice.NotSpecifiedRate),nameof(NetDividendRateFormat31Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_SR2f4Zb9Eee8S7xwGG7Veg")]
    [DisplayName("Net Dividend Rate Format 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat31Choice_
    #else
    public abstract partial class NetDividendRateFormat31Choice_
    #endif
    {
    }
}
