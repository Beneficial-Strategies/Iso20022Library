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
/// This record is an implementation of the semt.041.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
///
/// An account servicer, such as a custodian, central securities depository or international central securities depository, sends the SecuritiesBalanceTransparencyReport message to provide holdings information for the accounts that it services, to disclose underlying details of holdings on an omnibus account that the sender owns or operates at the receiver. The receiver may also be a custodian, central securities depository, international central securities depository, and the ultimate receiver may be a registrar, transfer agent, fund company, official agent of the reported instrument(s) and/or other parties.
///
/// The SecuritiesBalanceTransparencyReport message provides transparency of holdings through layers of custody chains in a consolidated statement, to allow for an efficient gathering of investor data, which, in turn, may be used to measure marketing effectiveness, validation of compliance with prospectuses and regulatory requirements, and the calculation of trailer fees and other retrocessions.
///
/// USAGE
///
/// The SecuritiesBalanceTransparencyReport message is used to provide aggregated holdings information and a breakdown of holdings information.
///
/// A sender of the SecuritiesBalanceTransparencyReport message will identify its own safekeeping account (for example, an omnibus account in the ledger of the receiver) and holdings information at the level of account(s) for which the sender is the account servicer (that is, in the ledger of the sender). When relevant, the sender will aggregate its holdings information with holdings information of one or more sub levels and sub-sub levels of accounts, that is, with holdings information the sender has received from the owner(s) of the account(s) for which the sender is the account servicer.
///
/// When the receiver of the SecuritiesBalanceTransparencyReport message is also an account servicer, it may, in turn, send a statement back to the sender of the first statement, enriched with data of its own.
/// Ultimately, the statement reaches the relevant fund company, for example, the transfer agent, that may use it for obtaining information about the custodians, distributors and commercial agreement references associated with holdings on an omnibus account in the shareholder register.
/// </summary>
[Description(
    @"SCOPE||An account servicer, such as a custodian, central securities depository or international central securities depository, sends the SecuritiesBalanceTransparencyReport message to provide holdings information for the accounts that it services, to disclose underlying details of holdings on an omnibus account that the sender owns or operates at the receiver. The receiver may also be a custodian, central securities depository, international central securities depository, and the ultimate receiver may be a registrar, transfer agent, fund company, official agent of the reported instrument(s) and/or other parties.||The SecuritiesBalanceTransparencyReport message provides transparency of holdings through layers of custody chains in a consolidated statement, to allow for an efficient gathering of investor data, which, in turn, may be used to measure marketing effectiveness, validation of compliance with prospectuses and regulatory requirements, and the calculation of trailer fees and other retrocessions.||USAGE||The SecuritiesBalanceTransparencyReport message is used to provide aggregated holdings information and a breakdown of holdings information.||A sender of the SecuritiesBalanceTransparencyReport message will identify its own safekeeping account (for example, an omnibus account in the ledger of the receiver) and holdings information at the level of account(s) for which the sender is the account servicer (that is, in the ledger of the sender). When relevant, the sender will aggregate its holdings information with holdings information of one or more sub levels and sub-sub levels of accounts, that is, with holdings information the sender has received from the owner(s) of the account(s) for which the sender is the account servicer. ||When the receiver of the SecuritiesBalanceTransparencyReport message is also an account servicer, it may, in turn, send a statement back to the sender of the first statement, enriched with data of its own.|Ultimately, the statement reaches the relevant fund company, for example, the transfer agent, that may use it for obtaining information about the custodians, distributors and commercial agreement references associated with holdings on an omnibus account in the shareholder register."
)]
[IsoId("_xPhF4Ig7EeO9_8n7Pjtlag")]
[DisplayName("Securities Balance Transparency Report V")]
public record SecuritiesBalanceTransparencyReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.041.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesBalTrnsprncyRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.041.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unique and unambiguous identification of the message. When the report has multiple pages, one message equals one page. Therefore, the MessageIdentification uniquely identifies the page.
    /// </summary>
    [IsoId("_tOXzJYjUEeONZKAAW4pOaQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Identification of the party that is the sender of the message.
    /// </summary>
    [IsoId("_tOXzJojUEeONZKAAW4pOaQ")]
    [DisplayName("Sender Identification")]
    [IsoXmlTag("SndrId")]
    public required PartyIdentification100 SenderIdentification { get; init; }

    /// <summary>
    /// Identification of the party that is the receiver of the message.
    /// </summary>
    [IsoId("_tOXzJ4jUEeONZKAAW4pOaQ")]
    [DisplayName("Receiver Identification")]
    [IsoXmlTag("RcvrId")]
    public PartyIdentification100? ReceiverIdentification { get; init; }

    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_7HiiYIjUEeONZKAAW4pOaQ")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination Pagination { get; init; }

    /// <summary>
    /// Provides general information on the statement.
    /// </summary>
    [IsoId("_tOXzKIjUEeONZKAAW4pOaQ")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement37 StatementGeneralDetails { get; init; }

    /// <summary>
    /// Details of the account, account sub-levels and the holdings.
    /// </summary>
    [IsoId("_tOXzKYjUEeONZKAAW4pOaQ")]
    [DisplayName("Safekeeping Account And Holdings")]
    [IsoXmlTag("SfkpgAcctAndHldgs")]
    public required SafekeepingAccount5 SafekeepingAccountAndHoldings { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_JnQCkVLbEeSGm-QRrvBvYg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesBalanceTransparencyReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesBalanceTransparencyReportV01.
