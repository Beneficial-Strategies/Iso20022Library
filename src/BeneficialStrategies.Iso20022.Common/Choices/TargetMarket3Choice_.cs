// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the market for a type of investor expressed as a code.
    /// </summary>
    [KnownType(typeof(TargetMarket3Choice.Type))]
    [KnownType(typeof(TargetMarket3Choice.Other))]
    [KnownType(typeof(TargetMarket3Choice.Proprietary))]
    [JsonDerivedType(typeof(TargetMarket3Choice.Type), nameof(TargetMarket3Choice.Type))]
    [JsonDerivedType(typeof(TargetMarket3Choice.Other), nameof(TargetMarket3Choice.Other))]
    [JsonDerivedType(
        typeof(TargetMarket3Choice.Proprietary),
        nameof(TargetMarket3Choice.Proprietary)
    )]
    [IsoId("_JK13wDcREeiIxKQErQxblg")]
    [DisplayName("Target Market 3 Choice")]
    public abstract record TargetMarket3Choice_ { }
}
