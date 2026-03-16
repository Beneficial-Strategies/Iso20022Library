// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the amendment.
/// </summary>
[IsoId("_9-Q1snltEeG7BsjMvd1mEw_-687774575")]
[DisplayName("Amendment")]
public record Amendment2
{
    /// <summary>
    /// Contents of the related Undertaking Amendment message.
    /// </summary>
    [IsoId("_9-Z_oXltEeG7BsjMvd1mEw_-922767707")]
    [DisplayName("Undertaking Amendment Message")]
    [IsoXmlTag("UdrtkgAmdmntMsg")]
    public required UndertakingAmendmentMessage1 UndertakingAmendmentMessage { get; init; }

    /// <summary>
    /// Additional information related to the first advising party.
    /// </summary>
    [IsoId("__Ruatz1XEeKWjKfYlNE7jQ")]
    [DisplayName("First Advising Party Additional Information")]
    [IsoXmlTag("FrstAdvsgPtyAddtlInf")]
    public AdvisingPartyAdditionalInformation1? FirstAdvisingPartyAdditionalInformation { get; init; }

    /// <summary>
    /// Additional information related to the second advising party.
    /// </summary>
    [IsoId("_BTNxVz1YEeKWjKfYlNE7jQ")]
    [DisplayName("Second Advising Party Additional Information")]
    [IsoXmlTag("ScndAdvsgPtyAddtlInf")]
    public AdvisingPartyAdditionalInformation1? SecondAdvisingPartyAdditionalInformation { get; init; }

    /// <summary>
    /// Details concerning the confirmation of the proposed amendment.
    /// </summary>
    [IsoId("_9-Z_onltEeG7BsjMvd1mEw_1012422079")]
    [DisplayName("Confirmation Details")]
    [IsoXmlTag("ConfDtls")]
    public UndertakingConfirmation1? ConfirmationDetails { get; init; }

    /// <summary>
    /// Digital signature of the party providing additional undertaking amendment advice details.
    /// </summary>
    [IsoId("_9-Z_o3ltEeG7BsjMvd1mEw_1663412254")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    [MinLength(0)]
    [MaxLength(3)]
    public ValueList<PartyAndSignature2> DigitalSignature { get; init; } = [];
}
