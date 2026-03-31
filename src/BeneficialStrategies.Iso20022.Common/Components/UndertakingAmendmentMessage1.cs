// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contents of an Undertaking Amendment message.
/// </summary>
[IsoId("_98eF8nltEeG7BsjMvd1mEw_1389753684")]
[DisplayName("Undertaking Amendment Message")]
public record UndertakingAmendmentMessage1
{
    /// <summary>
    /// Details related to the proposed undertaking amendment.
    /// </summary>
    [IsoId("_98eF83ltEeG7BsjMvd1mEw_214562659")]
    [DisplayName("Undertaking Amendment Details")]
    [IsoXmlTag("UdrtkgAmdmntDtls")]
    public required Amendment1 UndertakingAmendmentDetails { get; init; }

    /// <summary>
    /// Digital signature of the proposed amendment.
    /// </summary>
    [IsoId("_98eF9HltEeG7BsjMvd1mEw_1737562986")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
}
