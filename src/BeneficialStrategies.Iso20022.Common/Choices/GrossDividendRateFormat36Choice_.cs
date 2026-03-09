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
    [KnownType(typeof(GrossDividendRateFormat36Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat36Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat36Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat36Choice.Amount),nameof(GrossDividendRateFormat36Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat36Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat36Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat36Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat36Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_DE35h-XsEemEj48jhmlA0Q")]
    [DisplayName("Gross Dividend Rate Format 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat36Choice_
    #else
    public abstract partial class GrossDividendRateFormat36Choice_
    #endif
    {
    }
}
