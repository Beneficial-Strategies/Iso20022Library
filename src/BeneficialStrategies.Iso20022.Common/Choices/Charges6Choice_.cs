// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Charges6Choice.
    /// </summary>
    [KnownType(typeof(Charges6Choice.PerTransaction))]
    [KnownType(typeof(Charges6Choice.PerType))]
    [KnownType(typeof(Charges6Choice.Single))]
    [JsonDerivedType(typeof(Charges6Choice.PerTransaction), nameof(Charges6Choice.PerTransaction))]
    [JsonDerivedType(typeof(Charges6Choice.PerType), nameof(Charges6Choice.PerType))]
    [JsonDerivedType(typeof(Charges6Choice.Single), nameof(Charges6Choice.Single))]
    [IsoId("_Dn6yUT0QEe-thIfLZ94a1w")]
    [DisplayName("Charges6Choice")]
    public abstract record Charges6Choice_ { }
}
