// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the volume and value percentage rates of settlement instructions.
    /// </summary>
    [KnownType(typeof(SettlementDataRate1Choice.NumberOfInstructions))]
    [KnownType(typeof(SettlementDataRate1Choice.ValueOfInstructions))]
    [JsonDerivedType(
        typeof(SettlementDataRate1Choice.NumberOfInstructions),
        nameof(SettlementDataRate1Choice.NumberOfInstructions)
    )]
    [JsonDerivedType(
        typeof(SettlementDataRate1Choice.ValueOfInstructions),
        nameof(SettlementDataRate1Choice.ValueOfInstructions)
    )]
    [IsoId("_yFQMA8s0EemSav3hRKzWyg")]
    [DisplayName("Settlement Data Rate 1 Choice")]
    public abstract record SettlementDataRate1Choice_ { }
}
