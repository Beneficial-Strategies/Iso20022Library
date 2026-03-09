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
    [KnownType(typeof(NetDividendRateFormat36Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat36Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat36Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat36Choice.Amount),nameof(NetDividendRateFormat36Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat36Choice.AmountAndRateStatus),nameof(NetDividendRateFormat36Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat36Choice.NotSpecifiedRate),nameof(NetDividendRateFormat36Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_k9xM083xEee5nJBZsW8MFQ")]
    [DisplayName("Net Dividend Rate Format 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat36Choice_
    #else
    public abstract partial class NetDividendRateFormat36Choice_
    #endif
    {
    }
}
