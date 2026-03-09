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
    [KnownType(typeof(NetDividendRateFormat23Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat23Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat23Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat23Choice.Amount),nameof(NetDividendRateFormat23Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat23Choice.AmountAndRateStatus),nameof(NetDividendRateFormat23Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat23Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat23Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_VS0koWXGEeWht50_j0HXAQ")]
    [DisplayName("Net Dividend Rate Format 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat23Choice_
    #else
    public abstract partial class NetDividendRateFormat23Choice_
    #endif
    {
    }
}
