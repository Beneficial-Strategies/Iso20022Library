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
/// This record is an implementation of the acmt.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountAdditionalInformationRequest message is sent from a financial institution to an organisation as part of maintenance process. This message is sent in response to a request message from the organisation, if the business content is valid, but additional information is required.
/// Usage
/// This message should only be sent if additional information is required as part of the account maintenance process.
/// </summary>
[Description(
    @"Scope|The AccountAdditionalInformationRequest message is sent from a financial institution to an organisation as part of maintenance process. This message is sent in response to a request message from the organisation, if the business content is valid, but additional information is required.|Usage|This message should only be sent if additional information is required as part of the account maintenance process."
)]
[IsoId("_mso-iNE9Ed-BzquC8wXy7w_-37995631")]
[DisplayName("Account Additional Information Request V")]
public record AccountAdditionalInformationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.012.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctAddtlInfReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.012.001.01";

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
    [IsoId("_mso-idE9Ed-BzquC8wXy7w_1354481909")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References3 References { get; init; }

    /// <summary>
    /// Identifier for an organisation.
    /// </summary>
    [IsoId("_msyIcNE9Ed-BzquC8wXy7w_844276535")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification6 OrganisationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_msyIcdE9Ed-BzquC8wXy7w_-1890306852")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_msyIctE9Ed-BzquC8wXy7w_-672125053")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountForAction1 AccountIdentification { get; init; }

    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_msyIc9E9Ed-BzquC8wXy7w_-516297795")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature1? DigitalSignature { get; init; }
}

// Since AccountAdditionalInformationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountAdditionalInformationRequestV01.
