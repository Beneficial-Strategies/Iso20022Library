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

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.028.002.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionAllegementNotification to an account owner to advise the account owner that a counterparty has alleged an instruction against the account owner&apos;s account at the account servicer and that the account servicer could not find the corresponding instruction of the account owner.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
///
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account servicer sends a SecuritiesSettlementTransactionAllegementNotification to an account owner to advise the account owner that a counterparty has alleged an instruction against the account owner's account at the account servicer and that the account servicer could not find the corresponding instruction of the account owner.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header."
)]
[IsoId("_VKjf883zEee5nJBZsW8MFQ")]
[DisplayName("Securities Settlement Transaction Allegement Notification 002 V")]
public record SecuritiesSettlementTransactionAllegementNotification002V07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.028.002.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxAllgmtNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.028.002.07";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_VKjgAc3zEee5nJBZsW8MFQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text TransactionIdentification { get; init; }

    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    [IsoId("_VKjgA83zEee5nJBZsW8MFQ")]
    [DisplayName("Settlement Type And Additional Parameters")]
    [IsoXmlTag("SttlmTpAndAddtlParams")]
    public required SettlementTypeAndAdditionalParameters15 SettlementTypeAndAdditionalParameters { get; init; }

    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_VKjgBc3zEee5nJBZsW8MFQ")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public Identification16? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_VKjgB83zEee5nJBZsW8MFQ")]
    [DisplayName("Trade Details")]
    [IsoXmlTag("TradDtls")]
    public required SecuritiesTradeDetails84 TradeDetails { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_VKjgCc3zEee5nJBZsW8MFQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_VKjgC83zEee5nJBZsW8MFQ")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes97? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_VKjgDc3zEee5nJBZsW8MFQ")]
    [DisplayName("Quantity And Account Details")]
    [IsoXmlTag("QtyAndAcctDtls")]
    public required QuantityAndAccount70 QuantityAndAccountDetails { get; init; }

    /// <summary>
    /// Details of the closing of the securities financing transaction.
    /// </summary>
    [IsoId("_VKjgD83zEee5nJBZsW8MFQ")]
    [DisplayName("Securities Financing Details")]
    [IsoXmlTag("SctiesFincgDtls")]
    public SecuritiesFinancingTransactionDetails41? SecuritiesFinancingDetails { get; init; }

    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_VKjgEc3zEee5nJBZsW8MFQ")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public required SettlementDetails153 SettlementParameters { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_VKjgE83zEee5nJBZsW8MFQ")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties64? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_VKjgFc3zEee5nJBZsW8MFQ")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties64? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Specifies cash parties in the framework of a corporate action event.
    /// </summary>
    [IsoId("_VKjgF83zEee5nJBZsW8MFQ")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties32? CashParties { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_VKjgGc3zEee5nJBZsW8MFQ")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection92? SettlementAmount { get; init; }

    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_VKjgG83zEee5nJBZsW8MFQ")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts36? OtherAmounts { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_VKjgHc3zEee5nJBZsW8MFQ")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties31? OtherBusinessParties { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_VKjgH83zEee5nJBZsW8MFQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesSettlementTransactionAllegementNotification002V07Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementTransactionAllegementNotification002V07.
