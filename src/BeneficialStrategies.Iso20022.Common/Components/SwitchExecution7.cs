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
/// Execution of a switch order.
/// </summary>
[IsoId("_8EacxzbsEead9bDRE_1DAQ")]
[DisplayName("Switch Execution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SwitchExecution7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SwitchExecution7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SwitchExecution7( System.String reqDealReference,System.String reqOrderReference )
    {
        DealReference = reqDealReference;
        OrderReference = reqOrderReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the confirmation is an amendment of a previous confirmation.
    /// </summary>
    [IsoId("_hwj2gVAMEeal4_lvhAnyGQ")]
    [DisplayName("Amendment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntInd")]
    #endif
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AmendmentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AmendmentIndicator { get; init; } 
    #else
    public System.String? AmendmentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_8d2QOTbsEead9bDRE_1DAQ")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_f8QiwTxBEea9KZ_pBxG-rQ")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; } 
    #else
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the order was placed by the investor or its agent.
    /// </summary>
    [IsoId("_8d2QOzbsEead9bDRE_1DAQ")]
    [DisplayName("Order Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrDtTm")]
    #endif
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OrderDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OrderDateTime { get; init; } 
    #else
    public System.DateTime? OrderDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time the order was received by the executing party, for example, the transfer agent.
    /// </summary>
    [IsoId("_4HuFYTw6Eea0R-RTP9Wg-Q")]
    [DisplayName("Received Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvdDtTm")]
    #endif
    [IsoXmlTag("RcvdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ReceivedDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ReceivedDateTime { get; init; } 
    #else
    public System.DateTime? ReceivedDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("_8d2QPzbsEead9bDRE_1DAQ")]
    [DisplayName("Deal Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealRef")]
    #endif
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text DealReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DealReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DealReference { get; init; } 
    #else
    public System.String DealReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_8d2QQTbsEead9bDRE_1DAQ")]
    [DisplayName("Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrRef")]
    #endif
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OrderReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OrderReference { get; init; } 
    #else
    public System.String OrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_8d2QQzbsEead9bDRE_1DAQ")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientReference { get; init; } 
    #else
    public System.String? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Account impacted by the investment fund order execution.
    /// </summary>
    [IsoId("_8d2QPTbsEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount58? InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party related to the transaction.
    /// </summary>
    [IsoId("_8d2QSTbsEead9bDRE_1DAQ")]
    [DisplayName("Related Party Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPtyDtls")]
    #endif
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary39> RelatedPartyDetails { get; init; } = new ValueList<Intermediary39>(){};
    
    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("_lcv-UUG8EeaDto2WJ2T9Tw")]
    [DisplayName("Cancellation Right")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRght")]
    #endif
    [IsoXmlTag("CxlRght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationRight1Choice_? CancellationRight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationRight1Choice_? CancellationRight { get; init; } 
    #else
    public CancellationRight1Choice_? CancellationRight { get; set; } 
    #endif
    
    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_8d2QSzbsEead9bDRE_1DAQ")]
    [DisplayName("Requested Future Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdFutrTradDt")]
    #endif
    [IsoXmlTag("ReqdFutrTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedFutureTradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedFutureTradeDate { get; init; } 
    #else
    public System.DateOnly? RequestedFutureTradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_8d2QUTbsEead9bDRE_1DAQ")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_8d2QUzbsEead9bDRE_1DAQ")]
    [DisplayName("Cash Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlmDt")]
    #endif
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CashSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CashSettlementDate { get; init; } 
    #else
    public System.DateOnly? CashSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_8d2QVTbsEead9bDRE_1DAQ")]
    [DisplayName("Settlement Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmMtd")]
    #endif
    [IsoXmlTag("SttlmMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 
    #else
    public DeliveryReceiptType2Code? SettlementMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Choice between additional cash in or resulting cash out.
    /// </summary>
    [IsoId("_pOZHIUHAEeaNEqIb_fgRZg")]
    [DisplayName("Additional Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlAmt")]
    #endif
    [IsoXmlTag("AddtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalAmount1Choice_? AdditionalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalAmount1Choice_? AdditionalAmount { get; init; } 
    #else
    public AdditionalAmount1Choice_? AdditionalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that the execution was subject to best execution rules as defined by MiFID.
    /// </summary>
    [IsoId("_8d2QVzbsEead9bDRE_1DAQ")]
    [DisplayName("Best Execution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BestExctn")]
    #endif
    [IsoXmlTag("BestExctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BestExecution1Code? BestExecution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BestExecution1Code? BestExecution { get; init; } 
    #else
    public BestExecution1Code? BestExecution { get; set; } 
    #endif
    
    /// <summary>
    /// Redemption leg of a switch order execution.
    /// </summary>
    [IsoId("_8d2QWTbsEead9bDRE_1DAQ")]
    [DisplayName("Redemption Leg Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedLegDtls")]
    #endif
    [IsoXmlTag("RedLegDtls")]
    public ValueList<SwitchRedemptionLegExecution4> RedemptionLegDetails { get; init; } = new ValueList<SwitchRedemptionLegExecution4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _8d2QWTbsEead9bDRE_1DAQ
    
    /// <summary>
    /// Subscription leg of a switch order execution.
    /// </summary>
    [IsoId("_8d2QWzbsEead9bDRE_1DAQ")]
    [DisplayName("Subscription Leg Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptLegDtls")]
    #endif
    [IsoXmlTag("SbcptLegDtls")]
    public ValueList<SwitchSubscriptionLegExecution4> SubscriptionLegDetails { get; init; } = new ValueList<SwitchSubscriptionLegExecution4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _8d2QWzbsEead9bDRE_1DAQ
    
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_8d2QXTbsEead9bDRE_1DAQ")]
    [DisplayName("Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlmDtls")]
    #endif
    [IsoXmlTag("CshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction71? CashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction71? CashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction71? CashSettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// Information needed to process a currency exchange or conversion.
    /// How the exchange rate is expressed determines which currency is the Unit Currency and Quoted Currency. If the amounts concerned are EUR 1000 and USD 1300, the exchange rate may be expressed as per either of the following examples:
    /// EXAMPLE 1 
    /// UnitCurrency EUR
    /// QuotedCurrency USD
    /// ExchangeRate 1.300
    /// EXAMPLE 2
    /// UnitCurrency USD
    /// QuotedCurrency EUR
    /// ExchangeRate 0.769.
    /// </summary>
    [IsoId("_8d2QXzbsEead9bDRE_1DAQ")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms33? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms33? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms33? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_8d2QYTbsEead9bDRE_1DAQ")]
    [DisplayName("Financial Advice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinAdvc")]
    #endif
    [IsoXmlTag("FinAdvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialAdvice1Code? FinancialAdvice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialAdvice1Code? FinancialAdvice { get; init; } 
    #else
    public FinancialAdvice1Code? FinancialAdvice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("_8d2QYzbsEead9bDRE_1DAQ")]
    [DisplayName("Negotiated Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NgtdTrad")]
    #endif
    [IsoXmlTag("NgtdTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; } 
    #else
    public NegotiatedTrade1Code? NegotiatedTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the order execution confirmation is late.
    /// </summary>
    [IsoId("_8d2QZTbsEead9bDRE_1DAQ")]
    [DisplayName("Late Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LateRpt")]
    #endif
    [IsoXmlTag("LateRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LateReport1Code? LateReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LateReport1Code? LateReport { get; init; } 
    #else
    public LateReport1Code? LateReport { get; set; } 
    #endif
    
    /// <summary>
    /// Assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    [IsoId("_PmHxUTlNEeaYrqEUdbYZQQ")]
    [DisplayName("Customer Conduct Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrCndctClssfctn")]
    #endif
    [IsoXmlTag("CstmrCndctClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; } 
    #else
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("_AfqQ0ToDEeabspMEjqY5TQ")]
    [DisplayName("Transaction Channel Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxChanlTp")]
    #endif
    [IsoXmlTag("TxChanlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; } 
    #else
    public TransactionChannelType1Choice_? TransactionChannelType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of signature.
    /// </summary>
    [IsoId("_ijJyEToIEeabspMEjqY5TQ")]
    [DisplayName("Signature Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgntrTp")]
    #endif
    [IsoXmlTag("SgntrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignatureType1Choice_? SignatureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignatureType1Choice_? SignatureType { get; init; } 
    #else
    public SignatureType1Choice_? SignatureType { get; set; } 
    #endif
    
    /// <summary>
    /// Information about a non-standard order.
    /// </summary>
    [IsoId("_z-EQIVAJEeal4_lvhAnyGQ")]
    [DisplayName("Order Waiver Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrWvrDtls")]
    #endif
    [IsoXmlTag("OrdrWvrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrderWaiver1? OrderWaiverDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderWaiver1? OrderWaiverDetails { get; init; } 
    #else
    public OrderWaiver1? OrderWaiverDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
