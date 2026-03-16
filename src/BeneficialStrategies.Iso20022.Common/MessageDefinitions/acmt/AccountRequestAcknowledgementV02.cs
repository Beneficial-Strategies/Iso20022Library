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
/// This record is an implementation of the acmt.010.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountRequestAcknowledgement message is sent from a financial institution to an organisation. This message is sent in response to a request message from the organisation. It is sent after the request has been validated from an authentication and authorization point of view. The business content has not yet been validated at this stage.
/// </summary>
[Description(
    @"The AccountRequestAcknowledgement message is sent from a financial institution to an organisation. This message is sent in response to a request message from the organisation. It is sent after the request has been validated from an authentication and authorization point of view. The business content has not yet been validated at this stage."
)]
[IsoId("_gDPu8Q1TEeKGXqvMN6jpiw")]
[DisplayName("Account Request Acknowledgement V")]
public record AccountRequestAcknowledgementV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.010.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctReqAck";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.010.001.02";

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
    [IsoId("_gDPu8w1TEeKGXqvMN6jpiw")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References5 References { get; init; }

    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_wBNOMA1YEeKGXqvMN6jpiw")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public OrganisationIdentification8? From { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_gDPu9w1TEeKGXqvMN6jpiw")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountForAction1? AccountIdentification { get; init; }

    /// <summary>
    /// Identifier for an organisation.
    /// </summary>
    [IsoId("_gDPu-w1TEeKGXqvMN6jpiw")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification8 OrganisationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_gDPu_w1TEeKGXqvMN6jpiw")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification5 AccountServicerIdentification { get; init; }

    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_gDPvAw1TEeKGXqvMN6jpiw")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KLrdIA4AEeKGXqvMN6jpiw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since AccountRequestAcknowledgementV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountRequestAcknowledgementV02.
