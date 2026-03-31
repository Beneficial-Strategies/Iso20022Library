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
/// This record is an implementation of the sese.023.001.11 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner sends a SecuritiesSettlementTransactionInstruction to an account servicer to instruct the receipt or delivery of financial instruments with or without payment, physically or by book-entry.
/// The account owner/servicer relationship may be:
/// - a global custodian which has an account with a local custodian, or
/// - an investment management institution which manages a fund account opened at a custodian, or
/// - a broker which has an account with a custodian, or
/// - a central securities depository participant which has an account with a central securities depository, or
/// - a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or
/// - a central counterparty or a stock exchange or a trade matching utility which need to instruct the settlement of transactions to a central securities depository or another settlement market infrastructure.
///
/// Usage
/// The instruction may be linked to other settlement instructions, for example, for a turnaround or back-to-back, or other transactions, for example, foreign exchange deal, using the linkage functionality.
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account owner sends a SecuritiesSettlementTransactionInstruction to an account servicer to instruct the receipt or delivery of financial instruments with or without payment, physically or by book-entry.|The account owner/servicer relationship may be:|- a global custodian which has an account with a local custodian, or|- an investment management institution which manages a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or|- a central counterparty or a stock exchange or a trade matching utility which need to instruct the settlement of transactions to a central securities depository or another settlement market infrastructure.||Usage|The instruction may be linked to other settlement instructions, for example, for a turnaround or back-to-back, or other transactions, for example, foreign exchange deal, using the linkage functionality.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header."
)]
[IsoId("__aULESgcEey2k_sfZmJz4g")]
[DisplayName("Securities Settlement Transaction Instruction V")]
public record SecuritiesSettlementTransactionInstructionV11 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.023.001.11";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.023.001.11";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unambiguous identification of the transaction as known by the instructing party.
    /// </summary>
    [IsoId("__aULPygcEey2k_sfZmJz4g")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    [IsoId("__aULQSgcEey2k_sfZmJz4g")]
    [DisplayName("Settlement Type And Additional Parameters")]
    [IsoXmlTag("SttlmTpAndAddtlParams")]
    public required SettlementTypeAndAdditionalParameters21 SettlementTypeAndAdditionalParameters { get; init; }

    /// <summary>
    /// Count of the number of transactions linked.
    /// </summary>
    [IsoId("__aULQygcEey2k_sfZmJz4g")]
    [DisplayName("Number Counts")]
    [IsoXmlTag("NbCounts")]
    public NumberCount2Choice_? NumberCounts { get; init; }

    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("__aULRSgcEey2k_sfZmJz4g")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public Linkages64? Linkages { get; init; }

    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("__aULRygcEey2k_sfZmJz4g")]
    [DisplayName("Trade Details")]
    [IsoXmlTag("TradDtls")]
    public required SecuritiesTradeDetails119 TradeDetails { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("__aULSSgcEey2k_sfZmJz4g")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("__aULSygcEey2k_sfZmJz4g")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes111? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("__aULTSgcEey2k_sfZmJz4g")]
    [DisplayName("Quantity And Account Details")]
    [IsoXmlTag("QtyAndAcctDtls")]
    public required QuantityAndAccount95 QuantityAndAccountDetails { get; init; }

    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("__aULTygcEey2k_sfZmJz4g")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public required SettlementDetails201 SettlementParameters { get; init; }

    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("__aULUSgcEey2k_sfZmJz4g")]
    [DisplayName("Standing Settlement Instruction Details")]
    [IsoXmlTag("StgSttlmInstrDtls")]
    public StandingSettlementInstruction18? StandingSettlementInstructionDetails { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("__aULUygcEey2k_sfZmJz4g")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties100? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("__aULVSgcEey2k_sfZmJz4g")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties100? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Cash parties involved in the transaction if different from the securities settlement parties.
    /// </summary>
    [IsoId("__aULVygcEey2k_sfZmJz4g")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties36? CashParties { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("__aULWSgcEey2k_sfZmJz4g")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection94? SettlementAmount { get; init; }

    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("__aULWygcEey2k_sfZmJz4g")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts39? OtherAmounts { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("__aULXSgcEey2k_sfZmJz4g")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties43? OtherBusinessParties { get; init; }

    /// <summary>
    /// Information for registration or physical settlement.
    /// </summary>
    [IsoId("__aULXygcEey2k_sfZmJz4g")]
    [DisplayName("Additional Physical Or Registration Details")]
    [IsoXmlTag("AddtlPhysOrRegnDtls")]
    public RegistrationParameters6? AdditionalPhysicalOrRegistrationDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("__aULYSgcEey2k_sfZmJz4g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesSettlementTransactionInstructionV11Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementTransactionInstructionV11.
