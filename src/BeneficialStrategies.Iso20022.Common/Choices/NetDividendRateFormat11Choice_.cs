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
    [KnownType(typeof(NetDividendRateFormat11Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat11Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat11Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat11Choice.Amount),nameof(NetDividendRateFormat11Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat11Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat11Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat11Choice.NotSpecifiedRate),nameof(NetDividendRateFormat11Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_2fTxcRLnEeKJ5uSjVyVvug")]
    [DisplayName("Net Dividend Rate Format 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat11Choice_
    #else
    public abstract partial class NetDividendRateFormat11Choice_
    #endif
    {
    }
}
