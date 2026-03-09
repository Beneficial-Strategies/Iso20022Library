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
    [KnownType(typeof(NetDividendRateFormat9Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat9Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat9Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat9Choice.Amount),nameof(NetDividendRateFormat9Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat9Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat9Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat9Choice.NotSpecifiedRate),nameof(NetDividendRateFormat9Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_PELn3xFbEeKp2ZN13DI_pA")]
    [DisplayName("Net Dividend Rate Format 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat9Choice_
    #else
    public abstract partial class NetDividendRateFormat9Choice_
    #endif
    {
    }
}
