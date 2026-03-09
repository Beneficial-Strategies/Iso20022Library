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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.027.001.02 ISO standard message type.
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
[IsoId("_LqiH4RhgEeKSublfJr3XCg")]
[DisplayName("Securities Trade Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTradeConfirmationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.027.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.027.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesTradeConfirmationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTradeConfirmationV02( TransactiontIdentification4 reqIdentification,Order14 reqTradeDetails,SecurityIdentification14 reqFinancialInstrumentIdentification,ConfirmationParties2 reqConfirmationParties )
    {
        Identification = reqIdentification;
        TradeDetails = reqTradeDetails;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        ConfirmationParties = reqConfirmationParties;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmation message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_LqiH4xhgEeKSublfJr3XCg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactiontIdentification4 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactiontIdentification4 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactiontIdentification4 Identification { get; init; } 
    #else
    public TransactiontIdentification4 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Count of the number of transactions linked.
    /// </summary>
    [IsoId("_LqiH5xhgEeKSublfJr3XCg")]
    [DisplayName("Number Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbCnt")]
    #endif
    [IsoXmlTag("NbCnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberCount1Choice_? NumberCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberCount1Choice_? NumberCount { get; init; } 
    #else
    public NumberCount1Choice_? NumberCount { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction identifier issued by a business party and/or market infrastructure. It may also be used to reference a previous transaction, for example, a block/allocation instruction, or tie a set of messages together.
    /// </summary>
    [IsoId("_LqiH6xhgEeKSublfJr3XCg")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages15? References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages15? References { get; init; } 
    #else
    public Linkages15? References { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_LqiH7xhgEeKSublfJr3XCg")]
    [DisplayName("Trade Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtls")]
    #endif
    [IsoXmlTag("TradDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Order14 TradeDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Order14 TradeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Order14 TradeDetails { get; init; } 
    #else
    public Order14 TradeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial instrument, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_LqiH8xhgEeKSublfJr3XCg")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_LqiH9xhgEeKSublfJr3XCg")]
    [DisplayName("Financial Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAttrbts")]
    #endif
    [IsoXmlTag("FinInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributes44? FinancialInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes44? FinancialInstrumentAttributes { get; init; } 
    #else
    public FinancialInstrumentAttributes44? FinancialInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying financial instrument to which an trade confirmation is related.
    /// </summary>
    [IsoId("_LqiH-xhgEeKSublfJr3XCg")]
    [DisplayName("Underlying Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygFinInstrm")]
    #endif
    [IsoXmlTag("UndrlygFinInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingFinancialInstrument2? UnderlyingFinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingFinancialInstrument2? UnderlyingFinancialInstrument { get; init; } 
    #else
    public UnderlyingFinancialInstrument2? UnderlyingFinancialInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Additional restrictions on the financial instrument, related to the stipulation.
    /// </summary>
    [IsoId("_LqiH_xhgEeKSublfJr3XCg")]
    [DisplayName("Stipulations")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Stiptns")]
    #endif
    [IsoXmlTag("Stiptns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentStipulations2? Stipulations { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentStipulations2? Stipulations { get; init; } 
    #else
    public FinancialInstrumentStipulations2? Stipulations { get; set; } 
    #endif
    
    /// <summary>
    /// Parties involved in the confirmation of the details of a trade.
    /// </summary>
    [IsoId("_LqiIAxhgEeKSublfJr3XCg")]
    [DisplayName("Confirmation Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfPties")]
    #endif
    [IsoXmlTag("ConfPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ConfirmationParties2 ConfirmationParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ConfirmationParties2 ConfirmationParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationParties2 ConfirmationParties { get; init; } 
    #else
    public ConfirmationParties2 ConfirmationParties { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_LqiIBxhgEeKSublfJr3XCg")]
    [DisplayName("Settlement Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmParams")]
    #endif
    [IsoXmlTag("SttlmParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementDetails43? SettlementParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDetails43? SettlementParameters { get; init; } 
    #else
    public SettlementDetails43? SettlementParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_LqiICxhgEeKSublfJr3XCg")]
    [DisplayName("Standing Settlement Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgSttlmInstr")]
    #endif
    [IsoXmlTag("StgSttlmInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StandingSettlementInstruction9? StandingSettlementInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingSettlementInstruction9? StandingSettlementInstruction { get; init; } 
    #else
    public StandingSettlementInstruction9? StandingSettlementInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_LqiIDxhgEeKSublfJr3XCg")]
    [DisplayName("Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSttlmPties")]
    #endif
    [IsoXmlTag("DlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties23? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties23? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties23? DeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_LqiIExhgEeKSublfJr3XCg")]
    [DisplayName("Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSttlmPties")]
    #endif
    [IsoXmlTag("RcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties23? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties23? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties23? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Cash parties involved in the specific transaction.
    /// </summary>
    [IsoId("_LqiIFxhgEeKSublfJr3XCg")]
    [DisplayName("Cash Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshPties")]
    #endif
    [IsoXmlTag("CshPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashParties18? CashParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashParties18? CashParties { get; init; } 
    #else
    public CashParties18? CashParties { get; set; } 
    #endif
    
    /// <summary>
    /// Provides clearing member information.
    /// </summary>
    [IsoId("_LqiIGxhgEeKSublfJr3XCg")]
    [DisplayName("Clearing Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrDtls")]
    #endif
    [IsoXmlTag("ClrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Clearing3? ClearingDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Clearing3? ClearingDetails { get; init; } 
    #else
    public Clearing3? ClearingDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities. The amount includes the principal with any commissions and fees or accrued interest.
    /// </summary>
    [IsoId("_LqiIHxhgEeKSublfJr3XCg")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection28? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection28? SettlementAmount { get; init; } 
    #else
    public AmountAndDirection28? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_LqiIIxhgEeKSublfJr3XCg")]
    [DisplayName("Other Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAmts")]
    #endif
    [IsoXmlTag("OthrAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherAmounts16? OtherAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherAmounts16? OtherAmounts { get; init; } 
    #else
    public OtherAmounts16? OtherAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Other prices than the deal price.
    /// </summary>
    [IsoId("_LqiIJxhgEeKSublfJr3XCg")]
    [DisplayName("Other Prices")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPrics")]
    #endif
    [IsoXmlTag("OthrPrics")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherPrices1? OtherPrices { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherPrices1? OtherPrices { get; init; } 
    #else
    public OtherPrices1? OtherPrices { get; set; } 
    #endif
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_LqiIKxhgEeKSublfJr3XCg")]
    [DisplayName("Other Business Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrBizPties")]
    #endif
    [IsoXmlTag("OthrBizPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherParties18? OtherBusinessParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherParties18? OtherBusinessParties { get; init; } 
    #else
    public OtherParties18? OtherBusinessParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a transaction that the trading parties are agreeing to repurchase, sell back or return the same or similar securities at a later time. 
    /// The two leg transaction details defines the closing leg conditions of a two leg transaction. It is also used to define the anticipated closing leg conditions at the time of opening the closed-end transaction. 
    /// </summary>
    [IsoId("_LqiILxhgEeKSublfJr3XCg")]
    [DisplayName("Two Leg Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TwoLegTxDtls")]
    #endif
    [IsoXmlTag("TwoLegTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TwoLegTransactionDetails1? TwoLegTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TwoLegTransactionDetails1? TwoLegTransactionDetails { get; init; } 
    #else
    public TwoLegTransactionDetails1? TwoLegTransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies regulatory stipulations that financial institutions must be compliant with in the country, region, and/or area they conduct business.
    /// </summary>
    [IsoId("_LqiIMxhgEeKSublfJr3XCg")]
    [DisplayName("Regulatory Stipulations")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryStiptns")]
    #endif
    [IsoXmlTag("RgltryStiptns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegulatoryStipulations1? RegulatoryStipulations { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegulatoryStipulations1? RegulatoryStipulations { get; init; } 
    #else
    public RegulatoryStipulations1? RegulatoryStipulations { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_LqiINxhgEeKSublfJr3XCg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since SecuritiesTradeConfirmationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTradeConfirmationV02.

