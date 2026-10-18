// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPartyAndSignature4"/>
[IsoId("_w1V-sTEyEe6g-ffJsqGiSA")]
[Description(@"Entity involved in an activity.")]
[DisplayName("Party And Signature4")]
public partial record PartyAndSignature4
{
    /// <inheritdoc cref="IPartyAndSignature4.Party"/>
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification272 Party { get; init; }

    /// <inheritdoc cref="IPartyAndSignature4.Signature"/>
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public required SkipPayload Signature { get; init; }
}
