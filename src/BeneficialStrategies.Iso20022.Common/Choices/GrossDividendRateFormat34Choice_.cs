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
    [KnownType(typeof(GrossDividendRateFormat34Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat34Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat34Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat34Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat34Choice.Amount),nameof(GrossDividendRateFormat34Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat34Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat34Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat34Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat34Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat34Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat34Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_k9v_Fc3xEee5nJBZsW8MFQ")]
    [DisplayName("Gross Dividend Rate Format 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat34Choice_
    #else
    public abstract partial class GrossDividendRateFormat34Choice_
    #endif
    {
    }
}
