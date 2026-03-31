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
/// This record is an implementation of the sese.025.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionConfirmation to an account owner to confirm the partial or full delivery or receipt of financial instruments, free or against of payment, physically or by book-entry.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
///
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information.
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account servicer sends a SecuritiesSettlementTransactionConfirmation to an account owner to confirm the partial or full delivery or receipt of financial instruments, free or against of payment, physically or by book-entry.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information.|using the relevant elements in the Business Application Header."
)]
[IsoId("_YSWHDQCTEeW_3KiG8SEjHA")]
[DisplayName("Securities Settlement Transaction Confirmation V")]
public record SecuritiesSettlementTransactionConfirmationV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.025.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.025.001.06";

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
    [IsoId("_YSWHJQCTEeW_3KiG8SEjHA")]
    [DisplayName("Transaction Identification Details")]
    [IsoXmlTag("TxIdDtls")]
    public required SettlementTypeAndIdentification19 TransactionIdentificationDetails { get; init; }

    /// <summary>
    /// Link to another transaction - provided for information only.
    /// </summary>
    [IsoId("_LvDysGazEeWZev0W8F756g")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public Linkages41? Linkages { get; init; }

    /// <summary>
    /// Additional parameters to the transaction.
    /// </summary>
    [IsoId("_YSWHJwCTEeW_3KiG8SEjHA")]
    [DisplayName("Additional Parameters")]
    [IsoXmlTag("AddtlParams")]
    public AdditionalParameters22? AdditionalParameters { get; init; }

    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_YSWHKQCTEeW_3KiG8SEjHA")]
    [DisplayName("Trade Details")]
    [IsoXmlTag("TradDtls")]
    public required SecuritiesTradeDetails53 TradeDetails { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_YSWHKwCTEeW_3KiG8SEjHA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_YSWHLQCTEeW_3KiG8SEjHA")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes64? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_YSWHLwCTEeW_3KiG8SEjHA")]
    [DisplayName("Quantity And Account Details")]
    [IsoXmlTag("QtyAndAcctDtls")]
    public required QuantityAndAccount41 QuantityAndAccountDetails { get; init; }

    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_YSWHMQCTEeW_3KiG8SEjHA")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public required SettlementDetails90 SettlementParameters { get; init; }

    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_YSWHMwCTEeW_3KiG8SEjHA")]
    [DisplayName("Standing Settlement Instruction Details")]
    [IsoXmlTag("StgSttlmInstrDtls")]
    public StandingSettlementInstruction11? StandingSettlementInstructionDetails { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_YSWHNQCTEeW_3KiG8SEjHA")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties36? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_YSWHNwCTEeW_3KiG8SEjHA")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties36? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Cash parties involved in the transaction if different for the securities settlement parties.
    /// </summary>
    [IsoId("_YSWHOQCTEeW_3KiG8SEjHA")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties26? CashParties { get; init; }

    /// <summary>
    /// Amount effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_YSWHOwCTEeW_3KiG8SEjHA")]
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public AmountAndDirection46? SettledAmount { get; init; }

    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_YSWHPQCTEeW_3KiG8SEjHA")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts30? OtherAmounts { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_YSWHPwCTEeW_3KiG8SEjHA")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties27? OtherBusinessParties { get; init; }

    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    [IsoId("_YSWHQQCTEeW_3KiG8SEjHA")]
    [DisplayName("Additional Physical Or Registration Details")]
    [IsoXmlTag("AddtlPhysOrRegnDtls")]
    public RegistrationParameters4? AdditionalPhysicalOrRegistrationDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_YSWHQwCTEeW_3KiG8SEjHA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesSettlementTransactionConfirmationV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementTransactionConfirmationV06.
