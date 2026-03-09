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
    [KnownType(typeof(NetDividendRateFormat5Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat5Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat5Choice.Amount),nameof(NetDividendRateFormat5Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat5Choice.NotSpecifiedRate),nameof(NetDividendRateFormat5Choice.NotSpecifiedRate))]
    #endif
    [IsoId("__XFDgOwOEd-sn-FiNtktcA")]
    [DisplayName("Net Dividend Rate Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat5Choice_
    #else
    public abstract partial class NetDividendRateFormat5Choice_
    #endif
    {
    }
}
