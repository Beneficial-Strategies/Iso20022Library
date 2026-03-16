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
/// This record is an implementation of the semt.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustodyStatementOfHoldings message is sent by an account servicer to the account owner or the account owner&apos;s designated agent. The account servicer may be a local agent acting on behalf of its global custodian customer, a custodian acting on behalf of an investment management institution or a broker/dealer, a fund administrator or fund intermediary, trustee or registrar, etc.
/// This message reports, at a specified moment in time, the quantity and identification of financial instruments that an account servicer holds for the account owner.
/// This message is used to reconcile the books of the account owner and the account servicer for the specified account or sub-account.
/// This message can also report availability and/or the location of security holdings to facilitate trading and minimise settlement issues. The reporting is per financial instrument, ie, when a financial instrument is held at multiple places of safekeeping, the total holding for all locations can be provided.
/// Usage
/// The CustodyStatementOfHoldings message can be sent:
/// - At a frequency agreed bi-laterally between the Sender and the Receiver
/// - As a response to a request for statement sent by the account owner.
/// This message can reflect all outstanding holding information or may only contain changes since the previously sent statement.
/// The CustodyStatementOfHoldings message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, this message can be used to either specify holdings at
/// - the main account level, or
/// - the sub-account level.
/// This message can be also be used to report where the securities are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.
/// This message must not be used to report audited positions. Audited positions are reported using the AccountingStatementOfHoldings message.
/// Since a SWIFT message as sent is restricted to the maximum input message length, several messages may be needed to accommodate all the information.
/// </summary>
[Description(
    @"Scope|The CustodyStatementOfHoldings message is sent by an account servicer to the account owner or the account owner's designated agent. The account servicer may be a local agent acting on behalf of its global custodian customer, a custodian acting on behalf of an investment management institution or a broker/dealer, a fund administrator or fund intermediary, trustee or registrar, etc.|This message reports, at a specified moment in time, the quantity and identification of financial instruments that an account servicer holds for the account owner.|This message is used to reconcile the books of the account owner and the account servicer for the specified account or sub-account.|This message can also report availability and/or the location of security holdings to facilitate trading and minimise settlement issues. The reporting is per financial instrument, ie, when a financial instrument is held at multiple places of safekeeping, the total holding for all locations can be provided.|Usage|The CustodyStatementOfHoldings message can be sent:|- At a frequency agreed bi-laterally between the Sender and the Receiver|- As a response to a request for statement sent by the account owner.|This message can reflect all outstanding holding information or may only contain changes since the previously sent statement.|The CustodyStatementOfHoldings message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, this message can be used to either specify holdings at|- the main account level, or|- the sub-account level.|This message can be also be used to report where the securities are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.|This message must not be used to report audited positions. Audited positions are reported using the AccountingStatementOfHoldings message.|Since a SWIFT message as sent is restricted to the maximum input message length, several messages may be needed to accommodate all the information."
)]
[IsoId("_MWx4gNFSEd-BzquC8wXy7w_650597621")]
[DisplayName("Custody Statement Of Holdings")]
public record CustodyStatementOfHoldings : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.002.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "semt.002.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.002.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MW7pgNFSEd-BzquC8wXy7w_1818905401")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MW7pgdFSEd-BzquC8wXy7w_1810591867")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }

    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_MW7pgtFSEd-BzquC8wXy7w_-1884866352")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// General information related to the custody statement of holdings.
    /// </summary>
    [IsoId("_MW7pg9FSEd-BzquC8wXy7w_500773271")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement3 StatementGeneralDetails { get; init; }

    /// <summary>
    /// The safekeeping or investment account.
    /// </summary>
    [IsoId("_MW7phNFSEd-BzquC8wXy7w_-1316963479")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required SafekeepingAccount1 AccountDetails { get; init; }

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_MW7phdFSEd-BzquC8wXy7w_-2003208951")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public AggregateBalanceInformation1? BalanceForAccount { get; init; }

    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_MW7phtFSEd-BzquC8wXy7w_1776832052")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccountIdentification1? SubAccountDetails { get; init; }

    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_MW7ph9FSEd-BzquC8wXy7w_1111399368")]
    [DisplayName("Total Values")]
    [IsoXmlTag("TtlVals")]
    public TotalValueInPageAndStatement? TotalValues { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_MXEzcNFSEd-BzquC8wXy7w_-143061138")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since CustodyStatementOfHoldingsDocument is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CustodyStatementOfHoldings.
