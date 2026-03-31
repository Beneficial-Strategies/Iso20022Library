// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contents of the related UndertakingIssuance message or of the related issuance document.
/// </summary>
[IsoId("_98U8CHltEeG7BsjMvd1mEw_1927881342")]
[DisplayName("Undertaking Issuance Message")]
public record UndertakingIssuanceMessage
{
    /// <summary>
    /// Independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be collected on the presentation of documents that comply with its terms and conditions.
    /// </summary>
    [IsoId("_98eF8HltEeG7BsjMvd1mEw_-650001851")]
    [DisplayName("Undertaking Details")]
    [IsoXmlTag("UdrtkgDtls")]
    public required Undertaking3 UndertakingDetails { get; init; }

    /// <summary>
    /// Digital signature of the issued undertaking.
    /// </summary>
    [IsoId("_98eF8XltEeG7BsjMvd1mEw_410132243")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
}
