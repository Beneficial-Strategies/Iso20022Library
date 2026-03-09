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
    [KnownType(typeof(NetDividendRateFormat37Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat37Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat37Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat37Choice.Amount),nameof(NetDividendRateFormat37Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat37Choice.AmountAndRateStatus),nameof(NetDividendRateFormat37Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat37Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat37Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_OROc4eXsEemEj48jhmlA0Q")]
    [DisplayName("Net Dividend Rate Format 37 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat37Choice_
    #else
    public abstract partial class NetDividendRateFormat37Choice_
    #endif
    {
    }
}
