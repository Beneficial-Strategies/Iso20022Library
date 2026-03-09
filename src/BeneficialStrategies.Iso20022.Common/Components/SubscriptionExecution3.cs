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
/// Execution of a subscription order.
/// </summary>
[IsoId("_VUYBttp-Ed-ak6NoX_4Aeg_127522648")]
[DisplayName("Subscription Execution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionExecution3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionExecution3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionExecution3( System.String reqOrderReference,System.String reqDealReference,InvestmentAccount13 reqInvestmentAccountDetails,FinancialInstrumentQuantity1 reqUnitsNumber,ActiveCurrencyAndAmount reqNetAmount,DateAndDateTimeChoice_ reqTradeDateTime,UnitPrice5 reqPriceDetails,System.String reqPartiallyExecutedIndicator,System.String reqCumDividendIndicator,System.String reqPhysicalDeliveryIndicator )
    {
        OrderReference = reqOrderReference;
        DealReference = reqDealReference;
        InvestmentAccountDetails = reqInvestmentAccountDetails;
        UnitsNumber = reqUnitsNumber;
        NetAmount = reqNetAmount;
        TradeDateTime = reqTradeDateTime;
        PriceDetails = reqPriceDetails;
        PartiallyExecutedIndicator = reqPartiallyExecutedIndicator;
        CumDividendIndicator = reqCumDividendIndicator;
        PhysicalDeliveryIndicator = reqPhysicalDeliveryIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_VUYBt9p-Ed-ak6NoX_4Aeg_127522650")]
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
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_VUYBuNp-Ed-ak6NoX_4Aeg_127522938")]
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
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_VUYBudp-Ed-ak6NoX_4Aeg_127523146")]
    [DisplayName("Order Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrTp")]
    #endif
    [IsoXmlTag("OrdrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundOrderType1? OrderType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundOrderType1? OrderType { get; init; } 
    #else
    public FundOrderType1? OrderType { get; set; } 
    #endif
    
    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_VUYButp-Ed-ak6NoX_4Aeg_127523545")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount13 InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_VUYBu9p-Ed-ak6NoX_4Aeg_1870990737")]
    [DisplayName("Beneficiary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryDtls")]
    #endif
    [IsoXmlTag("BnfcryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    #else
    public IndividualPerson2? BeneficiaryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Number of investment fund units subscribed.
    /// </summary>
    [IsoId("_VUYBvNp-Ed-ak6NoX_4Aeg_127522956")]
    [DisplayName("Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsNb")]
    #endif
    [IsoXmlTag("UnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1 UnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_VUhysNp-Ed-ak6NoX_4Aeg_226024618")]
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
    /// Net amount of money invested in a specific financial instrument by an investor, expressed in the currency requested by the investor.
    /// </summary>
    [IsoId("_VUhysdp-Ed-ak6NoX_4Aeg_127522973")]
    [DisplayName("Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmt")]
    #endif
    [IsoXmlTag("NetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount NetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount NetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount NetAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount NetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money invested in a specific financial instrument by an investor, including all charges, commissions, and tax, expressed in the currency requested by the investor.
    /// </summary>
    [IsoId("_VUhystp-Ed-ak6NoX_4Aeg_127522991")]
    [DisplayName("Gross Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssAmt")]
    #endif
    [IsoXmlTag("GrssAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? GrossAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? GrossAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? GrossAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_VUhys9p-Ed-ak6NoX_4Aeg_127523016")]
    [DisplayName("Trade Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtTm")]
    #endif
    [IsoXmlTag("TradDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ TradeDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_VUhytNp-Ed-ak6NoX_4Aeg_127523888")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitPrice5 PriceDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitPrice5 PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitPrice5 PriceDetails { get; init; } 
    #else
    public UnitPrice5 PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the order has been partially executed, ie, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("_VUhytdp-Ed-ak6NoX_4Aeg_127523111")]
    [DisplayName("Partially Executed Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlyExctdInd")]
    #endif
    [IsoXmlTag("PrtlyExctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PartiallyExecutedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PartiallyExecutedIndicator { get; init; } 
    #else
    public System.String PartiallyExecutedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_VUhyttp-Ed-ak6NoX_4Aeg_127523128")]
    [DisplayName("Cum Dividend Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CumDvddInd")]
    #endif
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CumDividendIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CumDividendIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CumDividendIndicator { get; init; } 
    #else
    public System.String CumDividendIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    [IsoId("_VUhyt9p-Ed-ak6NoX_4Aeg_127523051")]
    [DisplayName("Interim Profit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmPrftAmt")]
    #endif
    [IsoXmlTag("IntrmPrftAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProfitAndLoss1Choice_? InterimProfitAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProfitAndLoss1Choice_? InterimProfitAmount { get; init; } 
    #else
    public ProfitAndLoss1Choice_? InterimProfitAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_VUhyuNp-Ed-ak6NoX_4Aeg_127523527")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms4? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms4? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms4? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_VUhyudp-Ed-ak6NoX_4Aeg_127523033")]
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
    [IsoId("_VUq8oNp-Ed-ak6NoX_4Aeg_127523093")]
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
    [IsoId("_VUq8odp-Ed-ak6NoX_4Aeg_127523076")]
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
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_VUq8otp-Ed-ak6NoX_4Aeg_127523580")]
    [DisplayName("Charge General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgGnlDtls")]
    #endif
    [IsoXmlTag("ChrgGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalCharges2? ChargeGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalCharges2? ChargeGeneralDetails { get; init; } 
    #else
    public TotalCharges2? ChargeGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_VUq8o9p-Ed-ak6NoX_4Aeg_127523622")]
    [DisplayName("Commission General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnGnlDtls")]
    #endif
    [IsoXmlTag("ComssnGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalCommissions2? CommissionGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalCommissions2? CommissionGeneralDetails { get; init; } 
    #else
    public TotalCommissions2? CommissionGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Tax related to an investment fund order.
    /// </summary>
    [IsoId("_VUq8pNp-Ed-ak6NoX_4Aeg_127523467")]
    [DisplayName("Tax General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxGnlDtls")]
    #endif
    [IsoXmlTag("TaxGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalTaxes2? TaxGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalTaxes2? TaxGeneralDetails { get; init; } 
    #else
    public TotalTaxes2? TaxGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_VUq8pdp-Ed-ak6NoX_4Aeg_127523485")]
    [DisplayName("Settlement And Custody Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAndCtdyDtls")]
    #endif
    [IsoXmlTag("SttlmAndCtdyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; } 
    #else
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the securities are to be physically delivered.
    /// </summary>
    [IsoId("_VUq8ptp-Ed-ak6NoX_4Aeg_127523171")]
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
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_VUq8p9p-Ed-ak6NoX_4Aeg_127523949")]
    [DisplayName("Physical Delivery Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysDlvryDtls")]
    #endif
    [IsoXmlTag("PhysDlvryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    #else
    public DeliveryParameters3? PhysicalDeliveryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Return of cash that has been overpaid for a subscription.
    /// </summary>
    [IsoId("_VUq8qNp-Ed-ak6NoX_4Aeg_127523188")]
    [DisplayName("Refund")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rfnd")]
    #endif
    [IsoXmlTag("Rfnd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? Refund { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? Refund { get; init; } 
    #else
    public ActiveCurrencyAndAmount? Refund { get; set; } 
    #endif
    
    /// <summary>
    /// Interest received when a subscription amount is paid in advance and then invested by the fund.
    /// </summary>
    [IsoId("_VUq8qdp-Ed-ak6NoX_4Aeg_127523206")]
    [DisplayName("Subscription Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptIntrst")]
    #endif
    [IsoXmlTag("SbcptIntrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SubscriptionInterest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SubscriptionInterest { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SubscriptionInterest { get; set; } 
    #endif
    
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VU0toNp-Ed-ak6NoX_4Aeg_-1465208436")]
    [DisplayName("Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlmDtls")]
    #endif
    [IsoXmlTag("CshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction16? CashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction16? CashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction16? CashSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
