// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reference to a message.
    /// </summary>
    [KnownType(typeof(LinkedMessage4Choice.PreviousReference))]
    [KnownType(typeof(LinkedMessage4Choice.OtherReference))]
    [JsonDerivedType(
        typeof(LinkedMessage4Choice.PreviousReference),
        nameof(LinkedMessage4Choice.PreviousReference)
    )]
    [JsonDerivedType(
        typeof(LinkedMessage4Choice.OtherReference),
        nameof(LinkedMessage4Choice.OtherReference)
    )]
    [IsoId("_4qagUaDjEeahP9OZs6K4wg")]
    [DisplayName("Linked Message 4 Choice")]
    public abstract record LinkedMessage4Choice_ { }
}
