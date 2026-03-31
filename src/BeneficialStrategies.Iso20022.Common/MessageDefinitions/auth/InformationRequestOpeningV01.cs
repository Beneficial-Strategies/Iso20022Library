// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This message is sent by the authorities (police, customs, tax authorities, enforcement authorities) to a financial institution to request account and other banking and financial information. Requested information can relate to accounts, their signatories and beneficiaries and co-owners as well as movements plus positions on these accounts.
///
/// Requests are underpinned by specific legal texts.
/// </summary>
[Description(
    @"This message is sent by the authorities (police, customs, tax authorities, enforcement authorities) to a financial institution to request account and other banking and financial information. Requested information can relate to accounts, their signatories and beneficiaries and co-owners as well as movements plus positions on these accounts.||Requests are underpinned by specific legal texts."
)]
[IsoId("_ixVXwztbEeGg8InIPRjKog")]
[DisplayName("Information Request Opening V")]
public record InformationRequestOpeningV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.001.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InfReqOpng";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.001.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unique identification for the specific investigation as known by the requesting party.
    /// </summary>
    [IsoId("_MvVY3zteEeGg8InIPRjKog")]
    [DisplayName("Investigation Identification")]
    [IsoXmlTag("InvstgtnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InvestigationIdentification { get; init; }

    /// <summary>
    /// Provides details on the legal basis of the request.
    /// </summary>
    [IsoId("_Gh6K-0J9EeGuetKibuqsKw")]
    [DisplayName("Legal Mandate Basis")]
    [IsoXmlTag("LglMndtBsis")]
    public required LegalMandate1 LegalMandateBasis { get; init; }

    /// <summary>
    /// Specifies the confidentiality status of the investigation.
    /// </summary>
    [IsoId("_UdsRrz2NEeGG64_ngBNdUg")]
    [DisplayName("Confidentiality Status")]
    [IsoXmlTag("CnfdtltySts")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ConfidentialityStatus { get; init; }

    /// <summary>
    /// Specifies the date by when the financial institutiion needs to provide a response.
    /// </summary>
    [IsoId("_6Pv_70cVEeGlWcsEChp7QA")]
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    public DueDate1? DueDate { get; init; }

    /// <summary>
    /// Specifies the dates between which period the authority requests that the financial institution provides a response to the information request.
    /// </summary>
    [IsoId("_VWAzXzwlEeGUCuI3g5RrVg")]
    [DisplayName("Investigation Period")]
    [IsoXmlTag("InvstgtnPrd")]
    public required DateOrDateTimePeriodChoice_ InvestigationPeriod { get; init; }

    /// <summary>
    /// Specifies the the search criteria for the financial institution to perform the search on. The search criteria can be an account, a customer identification or a payment instrument type.
    /// </summary>
    [IsoId("_qpVADzthEeGg8InIPRjKog")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public required SearchCriteria1Choice_ SearchCriteria { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_O_AtrzwoEeGUCuI3g5RrVg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since InformationRequestOpeningV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InformationRequestOpeningV01.
