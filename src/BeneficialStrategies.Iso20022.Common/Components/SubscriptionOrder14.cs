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
/// Order to invest the investor&apos;s principal in an investment fund.
/// </summary>
[IsoId("_Cnz4NzbtEead9bDRE_1DAQ")]
[DisplayName("Subscription Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionOrder14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionOrder14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionOrder14( System.String reqOrderReference,FinancialInstrument57 reqFinancialInstrumentDetails,FinancialInstrumentQuantity27Choice_ reqAmountOrUnits,System.String reqPhysicalDeliveryIndicator )
    {
        OrderReference = reqOrderReference;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        AmountOrUnits = reqAmountOrUnits;
        PhysicalDeliveryIndicator = reqPhysicalDeliveryIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_DANJ-TbtEead9bDRE_1DAQ")]
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
    [IsoId("_DANJ-zbtEead9bDRE_1DAQ")]
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
    /// Category of the investment fund order.
    /// </summary>
    [IsoId("_DANJ_TbtEead9bDRE_1DAQ")]
    [DisplayName("Order Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrTp")]
    #endif
    [IsoXmlTag("OrdrTp")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<FundOrderType4Choice_> OrderType { get; init; } = new ValueList<FundOrderType4Choice_>(){};
    
    /// <summary>
    /// Investment fund class related to the order.
    /// </summary>
    [IsoId("_DANJ_zbtEead9bDRE_1DAQ")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument57 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Subdivision of the account used to segregate specific holdings.
    /// </summary>
    [IsoId("_DANKATbtEead9bDRE_1DAQ")]
    [DisplayName("Sub Account For Holding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctForHldg")]
    #endif
    [IsoXmlTag("SubAcctForHldg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubAccount6? SubAccountForHolding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubAccount6? SubAccountForHolding { get; init; } 
    #else
    public SubAccount6? SubAccountForHolding { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money or the number of units for the subscription order.
    /// </summary>
    [IsoId("_GtoywDhSEeaRwdGFv45qTQ")]
    [DisplayName("Amount Or Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtOrUnits")]
    #endif
    [IsoXmlTag("AmtOrUnits")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity27Choice_ AmountOrUnits { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity27Choice_ AmountOrUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity27Choice_ AmountOrUnits { get; init; } 
    #else
    public FinancialInstrumentQuantity27Choice_ AmountOrUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_DANKCTbtEead9bDRE_1DAQ")]
    [DisplayName("Rounding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rndg")]
    #endif
    [IsoXmlTag("Rndg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RoundingDirection2Code? Rounding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RoundingDirection2Code? Rounding { get; init; } 
    #else
    public RoundingDirection2Code? Rounding { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_DANKCzbtEead9bDRE_1DAQ")]
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
    [IsoId("_DANKDTbtEead9bDRE_1DAQ")]
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
    [IsoId("_DANKDzbtEead9bDRE_1DAQ")]
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
    [IsoId("_DANKETbtEead9bDRE_1DAQ")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms32? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms32? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms32? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_DANKEzbtEead9bDRE_1DAQ")]
    [DisplayName("Income Preference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmPref")]
    #endif
    [IsoXmlTag("IncmPref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncomePreference1Code? IncomePreference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncomePreference1Code? IncomePreference { get; init; } 
    #else
    public IncomePreference1Code? IncomePreference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer&apos;s actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    [IsoId("_DANKFTbtEead9bDRE_1DAQ")]
    [DisplayName("Letter Intent Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrInttRef")]
    #endif
    [IsoXmlTag("LttrInttRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LetterIntentReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LetterIntentReference { get; init; } 
    #else
    public System.String? LetterIntentReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of an accumulation right program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_DANKFzbtEead9bDRE_1DAQ")]
    [DisplayName("Accumulation Right Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcmltnRghtRef")]
    #endif
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccumulationRightReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccumulationRightReference { get; init; } 
    #else
    public System.String? AccumulationRightReference { get; set; } 
    #endif
    
    /// <summary>
    /// Fees (charges/commission) and tax to be applied to the net amount.
    /// </summary>
    [IsoId("_bOGdsDkkEeahTcrfPSjpxA")]
    [DisplayName("Transaction Overhead")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxOvrhd")]
    #endif
    [IsoXmlTag("TxOvrhd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FeeAndTax1? TransactionOverhead { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FeeAndTax1? TransactionOverhead { get; init; } 
    #else
    public FeeAndTax1? TransactionOverhead { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_DANKHzbtEead9bDRE_1DAQ")]
    [DisplayName("Settlement And Custody Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAndCtdyDtls")]
    #endif
    [IsoXmlTag("SttlmAndCtdyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundSettlementParameters11? SettlementAndCustodyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundSettlementParameters11? SettlementAndCustodyDetails { get; init; } 
    #else
    public FundSettlementParameters11? SettlementAndCustodyDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_DANKITbtEead9bDRE_1DAQ")]
    [DisplayName("Physical Delivery Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysDlvryInd")]
    #endif
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PhysicalDeliveryIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PhysicalDeliveryIndicator { get; init; } 
    #else
    public System.String PhysicalDeliveryIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    [IsoId("_DANKIzbtEead9bDRE_1DAQ")]
    [DisplayName("Physical Delivery Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysDlvryDtls")]
    #endif
    [IsoXmlTag("PhysDlvryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress4? PhysicalDeliveryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress4? PhysicalDeliveryDetails { get; init; } 
    #else
    public NameAndAddress4? PhysicalDeliveryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_DANKJTbtEead9bDRE_1DAQ")]
    [DisplayName("Requested Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSttlmCcy")]
    #endif
    [IsoXmlTag("ReqdSttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedSettlementCurrency { get; init; } 
    #else
    public string? RequestedSettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_DANKJzbtEead9bDRE_1DAQ")]
    [DisplayName("Requested NAV Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdNAVCcy")]
    #endif
    [IsoXmlTag("ReqdNAVCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedNAVCurrency { get; init; } 
    #else
    public string? RequestedNAVCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_DANKKTbtEead9bDRE_1DAQ")]
    [DisplayName("Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlmDtls")]
    #endif
    [IsoXmlTag("CshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction70? CashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction70? CashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction70? CashSettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_DANKKzbtEead9bDRE_1DAQ")]
    [DisplayName("Non Standard Settlement Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonStdSttlmInf")]
    #endif
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonStandardSettlementInformation { get; init; } 
    #else
    public System.String? NonStandardSettlementInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [IsoId("_DANKLTbtEead9bDRE_1DAQ")]
    [DisplayName("Staff Client Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StffClntBrkdwn")]
    #endif
    [IsoXmlTag("StffClntBrkdwn")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<InvestmentFundsOrderBreakdown2> StaffClientBreakdown { get; init; } = new ValueList<InvestmentFundsOrderBreakdown2>(){};
    
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_DANKLzbtEead9bDRE_1DAQ")]
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
    [IsoId("_DANKMTbtEead9bDRE_1DAQ")]
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
    /// Party related to the transaction.
    /// </summary>
    [IsoId("_DANKMzbtEead9bDRE_1DAQ")]
    [DisplayName("Related Party Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPtyDtls")]
    #endif
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary40> RelatedPartyDetails { get; init; } = new ValueList<Intermediary40>(){};
    
    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive/performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_DANKNTbtEead9bDRE_1DAQ")]
    [DisplayName("Equalisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Equlstn")]
    #endif
    [IsoXmlTag("Equlstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Equalisation1? Equalisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Equalisation1? Equalisation { get; init; } 
    #else
    public Equalisation1? Equalisation { get; set; } 
    #endif
    
    /// <summary>
    /// Source of cash used for the settlement of the subscription.
    /// </summary>
    [IsoId("_hXHc0DlEEealR6-8aQ15BA")]
    [DisplayName("Source Of Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcOfCsh")]
    #endif
    [IsoXmlTag("SrcOfCsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SourceOfCash1Choice_? SourceOfCash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SourceOfCash1Choice_? SourceOfCash { get; init; } 
    #else
    public SourceOfCash1Choice_? SourceOfCash { get; set; } 
    #endif
    
    /// <summary>
    /// Assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    [IsoId("_EfaioTlNEeaYrqEUdbYZQQ")]
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
    [IsoId("_JxDZIToCEeabspMEjqY5TQ")]
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
    [IsoId("_Z4JmQToHEeabspMEjqY5TQ")]
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
    [IsoId("_4mJ1kToQEeabspMEjqY5TQ")]
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
