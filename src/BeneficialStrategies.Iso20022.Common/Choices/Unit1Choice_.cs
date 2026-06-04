// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.Unit1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for a quantity unit.</summary>
    [IsoId("29148de0-e75a-40ff-92d1-cdca9ae069d9")]
    [DisplayName("Unit 1 Choice")]
    [KnownType(typeof(Unit1Choice.UnitsNumber))]
    [KnownType(typeof(Unit1Choice.DigitalTokenUnit))]
    [JsonDerivedType(typeof(Unit1Choice.UnitsNumber))]
    [JsonDerivedType(typeof(Unit1Choice.DigitalTokenUnit))]
    public abstract record Unit1Choice_
    {
    }
}
