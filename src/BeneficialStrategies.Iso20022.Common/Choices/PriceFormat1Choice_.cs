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
    /// Choice of formats to express a price.
    /// </summary>
    [KnownType(typeof(PriceFormat1Choice.Amount))]
    [KnownType(typeof(PriceFormat1Choice.Rate))]
    [KnownType(typeof(PriceFormat1Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat1Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat1Choice.NotSpecified))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat1Choice.Amount),nameof(PriceFormat1Choice.Amount))]
    [JsonDerivedType(typeof(PriceFormat1Choice.Rate),nameof(PriceFormat1Choice.Rate))]
    [JsonDerivedType(typeof(PriceFormat1Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat1Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat1Choice.AmountPricePerAmount),nameof(PriceFormat1Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat1Choice.NotSpecified),nameof(PriceFormat1Choice.NotSpecified))]
    #endif
    [IsoId("_QatkFdp-Ed-ak6NoX_4Aeg_-958538176")]
    [DisplayName("Price Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat1Choice_
    #else
    public abstract partial class PriceFormat1Choice_
    #endif
    {
    }
}
