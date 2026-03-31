// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party And Signature4.
/// </summary>
[IsoId("_w1V-sTEyEe6g-ffJsqGiSA")]
[DisplayName("Party And Signature4")]
public record PartyAndSignature4
{
    /// <summary>
    /// Party.
    /// </summary>
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification272 Party { get; init; }

    /// <summary>
    /// Signature.
    /// </summary>
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public required SkipPayload Signature { get; init; }
}
