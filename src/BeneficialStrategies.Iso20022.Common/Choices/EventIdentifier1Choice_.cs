// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates an event identifier or post trade risk reduction identifier.
    /// </summary>
    [KnownType(typeof(EventIdentifier1Choice.EventIdentifier))]
    [KnownType(typeof(EventIdentifier1Choice.PostTradeRiskReductionIdentifier))]
    [JsonDerivedType(typeof(EventIdentifier1Choice.EventIdentifier),nameof(EventIdentifier1Choice.EventIdentifier))]
    [JsonDerivedType(typeof(EventIdentifier1Choice.PostTradeRiskReductionIdentifier),nameof(EventIdentifier1Choice.PostTradeRiskReductionIdentifier))]
    [IsoId("_nfQOQPbfEeyInphUKJZxtQ")]
    [DisplayName("Event Identifier 1 Choice")]
    public abstract partial record EventIdentifier1Choice_
    {
    }
}
