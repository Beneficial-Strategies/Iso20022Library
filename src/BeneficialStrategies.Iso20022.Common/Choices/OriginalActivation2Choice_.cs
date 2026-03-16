// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the activation details which is referenced.
    /// </summary>
    [KnownType(typeof(OriginalActivation2Choice.OriginalDebtorIdentification))]
    [KnownType(typeof(OriginalActivation2Choice.OriginalActivationData))]
    [JsonDerivedType(
        typeof(OriginalActivation2Choice.OriginalDebtorIdentification),
        nameof(OriginalActivation2Choice.OriginalDebtorIdentification)
    )]
    [JsonDerivedType(
        typeof(OriginalActivation2Choice.OriginalActivationData),
        nameof(OriginalActivation2Choice.OriginalActivationData)
    )]
    [IsoId("_UNr4PeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Activation 2 Choice")]
    public abstract record OriginalActivation2Choice_ { }
}
