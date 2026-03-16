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
/// This record is an implementation of the acmt.017.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountMandateMaintenanceRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is the initial request message to update an account. This update is only about mandate information.
/// Usage
/// This message should only be used for initiating the maintenance process of mandate information. This update is only about mandate information. The organisation will specify under the Mandate tag the complete information as it should be in the financial institutions records after processing the update request. It is not possible to update the account characteristics or organisation information with this message.
/// It is possible to request to update the mandate information of several accounts, if these accounts must have exactly the same mandates.
/// This message could be sent together with other related documents.
/// </summary>
[Description(
    @"Scope|The AccountMandateMaintenanceRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is the initial request message to update an account. This update is only about mandate information.|Usage|This message should only be used for initiating the maintenance process of mandate information. This update is only about mandate information. The organisation will specify under the Mandate tag the complete information as it should be in the financial institutions records after processing the update request. It is not possible to update the account characteristics or organisation information with this message.|It is possible to request to update the mandate information of several accounts, if these accounts must have exactly the same mandates.|This message could be sent together with other related documents."
)]
[IsoId("_rkXieNE9Ed-BzquC8wXy7w_1808843508")]
[DisplayName("Account Mandate Maintenance Request V")]
public record AccountMandateMaintenanceRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.017.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctMndtMntncReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.017.001.01";

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
    [IsoId("_rkXiedE9Ed-BzquC8wXy7w_-571275315")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References4 References { get; init; }

    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_rkXietE9Ed-BzquC8wXy7w_-1757073896")]
    [DisplayName("Contract Dates")]
    [IsoXmlTag("CtrctDts")]
    public AccountContract2? ContractDates { get; init; }

    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_rkXie9E9Ed-BzquC8wXy7w_-1745991408")]
    [DisplayName("Underlying Master Agreement")]
    [IsoXmlTag("UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_rkhTcNE9Ed-BzquC8wXy7w_-1503372642")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountForAction1 AccountIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_rkhTcdE9Ed-BzquC8wXy7w_627189262")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; }

    /// <summary>
    /// Identification of the organisation requesting the change.
    /// </summary>
    [IsoId("_rkhTctE9Ed-BzquC8wXy7w_1142515469")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification6 OrganisationIdentification { get; init; }

    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_rkhTc9E9Ed-BzquC8wXy7w_176118407")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required OperationMandate1 Mandate { get; init; }

    /// <summary>
    /// Contains additional information related to the message.
    /// </summary>
    [IsoId("_rkhTdNE9Ed-BzquC8wXy7w_-470392981")]
    [DisplayName("Additional Message Information")]
    [IsoXmlTag("AddtlMsgInf")]
    public AdditionalInformation5? AdditionalMessageInformation { get; init; }

    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_rkhTddE9Ed-BzquC8wXy7w_955139164")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature1? DigitalSignature { get; init; }
}

// Since AccountMandateMaintenanceRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountMandateMaintenanceRequestV01.
