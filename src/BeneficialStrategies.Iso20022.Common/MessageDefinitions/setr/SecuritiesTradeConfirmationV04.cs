// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.027.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
/// Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to provide trade confirmation on a per-account basis based on instructions provided by the instructing party in the SecuritiesAllocationInstruction message.
/// 
/// It may also be used to provide trade confirmation on the trade level from an executing party or an instructing party to the custodian or an affirming party directly or through CMU.
/// 
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The custodian or the affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.
/// 
/// USAGE
/// Initiator: In local matching, the initiator of this message is always the executing party. In central matching the initiator may be either the executing party or instructing party.
/// Respondent: instructing party, a custodian or an affirming party responds with SecuritiesTradeConfirmationResponse (accept or reject) message.
/// </summary>
[Description(@"SCOPE|Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to provide trade confirmation on a per-account basis based on instructions provided by the instructing party in the SecuritiesAllocationInstruction message.||It may also be used to provide trade confirmation on the trade level from an executing party or an instructing party to the custodian or an affirming party directly or through CMU.||The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The custodian or the affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.||USAGE|Initiator: In local matching, the initiator of this message is always the executing party. In central matching the initiator may be either the executing party or instructing party.|Respondent: instructing party, a custodian or an affirming party responds with SecuritiesTradeConfirmationResponse (accept or reject) message.")]
[IsoId("_j1-bIY-XEeaVK-2bgpxeYw")]
[DisplayName("Securities Trade Confirmation V")]
public partial record SecuritiesTradeConfirmationV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.027.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.027.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmation message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_j1-bI4-XEeaVK-2bgpxeYw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required TransactiontIdentification4 Identification { get; init; } 
    
    /// <summary>
    /// Count of the number of transactions linked.
    /// </summary>
    [IsoId("_j1-bJY-XEeaVK-2bgpxeYw")]
    [DisplayName("Number Count")]
    [IsoXmlTag("NbCnt")]
    public NumberCount1Choice_? NumberCount { get; init; } 
    
    /// <summary>
    /// Reference to the transaction identifier issued by a business party and/or market infrastructure. It may also be used to reference a previous transaction, for example, a block/allocation instruction, or tie a set of messages together.
    /// </summary>
    [IsoId("_j1-bJ4-XEeaVK-2bgpxeYw")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public Linkages52? References { get; init; } 
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_j1-bKY-XEeaVK-2bgpxeYw")]
    [DisplayName("Trade Details")]
    [IsoXmlTag("TradDtls")]
    public required Order24 TradeDetails { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial instrument, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_j1-bK4-XEeaVK-2bgpxeYw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_j1-bLY-XEeaVK-2bgpxeYw")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes124? FinancialInstrumentAttributes { get; init; } 
    
    /// <summary>
    /// Underlying financial instrument to which an trade confirmation is related.
    /// </summary>
    [IsoId("_j1-bL4-XEeaVK-2bgpxeYw")]
    [DisplayName("Underlying Financial Instrument")]
    [IsoXmlTag("UndrlygFinInstrm")]
    public UnderlyingFinancialInstrument7? UnderlyingFinancialInstrument { get; init; } 
    
    /// <summary>
    /// Additional restrictions on the financial instrument, related to the stipulation.
    /// </summary>
    [IsoId("_j1-bMY-XEeaVK-2bgpxeYw")]
    [DisplayName("Stipulations")]
    [IsoXmlTag("Stiptns")]
    public FinancialInstrumentStipulations4? Stipulations { get; init; } 
    
    /// <summary>
    /// Parties involved in the confirmation of the details of a trade.
    /// </summary>
    [IsoId("_j1-bM4-XEeaVK-2bgpxeYw")]
    [DisplayName("Confirmation Parties")]
    [IsoXmlTag("ConfPties")]
    public required ConfirmationParties6 ConfirmationParties { get; init; } 
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_j1-bNY-XEeaVK-2bgpxeYw")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails213? SettlementParameters { get; init; } 
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_j1-bN4-XEeaVK-2bgpxeYw")]
    [DisplayName("Standing Settlement Instruction")]
    [IsoXmlTag("StgSttlmInstr")]
    public StandingSettlementInstruction13? StandingSettlementInstruction { get; init; } 
    
    /// <summary>
    /// Specifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_j1-bOY-XEeaVK-2bgpxeYw")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties59? DeliveringSettlementParties { get; init; } 
    
    /// <summary>
    /// Specifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_j1-bO4-XEeaVK-2bgpxeYw")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties59? ReceivingSettlementParties { get; init; } 
    
    /// <summary>
    /// Cash parties involved in the specific transaction.
    /// </summary>
    [IsoId("_j1-bPY-XEeaVK-2bgpxeYw")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties33? CashParties { get; init; } 
    
    /// <summary>
    /// Provides clearing member information.
    /// </summary>
    [IsoId("_j1-bP4-XEeaVK-2bgpxeYw")]
    [DisplayName("Clearing Details")]
    [IsoXmlTag("ClrDtls")]
    public Clearing5? ClearingDetails { get; init; } 
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities. The amount includes the principal with any commissions and fees or accrued interest.
    /// </summary>
    [IsoId("_j1-bQY-XEeaVK-2bgpxeYw")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection28? SettlementAmount { get; init; } 
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_j1-bQ4-XEeaVK-2bgpxeYw")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts16? OtherAmounts { get; init; } 
    
    /// <summary>
    /// Other prices than the deal price.
    /// </summary>
    [IsoId("_j1-bRY-XEeaVK-2bgpxeYw")]
    [DisplayName("Other Prices")]
    [IsoXmlTag("OthrPrics")]
    public OtherPrices5? OtherPrices { get; init; } 
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_j1-bR4-XEeaVK-2bgpxeYw")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties32? OtherBusinessParties { get; init; } 
    
    /// <summary>
    /// Specifies a transaction that the trading parties are agreeing to repurchase, sell back or return the same or similar securities at a later time. 
    /// The two leg transaction details defines the closing leg conditions of a two leg transaction. It is also used to define the anticipated closing leg conditions at the time of opening the closed-end transaction. 
    /// </summary>
    [IsoId("_j1-bSY-XEeaVK-2bgpxeYw")]
    [DisplayName("Two Leg Transaction Details")]
    [IsoXmlTag("TwoLegTxDtls")]
    public TwoLegTransactionDetails5? TwoLegTransactionDetails { get; init; } 
    
    /// <summary>
    /// Specifies regulatory stipulations that financial institutions must be compliant with in the country, region, and/or area they conduct business.
    /// </summary>
    [IsoId("_j1-bS4-XEeaVK-2bgpxeYw")]
    [DisplayName("Regulatory Stipulations")]
    [IsoXmlTag("RgltryStiptns")]
    public RegulatoryStipulations1? RegulatoryStipulations { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_j1-bTY-XEeaVK-2bgpxeYw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since SecuritiesTradeConfirmationV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTradeConfirmationV04.

