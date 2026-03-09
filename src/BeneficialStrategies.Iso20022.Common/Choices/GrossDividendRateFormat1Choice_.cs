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
    [KnownType(typeof(GrossDividendRateFormat1Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat1Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat1Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRateFormat1Choice.Amount),nameof(GrossDividendRateFormat1Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat1Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat1Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat1Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat1Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_UO8DpNp-Ed-ak6NoX_4Aeg_577708294")]
    [DisplayName("Gross Dividend Rate Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat1Choice_
    #else
    public abstract partial class GrossDividendRateFormat1Choice_
    #endif
    {
    }
}
