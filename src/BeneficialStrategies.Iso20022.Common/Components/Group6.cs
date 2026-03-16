// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group6.
/// </summary>
[IsoId("_1WVdpzEyEe6g-ffJsqGiSA")]
[DisplayName("Group6")]
public record Group6
{
    /// <summary>
    /// Group Identification.
    /// </summary>
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    public required IsoMax4AlphaNumericText GroupIdentification { get; init; }

    /// <summary>
    /// Party.
    /// </summary>
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public ValueList<PartyAndCertificate6> Party { get; init; } = [];
}
