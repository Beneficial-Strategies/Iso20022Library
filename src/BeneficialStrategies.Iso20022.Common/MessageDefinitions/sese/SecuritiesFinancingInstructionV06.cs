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
/// This record is an implementation of the sese.033.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner sends a SecuritiesFinancingInstruction to a securities financing transaction account servicer to notify the securities financing transaction account servicer of the details of a repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing transaction to allow the account servicer to manage the settlement and follow-up of the opening and closing leg of the transaction.
/// The account owner/servicer relationship may be:
/// - a global custodian which has an account with a local custodian, or
/// - an investment management institution which manage a fund account opened at a custodian, or
/// - a broker which has an account with a custodian, or
/// - a central securities depository participant which has an account with a central securities depository, or
/// - a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or
/// - a central counterparty or a stock exchange or a trade matching utility which need to instruct the settlement of securities financing transactions to a central securities depository or another settlement market infrastructure.
///
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account owner sends a SecuritiesFinancingInstruction to a securities financing transaction account servicer to notify the securities financing transaction account servicer of the details of a repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing transaction to allow the account servicer to manage the settlement and follow-up of the opening and closing leg of the transaction.|The account owner/servicer relationship may be:|- a global custodian which has an account with a local custodian, or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or|- a central counterparty or a stock exchange or a trade matching utility which need to instruct the settlement of securities financing transactions to a central securities depository or another settlement market infrastructure.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header."
)]
[IsoId("_YSMWlwCTEeW_3KiG8SEjHA")]
[DisplayName("Securities Financing Instruction V")]
public record SecuritiesFinancingInstructionV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.033.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.033.001.06";

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
    [IsoId("_YSMWswCTEeW_3KiG8SEjHA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Securities financing transaction identification information, type (repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing) and other parameters.
    /// </summary>
    [IsoId("_YSMWtQCTEeW_3KiG8SEjHA")]
    [DisplayName("Transaction Type And Additional Parameters")]
    [IsoXmlTag("TxTpAndAddtlParams")]
    public required TransactionTypeAndAdditionalParameters9 TransactionTypeAndAdditionalParameters { get; init; }

    /// <summary>
    /// Count of the number of transactions linked.
    /// </summary>
    [IsoId("_YSMWtwCTEeW_3KiG8SEjHA")]
    [DisplayName("Number Counts")]
    [IsoXmlTag("NbCounts")]
    public NumberCount1Choice_? NumberCounts { get; init; }

    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_YSMWuQCTEeW_3KiG8SEjHA")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public Linkages37? Linkages { get; init; }

    /// <summary>
    /// Details of the securities financing deal.
    /// </summary>
    [IsoId("_YSMWuwCTEeW_3KiG8SEjHA")]
    [DisplayName("Trade Details")]
    [IsoXmlTag("TradDtls")]
    public required SecuritiesTradeDetails56 TradeDetails { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_YSMWvQCTEeW_3KiG8SEjHA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_YSMWvwCTEeW_3KiG8SEjHA")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes64? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_YSMWwQCTEeW_3KiG8SEjHA")]
    [DisplayName("Quantity And Account Details")]
    [IsoXmlTag("QtyAndAcctDtls")]
    public required QuantityAndAccount39 QuantityAndAccountDetails { get; init; }

    /// <summary>
    /// Details for the closing of the securities financing transaction.
    /// </summary>
    [IsoId("_YSMWwwCTEeW_3KiG8SEjHA")]
    [DisplayName("Securities Financing Details")]
    [IsoXmlTag("SctiesFincgDtls")]
    public required SecuritiesFinancingTransactionDetails28 SecuritiesFinancingDetails { get; init; }

    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_YSMWxQCTEeW_3KiG8SEjHA")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails97? SettlementParameters { get; init; }

    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_YSMWxwCTEeW_3KiG8SEjHA")]
    [DisplayName("Standing Settlement Instruction Details")]
    [IsoXmlTag("StgSttlmInstrDtls")]
    public StandingSettlementInstruction11? StandingSettlementInstructionDetails { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_YSMWyQCTEeW_3KiG8SEjHA")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties36? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_YSMWywCTEeW_3KiG8SEjHA")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties36? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Cash parties involved in the transaction if different for the securities settlement parties.
    /// </summary>
    [IsoId("_YSMWzQCTEeW_3KiG8SEjHA")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties26? CashParties { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities at the opening of a securities financing transaction.
    /// </summary>
    [IsoId("_YSMWzwCTEeW_3KiG8SEjHA")]
    [DisplayName("Opening Settlement Amount")]
    [IsoXmlTag("OpngSttlmAmt")]
    public AmountAndDirection46? OpeningSettlementAmount { get; init; }

    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_YSMW0QCTEeW_3KiG8SEjHA")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts28? OtherAmounts { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_YSMW0wCTEeW_3KiG8SEjHA")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties27? OtherBusinessParties { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_YSMW1QCTEeW_3KiG8SEjHA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesFinancingInstructionV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesFinancingInstructionV06.
