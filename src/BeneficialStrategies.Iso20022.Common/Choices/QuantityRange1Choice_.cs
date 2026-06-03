// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.QuantityRange1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a range of quantities.</summary>
    [IsoId("_jtHuFO5NEeCisYr99QEiWA_-1373711231")]
    [DisplayName("Quantity Range 1 Choice")]
    [KnownType(typeof(QuantityRange1Choice.FromQuantity))]
    [KnownType(typeof(QuantityRange1Choice.ToQuantity))]
    [KnownType(typeof(QuantityRange1Choice.FromToQuantity))]
    [KnownType(typeof(QuantityRange1Choice.EqualQuantity))]
    [KnownType(typeof(QuantityRange1Choice.NotEqualQuantity))]
    [JsonDerivedType(typeof(QuantityRange1Choice.FromQuantity))]
    [JsonDerivedType(typeof(QuantityRange1Choice.ToQuantity))]
    [JsonDerivedType(typeof(QuantityRange1Choice.FromToQuantity))]
    [JsonDerivedType(typeof(QuantityRange1Choice.EqualQuantity))]
    [JsonDerivedType(typeof(QuantityRange1Choice.NotEqualQuantity))]
    public abstract record QuantityRange1Choice_
    {
    }
}
