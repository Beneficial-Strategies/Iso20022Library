// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Charges5Choice.
    /// </summary>
    [KnownType(typeof(Charges5Choice.PerTransaction))]
    [KnownType(typeof(Charges5Choice.PerType))]
    [KnownType(typeof(Charges5Choice.Single))]
    [JsonDerivedType(typeof(Charges5Choice.PerTransaction), nameof(Charges5Choice.PerTransaction))]
    [JsonDerivedType(typeof(Charges5Choice.PerType), nameof(Charges5Choice.PerType))]
    [JsonDerivedType(typeof(Charges5Choice.Single), nameof(Charges5Choice.Single))]
    [IsoId("_ZFLpUT0JEe-thIfLZ94a1w")]
    [DisplayName("Charges5Choice")]
    public abstract record Charges5Choice_ { }
}
