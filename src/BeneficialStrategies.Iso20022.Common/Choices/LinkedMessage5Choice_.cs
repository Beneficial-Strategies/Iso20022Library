// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reference to a message.
    /// </summary>
    [KnownType(typeof(LinkedMessage5Choice.PreviousReference))]
    [KnownType(typeof(LinkedMessage5Choice.OtherReference))]
    [JsonDerivedType(
        typeof(LinkedMessage5Choice.PreviousReference),
        nameof(LinkedMessage5Choice.PreviousReference)
    )]
    [JsonDerivedType(
        typeof(LinkedMessage5Choice.OtherReference),
        nameof(LinkedMessage5Choice.OtherReference)
    )]
    [IsoId("_rFVAAZTPEemqYPWMBuVawg")]
    [DisplayName("Linked Message 5 Choice")]
    public abstract record LinkedMessage5Choice_ { }
}
