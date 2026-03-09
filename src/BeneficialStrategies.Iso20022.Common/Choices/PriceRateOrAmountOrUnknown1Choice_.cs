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
    /// Choice of formats for the price.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmountOrUnknown1Choice.Rate))]
    [KnownType(typeof(PriceRateOrAmountOrUnknown1Choice.Amount))]
    [KnownType(typeof(PriceRateOrAmountOrUnknown1Choice.UnknownIndicator))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceRateOrAmountOrUnknown1Choice.Rate),nameof(PriceRateOrAmountOrUnknown1Choice.Rate))]
    [JsonDerivedType(typeof(PriceRateOrAmountOrUnknown1Choice.Amount),nameof(PriceRateOrAmountOrUnknown1Choice.Amount))]
    [JsonDerivedType(typeof(PriceRateOrAmountOrUnknown1Choice.UnknownIndicator),nameof(PriceRateOrAmountOrUnknown1Choice.UnknownIndicator))]
    #endif
    [IsoId("_Wiwga9p-Ed-ak6NoX_4Aeg_246765395")]
    [DisplayName("Price Rate Or Amount Or Unknown 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceRateOrAmountOrUnknown1Choice_
    #else
    public abstract partial class PriceRateOrAmountOrUnknown1Choice_
    #endif
    {
    }
}
