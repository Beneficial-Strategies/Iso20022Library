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
/// This record is an implementation of the acmt.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountRequestRejection message is sent from a financial institution to an organisation. This message is sent in response to a request message from the organisation, if the business content is not valid.
/// Usage.
/// </summary>
[Description(
    @"Scope|The AccountRequestRejection message is sent from a financial institution to an organisation. This message is sent in response to a request message from the organisation, if the business content is not valid.|Usage."
)]
[IsoId("_woeVgNE9Ed-BzquC8wXy7w_-218865244")]
[DisplayName("Account Request Rejection V")]
public record AccountRequestRejectionV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.011.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctReqRjctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.011.001.01";

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
    [IsoId("_woeVgdE9Ed-BzquC8wXy7w_1279035715")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References6 References { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_woeVgtE9Ed-BzquC8wXy7w_1907806637")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_woeVg9E9Ed-BzquC8wXy7w_-730305383")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountForAction1? AccountIdentification { get; init; }

    /// <summary>
    /// Identifier for an organisation.
    /// </summary>
    [IsoId("_woeVhNE9Ed-BzquC8wXy7w_1969662038")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification6 OrganisationIdentification { get; init; }

    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_woeVhdE9Ed-BzquC8wXy7w_2030179826")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature1? DigitalSignature { get; init; }
}

// Since AccountRequestRejectionV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountRequestRejectionV01.
