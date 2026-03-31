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

namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.022.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by the Market Infrastructure to the CSD to advise of the history of all the statuses, modifications, replacement and cancellation of a specific transaction during its whole life cycle when the instructing party is a direct participant to the Settlement Infrastructure.
///
/// Usage
/// The message may also be used to:
/// - re-send a message sent by the market infrastructure to the direct participant,
/// - provide a third party with a copy of a message being sent by the market infrastructure for information,
/// - re-send to a third party a copy of a message being sent by the market infrastructure for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|This message is sent by the Market Infrastructure to the CSD to advise of the history of all the statuses, modifications, replacement and cancellation of a specific transaction during its whole life cycle when the instructing party is a direct participant to the Settlement Infrastructure.||Usage|The message may also be used to: |- re-send a message sent by the market infrastructure to the direct participant,|- provide a third party with a copy of a message being sent by the market infrastructure for information,|- re-send to a third party a copy of a message being sent by the market infrastructure for information|using the relevant elements in the Business Application Header."
)]
[IsoId("_YSWG-wCTEeW_3KiG8SEjHA")]
[DisplayName("Securities Settlement Transaction Audit Trail Report V")]
public record SecuritiesSettlementTransactionAuditTrailReportV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.022.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxAudtTrlRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.022.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_YSWHAQCTEeW_3KiG8SEjHA")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination Pagination { get; init; }

    /// <summary>
    /// Identification of the SecuritiesStatusQuery message sent to request this report.
    /// </summary>
    [IsoId("_YSWHAwCTEeW_3KiG8SEjHA")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    public Identification14? QueryReference { get; init; }

    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_YSWHBQCTEeW_3KiG8SEjHA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentifications29? TransactionIdentification { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_YSWHBwCTEeW_3KiG8SEjHA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount24 SafekeepingAccount { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_YSWHCQCTEeW_3KiG8SEjHA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification98? AccountOwner { get; init; }

    /// <summary>
    ///  Provides the history of status and reasons for a pending, posted or cancelled transaction.
    /// </summary>
    [IsoId("_YSWHCwCTEeW_3KiG8SEjHA")]
    [DisplayName("Status Trail")]
    [IsoXmlTag("StsTrl")]
    public StatusTrail6? StatusTrail { get; init; }
}

// Since SecuritiesSettlementTransactionAuditTrailReportV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementTransactionAuditTrailReportV03.
