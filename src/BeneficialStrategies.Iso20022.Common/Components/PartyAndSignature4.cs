// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_w1V-sTEyEe6g-ffJsqGiSA")]
[Description(@"Entity involved in an activity.")]
[DisplayName("Party And Signature4")]
public record PartyAndSignature4
{
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification272 Party { get; init; }

    /// <summary>
    /// Signature of a party.
    /// </summary>
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public required SkipPayload Signature { get; init; }
}
