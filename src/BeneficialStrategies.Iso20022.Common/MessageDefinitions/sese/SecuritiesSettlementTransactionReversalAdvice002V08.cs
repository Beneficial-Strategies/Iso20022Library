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
/// This record is an implementation of the sese.026.002.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionReversalAdvice to an account owner to reverse the confirmation of a partial or full delivery or receipt of financial instruments, free or against of payment, physically or by book-entry.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
///
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account servicer sends a SecuritiesSettlementTransactionReversalAdvice to an account owner to reverse the confirmation of a partial or full delivery or receipt of financial instruments, free or against of payment, physically or by book-entry.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header."
)]
[IsoId("_qIKhU_fYEeiNZp_PtLohLw")]
[DisplayName("Securities Settlement Transaction Reversal Advice 002 V")]
public record SecuritiesSettlementTransactionReversalAdvice002V08 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.026.002.08";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxRvslAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.026.002.08";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides transaction type and identification information.
    /// </summary>
    [IsoId("_qIKhX_fYEeiNZp_PtLohLw")]
    [DisplayName("Transaction Identification Details")]
    [IsoXmlTag("TxIdDtls")]
    public required SettlementTypeAndIdentification24 TransactionIdentificationDetails { get; init; }

    /// <summary>
    /// Reference to the unambiguous identification of the confirmation as per the account servicer.
    /// </summary>
    [IsoId("_qIKhYffYEeiNZp_PtLohLw")]
    [DisplayName("Confirmation Reference")]
    [IsoXmlTag("ConfRef")]
    public required Identification16 ConfirmationReference { get; init; }

    /// <summary>
    /// Additional parameters for the transaction.
    /// </summary>
    [IsoId("_qIKhY_fYEeiNZp_PtLohLw")]
    [DisplayName("Additional Parameters")]
    [IsoXmlTag("AddtlParams")]
    public AdditionalParameters32? AdditionalParameters { get; init; }

    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_qIKhZffYEeiNZp_PtLohLw")]
    [DisplayName("Trade Details")]
    [IsoXmlTag("TradDtls")]
    public required SecuritiesTradeDetails106 TradeDetails { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_qIKhZ_fYEeiNZp_PtLohLw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_qIKhaffYEeiNZp_PtLohLw")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes97? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_qIKha_fYEeiNZp_PtLohLw")]
    [DisplayName("Quantity And Account Details")]
    [IsoXmlTag("QtyAndAcctDtls")]
    public required QuantityAndAccount90 QuantityAndAccountDetails { get; init; }

    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_qIKhbffYEeiNZp_PtLohLw")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public required SettlementDetails180 SettlementParameters { get; init; }

    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_qIKhb_fYEeiNZp_PtLohLw")]
    [DisplayName("Standing Settlement Instruction Details")]
    [IsoXmlTag("StgSttlmInstrDtls")]
    public StandingSettlementInstruction17? StandingSettlementInstructionDetails { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_qIKhcffYEeiNZp_PtLohLw")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties81? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_qIKhc_fYEeiNZp_PtLohLw")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties81? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Cash parties involved in the transaction if different from the securities settlement parties.
    /// </summary>
    [IsoId("_qIKhdffYEeiNZp_PtLohLw")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties40? CashParties { get; init; }

    /// <summary>
    /// Amount effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_qIKhd_fYEeiNZp_PtLohLw")]
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public AmountAndDirection96? SettledAmount { get; init; }

    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_qIKheffYEeiNZp_PtLohLw")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts44? OtherAmounts { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_qIKhe_fYEeiNZp_PtLohLw")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties35? OtherBusinessParties { get; init; }

    /// <summary>
    /// Information for registration or physical settlement.
    /// </summary>
    [IsoId("_qIKhfffYEeiNZp_PtLohLw")]
    [DisplayName("Additional Physical Or Registration Details")]
    [IsoXmlTag("AddtlPhysOrRegnDtls")]
    public RegistrationParameters7? AdditionalPhysicalOrRegistrationDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_qIKhf_fYEeiNZp_PtLohLw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesSettlementTransactionReversalAdvice002V08Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementTransactionReversalAdvice002V08.
