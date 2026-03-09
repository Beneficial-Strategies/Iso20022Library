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
    /// Choice between different formats to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat2Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat2Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat2Choice.Amount),nameof(NetDividendRateFormat2Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat2Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat2Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_UM2Y9tp-Ed-ak6NoX_4Aeg_-319728264")]
    [DisplayName("Net Dividend Rate Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat2Choice_
    #else
    public abstract partial class NetDividendRateFormat2Choice_
    #endif
    {
    }
}
