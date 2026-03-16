// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the advice for the issuance of an undertaking.
/// </summary>
[IsoId("_-AfqUnltEeG7BsjMvd1mEw_27275144")]
[DisplayName("Undertaking Advice")]
public record UndertakingAdvice2
{
    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking.
    /// </summary>
    [IsoId("_-AfqU3ltEeG7BsjMvd1mEw_682292746")]
    [DisplayName("Applicant Reference Number")]
    [IsoXmlTag("ApplcntRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ApplicantReferenceNumber { get; init; }

    /// <summary>
    /// Party obligated to reimburse the issuer.
    /// </summary>
    [IsoId("_6-mNY4ABEeGOn4dfTT_QdQ")]
    [DisplayName("Obligor")]
    [IsoXmlTag("Oblgr")]
    public PartyIdentification43? Obligor { get; init; }

    /// <summary>
    /// Contents of the related UndertakingIssuance message.
    /// </summary>
    [IsoId("_-AfqVHltEeG7BsjMvd1mEw_674201231")]
    [DisplayName("Undertaking Issuance Message")]
    [IsoXmlTag("UdrtkgIssncMsg")]
    public required UndertakingIssuanceMessage UndertakingIssuanceMessage { get; init; }

    /// <summary>
    /// Medium used to issue the original undertaking.
    /// </summary>
    [IsoId("_-ApbUHltEeG7BsjMvd1mEw_-1209989499")]
    [DisplayName("Original Issued Medium")]
    [IsoXmlTag("OrgnlIssdMdm")]
    public PresentationMedium1Code? OriginalIssuedMedium { get; init; }

    /// <summary>
    /// Document or template enclosed in the notification.
    /// </summary>
    [IsoId("_-ApbUXltEeG7BsjMvd1mEw_637726234")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document9> EnclosedFile { get; init; } = [];

    /// <summary>
    /// Additional information related to the undertaking notification.
    /// </summary>
    [IsoId("_-ApbUnltEeG7BsjMvd1mEw_776941520")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
}
