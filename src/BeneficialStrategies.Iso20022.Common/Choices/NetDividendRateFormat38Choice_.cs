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
    [KnownType(typeof(NetDividendRateFormat38Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat38Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat38Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat38Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat38Choice.Amount),nameof(NetDividendRateFormat38Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat38Choice.AmountAndRateStatus),nameof(NetDividendRateFormat38Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat38Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat38Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat38Choice.NotSpecifiedRate),nameof(NetDividendRateFormat38Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_PDp_ZeXsEemEj48jhmlA0Q")]
    [DisplayName("Net Dividend Rate Format 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat38Choice_
    #else
    public abstract partial class NetDividendRateFormat38Choice_
    #endif
    {
    }
}
