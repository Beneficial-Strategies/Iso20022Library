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
/// This record is an implementation of the semt.018.002.12 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// SecuritiesTransactionPendingReport is sent by an account servicer to an account owner to provide, as at a specified time, the details of pending increases and decreases of holdings, for all or selected securities in a specified safekeeping account, for all or selected reasons why the transaction is pending.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of its participants
/// - an agent (sub-custodian) acting on behalf of its global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
///
/// Usage
/// The statement may also include future settlement or forward transactions which have become binding on the account owner.
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|SecuritiesTransactionPendingReport is sent by an account servicer to an account owner to provide, as at a specified time, the details of pending increases and decreases of holdings, for all or selected securities in a specified safekeeping account, for all or selected reasons why the transaction is pending. |The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of its participants|- an agent (sub-custodian) acting on behalf of its global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The statement may also include future settlement or forward transactions which have become binding on the account owner.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header."
)]
[IsoId("_waVeAyAeEeuyDZ-ukt4YRg")]
[DisplayName("Securities Transaction Pending Report 002 V")]
public record SecuritiesTransactionPendingReport002V12 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.018.002.12";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTxPdgRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.018.002.12";

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
    [IsoId("_waVeByAeEeuyDZ-ukt4YRg")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; }

    /// <summary>
    /// Provides general information to the report.
    /// </summary>
    [IsoId("_waVeCSAeEeuyDZ-ukt4YRg")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement70 StatementGeneralDetails { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_waVeCyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification156? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_waVeDSAeEeuyDZ-ukt4YRg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount30 SafekeepingAccount { get; init; }

    /// <summary>
    /// Status information.
    /// </summary>
    [IsoId("_waVeDyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public StatusAndReason43? Status { get; init; }

    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    [IsoId("_waVeESAeEeuyDZ-ukt4YRg")]
    [DisplayName("Transactions")]
    [IsoXmlTag("Txs")]
    public Transaction118? Transactions { get; init; }
}

// Since SecuritiesTransactionPendingReport002V12Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTransactionPendingReport002V12.
