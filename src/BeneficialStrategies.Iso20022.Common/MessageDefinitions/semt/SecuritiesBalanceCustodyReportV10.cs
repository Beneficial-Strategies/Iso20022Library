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
/// This record is an implementation of the semt.002.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesBalanceCustodyReport to an account owner to provide, at a moment in time, the quantity and identification of the financial instruments that the account servicer holds for the account owner.
///
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants, or
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer, or
/// - a transfer agent acting on behalf of a fund manager or an account owner&apos;s designated agent.
///
/// Usage
/// The message can also include availability and the location of holdings to facilitate trading and minimise settlement issues. The message reports all information per financial instrument, that is, when a financial instrument is held at multiple places of safekeeping, the total holdings for all locations can be provided.
/// The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner. The message may be provided on a trade date, contractual or settlement date basis.
/// There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.
///
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account servicer sends a SecuritiesBalanceCustodyReport to an account owner to provide, at a moment in time, the quantity and identification of the financial instruments that the account servicer holds for the account owner.||The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants, or|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer, or|- a transfer agent acting on behalf of a fund manager or an account owner's designated agent.||Usage|The message can also include availability and the location of holdings to facilitate trading and minimise settlement issues. The message reports all information per financial instrument, that is, when a financial instrument is held at multiple places of safekeeping, the total holdings for all locations can be provided. |The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner. The message may be provided on a trade date, contractual or settlement date basis. |There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.||The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header."
)]
[IsoId("_cO51odB_EeiO-eodGv5iKQ")]
[DisplayName("Securities Balance Custody Report V")]
public record SecuritiesBalanceCustodyReportV10 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.002.001.10";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesBalCtdyRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.002.001.10";

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
    [IsoId("_cO51q9B_EeiO-eodGv5iKQ")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; }

    /// <summary>
    /// Provides general information on the report.
    /// </summary>
    [IsoId("_cO51rdB_EeiO-eodGv5iKQ")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement73 StatementGeneralDetails { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_cO51r9B_EeiO-eodGv5iKQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_cO51sdB_EeiO-eodGv5iKQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification136? AccountServicer { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_cO51s9B_EeiO-eodGv5iKQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount26 SafekeepingAccount { get; init; }

    /// <summary>
    /// Information about the party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_cO51tdB_EeiO-eodGv5iKQ")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary44> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_cO51t9B_EeiO-eodGv5iKQ")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public AggregateBalanceInformation35? BalanceForAccount { get; init; }

    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_cO51udB_EeiO-eodGv5iKQ")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccountIdentification55? SubAccountDetails { get; init; }

    /// <summary>
    /// Total valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_cO51u9B_EeiO-eodGv5iKQ")]
    [DisplayName("Account Base Currency Total Amounts")]
    [IsoXmlTag("AcctBaseCcyTtlAmts")]
    public TotalValueInPageAndStatement1? AccountBaseCurrencyTotalAmounts { get; init; }
}

// Since SecuritiesBalanceCustodyReportV10Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesBalanceCustodyReportV10.
