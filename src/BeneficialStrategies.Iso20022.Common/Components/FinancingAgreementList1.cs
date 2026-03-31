// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines a list of party management registration and guarantee requests.
/// </summary>
[IsoId("_OTgzMTk1-AOSNFX-8224490")]
[DisplayName("Financing Agreement List")]
public record FinancingAgreementList1
{
    /// <summary>
    /// Identification assigned to unambiguously identify the agreement list.
    /// </summary>
    [IsoId("_OTgzMzQ4-AOSNFX-8224501")]
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identifier { get; init; }

    /// <summary>
    /// Creation date of this list.
    /// </summary>
    [IsoId("_OTgzMzQ5-AOSNFX-8224501")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; }

    /// <summary>
    /// Reference to related document.
    /// </summary>
    [IsoId("_OTgzMzUw-AOSNFX-8224501")]
    [DisplayName("Related Document")]
    [IsoXmlTag("RltdDoc")]
    public ValueList<QualifiedDocumentInformation1> RelatedDocument { get; init; } = [];

    /// <summary>
    /// Requestor of the agreement(s).
    /// </summary>
    [IsoId("_OTgzMzUx-AOSNFX-8224501")]
    [DisplayName("Agreement Requestor")]
    [IsoXmlTag("AgrmtRqstr")]
    public required QualifiedPartyIdentification1 AgreementRequestor { get; init; }

    /// <summary>
    /// Party the agreement(s) are (to be) made with.
    /// </summary>
    [IsoId("_OTgzMzUy-AOSNFX-8224501")]
    [DisplayName("Agreement Responder")]
    [IsoXmlTag("AgrmtRspndr")]
    public required QualifiedPartyIdentification1 AgreementResponder { get; init; }

    /// <summary>
    /// Applicant of the guarantee.
    /// </summary>
    [IsoId("_OTgzMzUz-AOSNFX-8224501")]
    [DisplayName("Guarantee Applicant")]
    [IsoXmlTag("GrntApplcnt")]
    public required QualifiedPartyIdentification1 GuaranteeApplicant { get; init; }

    /// <summary>
    /// Beneficiary of the guarantee.
    /// </summary>
    [IsoId("_OTgzMzUZ-AOSNFX-8224501")]
    [DisplayName("Guarantee Beneficiary")]
    [IsoXmlTag("GrntNbfcry")]
    public required QualifiedPartyIdentification1 GuaranteeBeneficiary { get; init; }

    /// <summary>
    /// Party that issues the guarantee.
    /// </summary>
    [IsoId("_OTgzMzU0-AOSNFX-8224501")]
    [DisplayName("Guarantee Issuer")]
    [IsoXmlTag("GrntIssr")]
    public required QualifiedPartyIdentification1 GuaranteeIssuer { get; init; }

    /// <summary>
    /// Party or parties to notify and to acknowledge the agreement.
    /// </summary>
    [IsoId("_OTgzMzU1-AOSNFX-8224501")]
    [DisplayName("Notification Information")]
    [IsoXmlTag("NtfctnInf")]
    public ValueList<FinancingNotificationParties1> NotificationInformation { get; init; } = [];

    /// <summary>
    /// List of agreement items.
    /// </summary>
    [IsoId("_OTgzMzU3-AOSNFX-8224501")]
    [DisplayName("Item")]
    [IsoXmlTag("Itm")]
    public ValueList<FinancingAgreementItem1> Item { get; init; } = [];

    // ID for the above is _OTgzMzU3-AOSNFX-8224501

    /// <summary>
    /// Number of individual items contained in the list.
    /// </summary>
    [IsoId("_OTgzMzU4-AOSNFX-8224501")]
    [DisplayName("Item Count")]
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText ItemCount { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the list, irrespective of currencies.
    /// </summary>
    [IsoId("_OTgzMzU5-AOSNFX-8224501")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Additional proprietary formal information concerning the list.
    /// </summary>
    [IsoId("_OTgzMzYw-AOSNFX-8224501")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000, MinimumLength = 1)]
    public IsoMax2000Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Validation status of the list.
    /// </summary>
    [IsoId("_OTgzMzYx-AOSNFX-8224501")]
    [DisplayName("Validation Status Information")]
    [IsoXmlTag("VldtnStsInf")]
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; }
}
