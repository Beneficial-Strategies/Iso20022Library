// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reference to a message.
    /// </summary>
    [KnownType(typeof(LinkedMessage3Choice.PreviousReference))]
    [KnownType(typeof(LinkedMessage3Choice.OtherReference))]
    [JsonDerivedType(
        typeof(LinkedMessage3Choice.PreviousReference),
        nameof(LinkedMessage3Choice.PreviousReference)
    )]
    [JsonDerivedType(
        typeof(LinkedMessage3Choice.OtherReference),
        nameof(LinkedMessage3Choice.OtherReference)
    )]
    [IsoId("_dqR1QCFeEeW9XJWqfgXIIA")]
    [DisplayName("Linked Message 3 Choice")]
    public abstract record LinkedMessage3Choice_ { }
}
