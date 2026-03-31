// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reference to a message.
    /// </summary>
    [KnownType(typeof(LinkedMessage2Choice.PreviousReference))]
    [KnownType(typeof(LinkedMessage2Choice.OtherReference))]
    [JsonDerivedType(
        typeof(LinkedMessage2Choice.PreviousReference),
        nameof(LinkedMessage2Choice.PreviousReference)
    )]
    [JsonDerivedType(
        typeof(LinkedMessage2Choice.OtherReference),
        nameof(LinkedMessage2Choice.OtherReference)
    )]
    [IsoId("_uZ2ecQguEeSy_NqeitQG4Q")]
    [DisplayName("Linked Message 2 Choice")]
    public abstract record LinkedMessage2Choice_ { }
}
