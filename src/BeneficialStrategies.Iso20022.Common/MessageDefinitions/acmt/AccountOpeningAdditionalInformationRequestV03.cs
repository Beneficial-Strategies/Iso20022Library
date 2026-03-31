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

namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.009.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountOpeningAdditionalInformationRequest message is sent from a financial institution to an organisation as part of the account opening process. This message is sent in response to an opening request message from the organisation, if the business content is valid, but additional information is required.
/// </summary>
[Description(
    @"The AccountOpeningAdditionalInformationRequest message is sent from a financial institution to an organisation as part of the account opening process. This message is sent in response to an opening request message from the organisation, if the business content is valid, but additional information is required."
)]
[IsoId("_bfzgNW2PEei3KuUgpx7Xcw")]
[DisplayName("Account Opening Additional Information Request V")]
public record AccountOpeningAdditionalInformationRequestV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.009.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngAddtlInfReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.009.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_bfzgN22PEei3KuUgpx7Xcw")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References3 References { get; init; }

    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_bfzgOW2PEei3KuUgpx7Xcw")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public OrganisationIdentification29? From { get; init; }

    /// <summary>
    /// Identification of the organisation.
    /// </summary>
    [IsoId("_bfzgO22PEei3KuUgpx7Xcw")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification29 OrganisationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_bfzgPW2PEei3KuUgpx7Xcw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CustomerAccount4 Account { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_bfzgP22PEei3KuUgpx7Xcw")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; init; }

    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_bfzgQW2PEei3KuUgpx7Xcw")]
    [DisplayName("Underlying Master Agreement")]
    [IsoXmlTag("UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }

    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_bfzgQ22PEei3KuUgpx7Xcw")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature3? DigitalSignature { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bfzgRW2PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since AccountOpeningAdditionalInformationRequestV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountOpeningAdditionalInformationRequestV03.
