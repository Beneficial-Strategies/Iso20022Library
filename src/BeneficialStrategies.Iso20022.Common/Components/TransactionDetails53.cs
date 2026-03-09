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
/// Identifies the details of the transaction.
/// </summary>
[IsoId("_ZQWDEQ3oEeKIIIcS0K4sAQ")]
[DisplayName("Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionDetails53
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionDetails53 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionDetails53( SecuritiesAccount13 reqSafekeepingAccount,SecurityIdentification14 reqFinancialInstrumentIdentification,Quantity6Choice_ reqSettlementQuantity,SettlementDate2Choice_ reqSettlementDate,ReceiveDelivery1Code reqSecuritiesMovementType,DeliveryReceiptType2Code reqPayment,SettlementDetails44 reqSettlementParameters )
    {
        SafekeepingAccount = reqSafekeepingAccount;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        SettlementQuantity = reqSettlementQuantity;
        SettlementDate = reqSettlementDate;
        SecuritiesMovementType = reqSecuritiesMovementType;
        Payment = reqPayment;
        SettlementParameters = reqSettlementParameters;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("_ZmjjvQ3oEeKIIIcS0K4sAQ")]
    [DisplayName("Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradId")]
    #endif
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradeIdentification { get; init; } 
    #else
    public System.String? TradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Zmjjxw3oEeKIIIcS0K4sAQ")]
    [DisplayName("Pool Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolId")]
    #endif
    [IsoXmlTag("PoolId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PoolIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PoolIdentification { get; init; } 
    #else
    public System.String? PoolIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_Zmjj0Q3oEeKIIIcS0K4sAQ")]
    [DisplayName("Corporate Action Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnEvtId")]
    #endif
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CorporateActionEventIdentification { get; init; } 
    #else
    public System.String? CorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the triparty agent&apos;s point of view.
    /// </summary>
    [IsoId("_Zmjj2w3oEeKIIIcS0K4sAQ")]
    [DisplayName("Triparty Agent Collateral Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgtCollTxId")]
    #endif
    [IsoXmlTag("TrptyAgtCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TripartyAgentCollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgentCollateralTransactionIdentification { get; init; } 
    #else
    public System.String? TripartyAgentCollateralTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client&apos;s point of view.
    /// </summary>
    [IsoId("_Zmjj5Q3oEeKIIIcS0K4sAQ")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntTrptyCollTxId")]
    #endif
    [IsoXmlTag("ClntTrptyCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientTripartyCollateralTransactionIdentification { get; init; } 
    #else
    public System.String? ClientTripartyCollateralTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    [IsoId("_rtR4cA3oEeKIIIcS0K4sAQ")]
    [DisplayName("Client Collateral Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntCollInstrId")]
    #endif
    [IsoXmlTag("ClntCollInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientCollateralInstructionIdentification { get; init; } 
    #else
    public System.String? ClientCollateralInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned to the instruction by the triparty agent.
    /// </summary>
    [IsoId("_0Aqq8A3oEeKIIIcS0K4sAQ")]
    [DisplayName("Triparty Collateral Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyCollInstrId")]
    #endif
    [IsoXmlTag("TrptyCollInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TripartyCollateralInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyCollateralInstructionIdentification { get; init; } 
    #else
    public System.String? TripartyCollateralInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Zmjj7w3oEeKIIIcS0K4sAQ")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification36Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification36Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification36Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Zmjj-Q3oEeKIIIcS0K4sAQ")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount13 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount13 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount13 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount13 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_ZmjkAw3oEeKIIIcS0K4sAQ")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_ZmjkDQ3oEeKIIIcS0K4sAQ")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification4? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification4? PlaceOfTrade { get; init; } 
    #else
    public MarketIdentification4? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_ZmjkFw3oEeKIIIcS0K4sAQ")]
    [DisplayName("Place Of Clearing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfClr")]
    #endif
    [IsoXmlTag("PlcOfClr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? PlaceOfClearing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceOfClearing { get; init; } 
    #else
    public System.String? PlaceOfClearing { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_ZmjkIQ3oEeKIIIcS0K4sAQ")]
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
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_ZmjkKw3oEeKIIIcS0K4sAQ")]
    [DisplayName("Settlement Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmQty")]
    #endif
    [IsoXmlTag("SttlmQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity6Choice_ SettlementQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity6Choice_ SettlementQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity6Choice_ SettlementQuantity { get; init; } 
    #else
    public Quantity6Choice_ SettlementQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_ZmjkNQ3oEeKIIIcS0K4sAQ")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection8? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection8? SettlementAmount { get; init; } 
    #else
    public AmountAndDirection8? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    [IsoId("_ZmjkPw3oEeKIIIcS0K4sAQ")]
    [DisplayName("Late Delivery Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LateDlvryDt")]
    #endif
    [IsoXmlTag("LateDlvryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? LateDeliveryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? LateDeliveryDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? LateDeliveryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_ZmjkSQ3oEeKIIIcS0K4sAQ")]
    [DisplayName("Expected Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdSttlmDt")]
    #endif
    [IsoXmlTag("XpctdSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ExpectedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ExpectedSettlementDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? ExpectedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// For against payment transactions, the value date/time at which the Sender expects the settlement amount to be credited or debited.
    /// </summary>
    [IsoId("_ZmjkUw3oEeKIIIcS0K4sAQ")]
    [DisplayName("Expected Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdValDt")]
    #endif
    [IsoXmlTag("XpctdValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ExpectedValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ExpectedValueDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? ExpectedValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_ZmjkXQ3oEeKIIIcS0K4sAQ")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDate2Choice_ SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDate2Choice_ SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDate2Choice_ SettlementDate { get; init; } 
    #else
    public SettlementDate2Choice_ SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_ZmjkZw3oEeKIIIcS0K4sAQ")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDate1Choice_? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate1Choice_? TradeDate { get; init; } 
    #else
    public TradeDate1Choice_? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_ZmjkcQ3oEeKIIIcS0K4sAQ")]
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
    [IsoId("_Zmjkew3oEeKIIIcS0K4sAQ")]
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
    [IsoId("_ZmjkhQ3oEeKIIIcS0K4sAQ")]
    [DisplayName("Settlement Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmParams")]
    #endif
    [IsoXmlTag("SttlmParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDetails44 SettlementParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDetails44 SettlementParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDetails44 SettlementParameters { get; init; } 
    #else
    public SettlementDetails44 SettlementParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_ZmstmQ3oEeKIIIcS0K4sAQ")]
    [DisplayName("Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSttlmPties")]
    #endif
    [IsoXmlTag("RcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties13? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties13? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties13? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_Zmstow3oEeKIIIcS0K4sAQ")]
    [DisplayName("Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSttlmPties")]
    #endif
    [IsoXmlTag("DlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties13? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties13? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties13? DeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_ZmstrQ3oEeKIIIcS0K4sAQ")]
    [DisplayName("Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invstr")]
    #endif
    [IsoXmlTag("Invstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification37Choice_? Investor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification37Choice_? Investor { get; init; } 
    #else
    public PartyIdentification37Choice_? Investor { get; set; } 
    #endif
    
    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_Zmsttw3oEeKIIIcS0K4sAQ")]
    [DisplayName("Qualified Foreign Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QlfdFrgnIntrmy")]
    #endif
    [IsoXmlTag("QlfdFrgnIntrmy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification45Choice_? QualifiedForeignIntermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification45Choice_? QualifiedForeignIntermediary { get; init; } 
    #else
    public PartyIdentification45Choice_? QualifiedForeignIntermediary { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_ZmstwQ3oEeKIIIcS0K4sAQ")]
    [DisplayName("Settlement Instruction Processing Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmInstrPrcgAddtlDtls")]
    #endif
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    #else
    public System.String? SettlementInstructionProcessingAdditionalDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
