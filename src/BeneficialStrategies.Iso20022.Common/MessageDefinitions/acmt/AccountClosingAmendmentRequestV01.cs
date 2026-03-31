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
/// This record is an implementation of the acmt.020.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountClosingAmendmentRequest message is sent from an organisation to a financial institution as part of the account closing process. It is sent in response to a request from the financial institution to send additional information.
/// Usage
/// This message may only be sent in response to a request from the financial institution to send additional information.
/// It could be sent together with other related documents.
/// </summary>
[Description(
    @"Scope|The AccountClosingAmendmentRequest message is sent from an organisation to a financial institution as part of the account closing process. It is sent in response to a request from the financial institution to send additional information.|Usage|This message may only be sent in response to a request from the financial institution to send additional information.|It could be sent together with other related documents."
)]
[IsoId("_nlQomNE9Ed-BzquC8wXy7w_1266077822")]
[DisplayName("Account Closing Amendment Request V")]
public record AccountClosingAmendmentRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.020.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctClsgAmdmntReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.020.001.01";

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
    [IsoId("_nlQomdE9Ed-BzquC8wXy7w_-908345623")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References4 References { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_nlQomtE9Ed-BzquC8wXy7w_-1865223147")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountForAction1 AccountIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_nlaZkNE9Ed-BzquC8wXy7w_-814283343")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; }

    /// <summary>
    /// Identification of the organisation requesting the change.
    /// </summary>
    [IsoId("_nlaZkdE9Ed-BzquC8wXy7w_1006271356")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification6 OrganisationIdentification { get; init; }

    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_nlaZktE9Ed-BzquC8wXy7w_-53663536")]
    [DisplayName("Contract Dates")]
    [IsoXmlTag("CtrctDts")]
    public AccountContract4? ContractDates { get; init; }

    /// <summary>
    /// Identification of the account to which the remaining positive balance of the account to be closed must be transferred or account from which funds can be moved to the account to be closed and which balance is negative. This account must be held in the same financial institution as the account to be closed if the transfer account is used to compensate a negative balance. For a positive balance to be transferred, an account in another financial institution might be used. In that case the account servicer is mandatory.
    /// </summary>
    [IsoId("_nlaZk9E9Ed-BzquC8wXy7w_-114881708")]
    [DisplayName("Balance Transfer Account")]
    [IsoXmlTag("BalTrfAcct")]
    public AccountForAction1? BalanceTransferAccount { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme, that is the servicer of the transfer account.
    /// </summary>
    [IsoId("_nlaZlNE9Ed-BzquC8wXy7w_258218512")]
    [DisplayName("Transfer Account Servicer Identification")]
    [IsoXmlTag("TrfAcctSvcrId")]
    public BranchAndFinancialInstitutionIdentification4? TransferAccountServicerIdentification { get; init; }

    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_nlaZldE9Ed-BzquC8wXy7w_-944215031")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature1? DigitalSignature { get; init; }
}

// Since AccountClosingAmendmentRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountClosingAmendmentRequestV01.
