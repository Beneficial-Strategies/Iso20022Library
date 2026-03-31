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
/// This record is an implementation of the sese.035.002.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A securities financing transaction account servicer sends a SecuritiesFinancingConfirmation to an account owner to confirm or advise of the partial or full settlement of the opening or closing leg of a securities financing transaction.
///
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure managing securities financing transactions on behalf of their participants
/// - an agent (sub-custodian) managing securities financing transactions on behalf of their global custodian customer, or
/// - a custodian managing securities financing transactions on behalf of an investment management institution or a broker/dealer.
///
///
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|A securities financing transaction account servicer sends a SecuritiesFinancingConfirmation to an account owner to confirm or advise of the partial or full settlement of the opening or closing leg of a securities financing transaction. ||The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure managing securities financing transactions on behalf of their participants|- an agent (sub-custodian) managing securities financing transactions on behalf of their global custodian customer, or |- a custodian managing securities financing transactions on behalf of an investment management institution or a broker/dealer.|||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header."
)]
[IsoId("_5TlZE83yEee5nJBZsW8MFQ")]
[DisplayName("Securities Financing Confirmation 002 V")]
public record SecuritiesFinancingConfirmation002V08 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.035.002.08";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.035.002.08";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Securities financing transaction identification information, type (repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing) and other parameters.
    /// </summary>
    [IsoId("_5TlZH83yEee5nJBZsW8MFQ")]
    [DisplayName("Transaction Identification Details")]
    [IsoXmlTag("TxIdDtls")]
    public required TransactionTypeAndAdditionalParameters19 TransactionIdentificationDetails { get; init; }

    /// <summary>
    /// Additional parameters to the transaction.
    /// </summary>
    [IsoId("_5TlZIc3yEee5nJBZsW8MFQ")]
    [DisplayName("Additional Parameters")]
    [IsoXmlTag("AddtlParams")]
    public AdditionalParameters26? AdditionalParameters { get; init; }

    /// <summary>
    /// Details of the securities financing deal.
    /// </summary>
    [IsoId("_5TlZI83yEee5nJBZsW8MFQ")]
    [DisplayName("Trade Details")]
    [IsoXmlTag("TradDtls")]
    public required SecuritiesTradeDetails82 TradeDetails { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_5TlZJc3yEee5nJBZsW8MFQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_5TlZJ83yEee5nJBZsW8MFQ")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes97? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_5TlZKc3yEee5nJBZsW8MFQ")]
    [DisplayName("Quantity And Account Details")]
    [IsoXmlTag("QtyAndAcctDtls")]
    public required QuantityAndAccount62 QuantityAndAccountDetails { get; init; }

    /// <summary>
    /// Details of the closing of the securities financing transaction.
    /// </summary>
    [IsoId("_5TlZK83yEee5nJBZsW8MFQ")]
    [DisplayName("Securities Financing Details")]
    [IsoXmlTag("SctiesFincgDtls")]
    public SecuritiesFinancingTransactionDetails39? SecuritiesFinancingDetails { get; init; }

    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_5TlZLc3yEee5nJBZsW8MFQ")]
    [DisplayName("Standing Settlement Instruction Details")]
    [IsoXmlTag("StgSttlmInstrDtls")]
    public StandingSettlementInstruction15? StandingSettlementInstructionDetails { get; init; }

    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_5TlZL83yEee5nJBZsW8MFQ")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails151? SettlementParameters { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_5TlZMc3yEee5nJBZsW8MFQ")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties64? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_5TlZM83yEee5nJBZsW8MFQ")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties64? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Cash parties involved in the transaction if different for the securities settlement parties.
    /// </summary>
    [IsoId("_5TlZNc3yEee5nJBZsW8MFQ")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties30? CashParties { get; init; }

    /// <summary>
    /// Amount effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_5TlZN83yEee5nJBZsW8MFQ")]
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public AmountAndDirection90? SettledAmount { get; init; }

    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_5TlZOc3yEee5nJBZsW8MFQ")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts42? OtherAmounts { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_5TlZO83yEee5nJBZsW8MFQ")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties29? OtherBusinessParties { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5TlZPc3yEee5nJBZsW8MFQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesFinancingConfirmation002V08Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesFinancingConfirmation002V08.
