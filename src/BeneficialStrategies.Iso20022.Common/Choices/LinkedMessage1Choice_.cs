// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reference to a message.
    /// </summary>
    [KnownType(typeof(LinkedMessage1Choice.PreviousReference))]
    [KnownType(typeof(LinkedMessage1Choice.OtherReference))]
    [KnownType(typeof(LinkedMessage1Choice.RelatedReference))]
    [JsonDerivedType(typeof(LinkedMessage1Choice.PreviousReference),nameof(LinkedMessage1Choice.PreviousReference))]
    [JsonDerivedType(typeof(LinkedMessage1Choice.OtherReference),nameof(LinkedMessage1Choice.OtherReference))]
    [JsonDerivedType(typeof(LinkedMessage1Choice.RelatedReference),nameof(LinkedMessage1Choice.RelatedReference))]
    [IsoId("_7Q8FcQgJEeSFYfyUKDXKaw")]
    [DisplayName("Linked Message 1 Choice")]
    public abstract partial record LinkedMessage1Choice_
    {
    }
}
