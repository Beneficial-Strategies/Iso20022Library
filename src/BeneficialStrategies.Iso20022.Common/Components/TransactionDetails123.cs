// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the transaction.
/// </summary>
[IsoId("_iE4Q1ffZEeiNZp_PtLohLw")]
[DisplayName("Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionDetails123
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionDetails123 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionDetails123( TransactionActivity4Choice_ reqTransactionActivity,ReceiveDelivery1Code reqSecuritiesMovementType,DeliveryReceiptType2Code reqPayment,SecurityIdentification20 reqFinancialInstrumentIdentification,Quantity10Choice_ reqPostingQuantity,SettlementDate32Choice_ reqSettlementDate )
    {
        TransactionActivity = reqTransactionActivity;
        SecuritiesMovementType = reqSecuritiesMovementType;
        Payment = reqPayment;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        PostingQuantity = reqPostingQuantity;
        SettlementDate = reqSettlementDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of activity to which this instruction relates.
    /// </summary>
    [IsoId("_iE4Q5ffZEeiNZp_PtLohLw")]
    [DisplayName("Transaction Activity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxActvty")]
    #endif
    [IsoXmlTag("TxActvty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionActivity4Choice_ TransactionActivity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionActivity4Choice_ TransactionActivity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionActivity4Choice_ TransactionActivity { get; init; } 
    #else
    public TransactionActivity4Choice_ TransactionActivity { get; set; } 
    #endif
    
    /// <summary>
    /// Choice of type for the transaction reported.
    /// </summary>
    [IsoId("_iE4Q6ffZEeiNZp_PtLohLw")]
    [DisplayName("Settlement Transaction Or Corporate Action Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTxOrCorpActnEvtTp")]
    #endif
    [IsoXmlTag("SttlmTxOrCorpActnEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementOrCorporateActionEvent28Choice_? SettlementTransactionOrCorporateActionEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementOrCorporateActionEvent28Choice_? SettlementTransactionOrCorporateActionEventType { get; init; } 
    #else
    public SettlementOrCorporateActionEvent28Choice_? SettlementTransactionOrCorporateActionEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_iE4Q7ffZEeiNZp_PtLohLw")]
    [DisplayName("Securities Movement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntTp")]
    #endif
    [IsoXmlTag("SctiesMvmntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #else
    public ReceiveDelivery1Code SecuritiesMovementType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_iE4Q8ffZEeiNZp_PtLohLw")]
    [DisplayName("Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pmt")]
    #endif
    [IsoXmlTag("Pmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DeliveryReceiptType2Code Payment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DeliveryReceiptType2Code Payment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryReceiptType2Code Payment { get; init; } 
    #else
    public DeliveryReceiptType2Code Payment { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [IsoId("_iE4Q9ffZEeiNZp_PtLohLw")]
    [DisplayName("Settlement Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmParams")]
    #endif
    [IsoXmlTag("SttlmParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementDetails161? SettlementParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDetails161? SettlementParameters { get; init; } 
    #else
    public SettlementDetails161? SettlementParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_iE4Q-ffZEeiNZp_PtLohLw")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; init; } 
    #else
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_iE4Q_ffZEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafeKeepingPlace4? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafeKeepingPlace4? SafekeepingPlace { get; init; } 
    #else
    public SafeKeepingPlace4? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_iE4RAffZEeiNZp_PtLohLw")]
    [DisplayName("Place Of Clearing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfClr")]
    #endif
    [IsoXmlTag("PlcOfClr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; } 
    #else
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_iE4RBffZEeiNZp_PtLohLw")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification20 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument (to be) posted to the safekeeping account.
    /// </summary>
    [IsoId("_iE4RCffZEeiNZp_PtLohLw")]
    [DisplayName("Posting Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngQty")]
    #endif
    [IsoXmlTag("PstngQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity10Choice_ PostingQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity10Choice_ PostingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity10Choice_ PostingQuantity { get; init; } 
    #else
    public Quantity10Choice_ PostingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_iE4RDffZEeiNZp_PtLohLw")]
    [DisplayName("Posting Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngAmt")]
    #endif
    [IsoXmlTag("PstngAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection67? PostingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection67? PostingAmount { get; init; } 
    #else
    public AmountAndDirection67? PostingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_iE4REffZEeiNZp_PtLohLw")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDate9Choice_? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate9Choice_? TradeDate { get; init; } 
    #else
    public TradeDate9Choice_? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the sender expects settlement.
    /// </summary>
    [IsoId("_iE4RFffZEeiNZp_PtLohLw")]
    [DisplayName("Expected Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdSttlmDt")]
    #endif
    [IsoXmlTag("XpctdSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? ExpectedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? ExpectedSettlementDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? ExpectedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_iE4RGffZEeiNZp_PtLohLw")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDate32Choice_ SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDate32Choice_ SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDate32Choice_ SettlementDate { get; init; } 
    #else
    public SettlementDate32Choice_ SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    [IsoId("_iE4RHffZEeiNZp_PtLohLw")]
    [DisplayName("Late Delivery Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LateDlvryDt")]
    #endif
    [IsoXmlTag("LateDlvryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? LateDeliveryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? LateDeliveryDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? LateDeliveryDate { get; set; } 
    #endif
    
    /// <summary>
    /// For against payment transactions, the value date/time at which the account servicer expects the settlement amount to be credited or debited.
    /// </summary>
    [IsoId("_iE4RIffZEeiNZp_PtLohLw")]
    [DisplayName("Expected Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdValDt")]
    #endif
    [IsoXmlTag("XpctdValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? ExpectedValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? ExpectedValueDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? ExpectedValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    [IsoId("_iE4RJffZEeiNZp_PtLohLw")]
    [DisplayName("Acknowledged Status Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AckdStsTmStmp")]
    #endif
    [IsoXmlTag("AckdStsTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? AcknowledgedStatusTimeStamp { get; init; } 
    #else
    public System.DateTime? AcknowledgedStatusTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Time stamp on when the transaction is matched.
    /// </summary>
    [IsoId("_iE4RJ_fZEeiNZp_PtLohLw")]
    [DisplayName("Matched Status Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchdStsTmStmp")]
    #endif
    [IsoXmlTag("MtchdStsTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? MatchedStatusTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? MatchedStatusTimeStamp { get; init; } 
    #else
    public System.DateTime? MatchedStatusTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_iE4RKffZEeiNZp_PtLohLw")]
    [DisplayName("Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSttlmPties")]
    #endif
    [IsoXmlTag("DlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties90? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties90? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties90? DeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_iE4RLffZEeiNZp_PtLohLw")]
    [DisplayName("Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSttlmPties")]
    #endif
    [IsoXmlTag("RcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties90? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties90? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties90? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional details on the transaction which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_iE4RMffZEeiNZp_PtLohLw")]
    [DisplayName("Transaction Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAddtlDtls")]
    #endif
    [IsoXmlTag("TxAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax350Text? TransactionAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionAdditionalDetails { get; init; } 
    #else
    public System.String? TransactionAdditionalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_iE4RNffZEeiNZp_PtLohLw")]
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
