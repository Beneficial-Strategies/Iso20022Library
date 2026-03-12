// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of how a financial product is in scope of a target market parameter.
    /// </summary>
    [KnownType(typeof(TargetMarket4Choice.Type))]
    [KnownType(typeof(TargetMarket4Choice.Other))]
    [JsonDerivedType(typeof(TargetMarket4Choice.Type),nameof(TargetMarket4Choice.Type))]
    [JsonDerivedType(typeof(TargetMarket4Choice.Other),nameof(TargetMarket4Choice.Other))]
    [IsoId("_eEqHsNdhEeibyvRfU9vJ7w")]
    [DisplayName("Target Market 4 Choice")]
    public abstract partial record TargetMarket4Choice_
    {
    }
}
