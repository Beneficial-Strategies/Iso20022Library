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
[Description(@"Scope|An account servicer sends a SecuritiesSettlementTransactionConfirmation to an account owner to confirm the partial or full delivery or receipt of financial instruments, free or against of payment, physically or by book-entry.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information.|using the relevant elements in the Business Application Header.")]
[IsoId("_YSWHDQCTEeW_3KiG8SEjHA")]
[DisplayName("Securities Settlement Transaction Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSettlementTransactionConfirmationV06 : IOuterRecord
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesSettlementTransactionConfirmationV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesSettlementTransactionConfirmationV06( SettlementTypeAndIdentification19 reqTransactionIdentificationDetails,SecuritiesTradeDetails53 reqTradeDetails,SecurityIdentification19 reqFinancialInstrumentIdentification,QuantityAndAccount41 reqQuantityAndAccountDetails,SettlementDetails90 reqSettlementParameters )
    {
        TransactionIdentificationDetails = reqTransactionIdentificationDetails;
        TradeDetails = reqTradeDetails;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        QuantityAndAccountDetails = reqQuantityAndAccountDetails;
        SettlementParameters = reqSettlementParameters;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides transaction type and identification information.
    /// </summary>
    [IsoId("_YSWHJQCTEeW_3KiG8SEjHA")]
    [DisplayName("Transaction Identification Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdDtls")]
    #endif
    [IsoXmlTag("TxIdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTypeAndIdentification19 TransactionIdentificationDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTypeAndIdentification19 TransactionIdentificationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTypeAndIdentification19 TransactionIdentificationDetails { get; init; } 
    #else
    public SettlementTypeAndIdentification19 TransactionIdentificationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Link to another transaction - provided for information only.
    /// </summary>
    [IsoId("_LvDysGazEeWZev0W8F756g")]
    [DisplayName("Linkages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lnkgs")]
    #endif
    [IsoXmlTag("Lnkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages41? Linkages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages41? Linkages { get; init; } 
    #else
    public Linkages41? Linkages { get; set; } 
    #endif
    
    /// <summary>
    /// Additional parameters to the transaction.
    /// </summary>
    [IsoId("_YSWHJwCTEeW_3KiG8SEjHA")]
    [DisplayName("Additional Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlParams")]
    #endif
    [IsoXmlTag("AddtlParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalParameters22? AdditionalParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalParameters22? AdditionalParameters { get; init; } 
    #else
    public AdditionalParameters22? AdditionalParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_YSWHKQCTEeW_3KiG8SEjHA")]
    [DisplayName("Trade Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtls")]
    #endif
    [IsoXmlTag("TradDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesTradeDetails53 TradeDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesTradeDetails53 TradeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTradeDetails53 TradeDetails { get; init; } 
    #else
    public SecuritiesTradeDetails53 TradeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_YSWHKwCTEeW_3KiG8SEjHA")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_YSWHLQCTEeW_3KiG8SEjHA")]
    [DisplayName("Financial Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAttrbts")]
    #endif
    [IsoXmlTag("FinInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributes64? FinancialInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes64? FinancialInstrumentAttributes { get; init; } 
    #else
    public FinancialInstrumentAttributes64? FinancialInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_YSWHLwCTEeW_3KiG8SEjHA")]
    [DisplayName("Quantity And Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyAndAcctDtls")]
    #endif
    [IsoXmlTag("QtyAndAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QuantityAndAccount41 QuantityAndAccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QuantityAndAccount41 QuantityAndAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityAndAccount41 QuantityAndAccountDetails { get; init; } 
    #else
    public QuantityAndAccount41 QuantityAndAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_YSWHMQCTEeW_3KiG8SEjHA")]
    [DisplayName("Settlement Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmParams")]
    #endif
    [IsoXmlTag("SttlmParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDetails90 SettlementParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDetails90 SettlementParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDetails90 SettlementParameters { get; init; } 
    #else
    public SettlementDetails90 SettlementParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_YSWHMwCTEeW_3KiG8SEjHA")]
    [DisplayName("Standing Settlement Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgSttlmInstrDtls")]
    #endif
    [IsoXmlTag("StgSttlmInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StandingSettlementInstruction11? StandingSettlementInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingSettlementInstruction11? StandingSettlementInstructionDetails { get; init; } 
    #else
    public StandingSettlementInstruction11? StandingSettlementInstructionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_YSWHNQCTEeW_3KiG8SEjHA")]
    [DisplayName("Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSttlmPties")]
    #endif
    [IsoXmlTag("DlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties36? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties36? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties36? DeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_YSWHNwCTEeW_3KiG8SEjHA")]
    [DisplayName("Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSttlmPties")]
    #endif
    [IsoXmlTag("RcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties36? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties36? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties36? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Cash parties involved in the transaction if different for the securities settlement parties.
    /// </summary>
    [IsoId("_YSWHOQCTEeW_3KiG8SEjHA")]
    [DisplayName("Cash Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshPties")]
    #endif
    [IsoXmlTag("CshPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashParties26? CashParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashParties26? CashParties { get; init; } 
    #else
    public CashParties26? CashParties { get; set; } 
    #endif
    
    /// <summary>
    /// Amount effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_YSWHOwCTEeW_3KiG8SEjHA")]
    [DisplayName("Settled Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttldAmt")]
    #endif
    [IsoXmlTag("SttldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection46? SettledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection46? SettledAmount { get; init; } 
    #else
    public AmountAndDirection46? SettledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_YSWHPQCTEeW_3KiG8SEjHA")]
    [DisplayName("Other Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAmts")]
    #endif
    [IsoXmlTag("OthrAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherAmounts30? OtherAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherAmounts30? OtherAmounts { get; init; } 
    #else
    public OtherAmounts30? OtherAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_YSWHPwCTEeW_3KiG8SEjHA")]
    [DisplayName("Other Business Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrBizPties")]
    #endif
    [IsoXmlTag("OthrBizPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherParties27? OtherBusinessParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherParties27? OtherBusinessParties { get; init; } 
    #else
    public OtherParties27? OtherBusinessParties { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    [IsoId("_YSWHQQCTEeW_3KiG8SEjHA")]
    [DisplayName("Additional Physical Or Registration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPhysOrRegnDtls")]
    #endif
    [IsoXmlTag("AddtlPhysOrRegnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegistrationParameters4? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegistrationParameters4? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    #else
    public RegistrationParameters4? AdditionalPhysicalOrRegistrationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_YSWHQwCTEeW_3KiG8SEjHA")]
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


// Since SecuritiesSettlementTransactionConfirmationV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementTransactionConfirmationV06.

