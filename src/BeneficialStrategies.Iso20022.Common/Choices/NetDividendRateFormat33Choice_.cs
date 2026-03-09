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
    [KnownType(typeof(NetDividendRateFormat33Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat33Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat33Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat33Choice.Amount),nameof(NetDividendRateFormat33Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat33Choice.AmountAndRateStatus),nameof(NetDividendRateFormat33Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat33Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat33Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_skrJq83wEee5nJBZsW8MFQ")]
    [DisplayName("Net Dividend Rate Format 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat33Choice_
    #else
    public abstract partial class NetDividendRateFormat33Choice_
    #endif
    {
    }
}
