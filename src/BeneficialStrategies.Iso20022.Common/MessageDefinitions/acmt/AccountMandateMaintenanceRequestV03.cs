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
/// This record is an implementation of the acmt.017.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountMandateMaintenanceRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is the initial request message to update one or several accounts. Usage: this update is only about mandate information.
/// If modification codes are not used: the organisation will specify under the “Mandate” and “Group” tags the complete information as it should be in the financial institution’s records after processing the update request.
/// If modification codes are used (in that case, they must be used everywhere): the organisation will specify under the “Mandate” and “Group” tags which elements must be added, deleted, modified, or if they are unchanged.
/// It is not possible to update the account characteristics or organisation information with this message.
/// </summary>
[Description(
    @"The AccountMandateMaintenanceRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is the initial request message to update one or several accounts. Usage: this update is only about mandate information. |If modification codes are not used: the organisation will specify under the “Mandate” and “Group” tags the complete information as it should be in the financial institution’s records after processing the update request. |If modification codes are used (in that case, they must be used everywhere): the organisation will specify under the “Mandate” and “Group” tags which elements must be added, deleted, modified, or if they are unchanged.|It is not possible to update the account characteristics or organisation information with this message."
)]
[IsoId("_bf9RAW2PEei3KuUgpx7Xcw")]
[DisplayName("Account Mandate Maintenance Request V")]
public record AccountMandateMaintenanceRequestV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.017.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctMndtMntncReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.017.001.03";

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
    [IsoId("_bf9RA22PEei3KuUgpx7Xcw")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References4 References { get; init; }

    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_bf9RBW2PEei3KuUgpx7Xcw")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public OrganisationIdentification29? From { get; init; }

    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_bf9RB22PEei3KuUgpx7Xcw")]
    [DisplayName("Contract Dates")]
    [IsoXmlTag("CtrctDts")]
    public AccountContract2? ContractDates { get; init; }

    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_bf9RCW2PEei3KuUgpx7Xcw")]
    [DisplayName("Underlying Master Agreement")]
    [IsoXmlTag("UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_bf9RC22PEei3KuUgpx7Xcw")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountForAction1 AccountIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_bf9RDW2PEei3KuUgpx7Xcw")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; init; }

    /// <summary>
    /// Identification of the organisation requesting the change.
    /// </summary>
    [IsoId("_bf9RD22PEei3KuUgpx7Xcw")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required Organisation34 OrganisationIdentification { get; init; }

    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_bf9REW2PEei3KuUgpx7Xcw")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required OperationMandate5 Mandate { get; init; }

    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    [IsoId("_bf9RE22PEei3KuUgpx7Xcw")]
    [DisplayName("Group")]
    [IsoXmlTag("Grp")]
    public Group3? Group { get; init; }

    /// <summary>
    /// Contains additional information related to the message.
    /// </summary>
    [IsoId("_bf9RFW2PEei3KuUgpx7Xcw")]
    [DisplayName("Additional Message Information")]
    [IsoXmlTag("AddtlMsgInf")]
    public AdditionalInformation5? AdditionalMessageInformation { get; init; }

    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_bf9RF22PEei3KuUgpx7Xcw")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature3? DigitalSignature { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bf9RGW2PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since AccountMandateMaintenanceRequestV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountMandateMaintenanceRequestV03.
