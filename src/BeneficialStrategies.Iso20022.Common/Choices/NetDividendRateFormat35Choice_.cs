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
    [KnownType(typeof(NetDividendRateFormat35Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat35Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat35Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat35Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat35Choice.Amount),nameof(NetDividendRateFormat35Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat35Choice.AmountAndRateStatus),nameof(NetDividendRateFormat35Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat35Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat35Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat35Choice.NotSpecifiedRate),nameof(NetDividendRateFormat35Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_k9oDD83xEee5nJBZsW8MFQ")]
    [DisplayName("Net Dividend Rate Format 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat35Choice_
    #else
    public abstract partial class NetDividendRateFormat35Choice_
    #endif
    {
    }
}
