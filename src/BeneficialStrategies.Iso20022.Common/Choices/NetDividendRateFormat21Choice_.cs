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
    [KnownType(typeof(NetDividendRateFormat21Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat21Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat21Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat21Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat21Choice.Amount),nameof(NetDividendRateFormat21Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat21Choice.AmountAndRateStatus),nameof(NetDividendRateFormat21Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat21Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat21Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat21Choice.NotSpecifiedRate),nameof(NetDividendRateFormat21Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_Gr_NkWOWEeWYYI9c62RCjw")]
    [DisplayName("Net Dividend Rate Format 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat21Choice_
    #else
    public abstract partial class NetDividendRateFormat21Choice_
    #endif
    {
    }
}
