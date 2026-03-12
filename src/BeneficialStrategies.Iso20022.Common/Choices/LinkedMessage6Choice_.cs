// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reference to a message.
    /// </summary>
    [KnownType(typeof(LinkedMessage6Choice.PreviousReference))]
    [KnownType(typeof(LinkedMessage6Choice.OtherReference))]
    [KnownType(typeof(LinkedMessage6Choice.RelatedReference))]
    [JsonDerivedType(typeof(LinkedMessage6Choice.PreviousReference),nameof(LinkedMessage6Choice.PreviousReference))]
    [JsonDerivedType(typeof(LinkedMessage6Choice.OtherReference),nameof(LinkedMessage6Choice.OtherReference))]
    [JsonDerivedType(typeof(LinkedMessage6Choice.RelatedReference),nameof(LinkedMessage6Choice.RelatedReference))]
    [IsoId("_2mW56TWhEe2OzdGcZrUAEQ")]
    [DisplayName("Linked Message 6 Choice")]
    public abstract partial record LinkedMessage6Choice_
    {
    }
}
