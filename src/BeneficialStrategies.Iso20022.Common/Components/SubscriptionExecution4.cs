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
[IsoId("_VU0tpNp-Ed-ak6NoX_4Aeg_553787060")]
[DisplayName("Subscription Execution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionExecution4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionExecution4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionExecution4( System.String reqOrderReference,System.String reqDealReference,FinancialInstrument6 reqFinancialInstrumentDetails,FinancialInstrumentQuantity1 reqUnitsNumber,ActiveCurrencyAndAmount reqNetAmount,DateAndDateTimeChoice_ reqTradeDateTime,UnitPrice5 reqPriceDetails,System.String reqPartiallyExecutedIndicator,System.String reqCumDividendIndicator,System.String reqPhysicalDeliveryIndicator )
    {
        OrderReference = reqOrderReference;
        DealReference = reqDealReference;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
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
    [IsoId("_VU0tpdp-Ed-ak6NoX_4Aeg_553787544")]
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
    [IsoId("_VU0tptp-Ed-ak6NoX_4Aeg_553788103")]
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
    [IsoId("_VU0tp9p-Ed-ak6NoX_4Aeg_554712170")]
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
    /// Investment fund class to which an investment fund order execution is related.
    /// </summary>
    [IsoId("_VU0tqNp-Ed-ak6NoX_4Aeg_565792841")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument6 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument6 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Number of investment fund units subscribed.
    /// </summary>
    [IsoId("_VU0tqdp-Ed-ak6NoX_4Aeg_553788163")]
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
    [IsoId("_VU0tqtp-Ed-ak6NoX_4Aeg_1042367480")]
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
    [IsoId("_VU0tq9p-Ed-ak6NoX_4Aeg_553788553")]
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
    [IsoId("_VU-eoNp-Ed-ak6NoX_4Aeg_553789543")]
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
    [IsoId("_VU-eodp-Ed-ak6NoX_4Aeg_553790006")]
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
    [IsoId("_VU-eotp-Ed-ak6NoX_4Aeg_566717335")]
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
    [IsoId("_VU-eo9p-Ed-ak6NoX_4Aeg_554711187")]
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
    [IsoId("_VU-epNp-Ed-ak6NoX_4Aeg_554711685")]
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
    [IsoId("_VU-epdp-Ed-ak6NoX_4Aeg_554710643")]
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
    [IsoId("_VU-eptp-Ed-ak6NoX_4Aeg_556559608")]
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
    [IsoId("_VU-ep9p-Ed-ak6NoX_4Aeg_553790534")]
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
    [IsoId("_VU-eqNp-Ed-ak6NoX_4Aeg_554711085")]
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
    [IsoId("_VU-eqdp-Ed-ak6NoX_4Aeg_554710738")]
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
    [IsoId("_VVHokNp-Ed-ak6NoX_4Aeg_555636570")]
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
    [IsoId("_VVHokdp-Ed-ak6NoX_4Aeg_564871801")]
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
    [IsoId("_VVHoktp-Ed-ak6NoX_4Aeg_555634260")]
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
    [IsoId("_VVHok9p-Ed-ak6NoX_4Aeg_564870230")]
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
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_VVHolNp-Ed-ak6NoX_4Aeg_554712555")]
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
    [IsoId("_VVHoldp-Ed-ak6NoX_4Aeg_566717923")]
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
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_VVHoltp-Ed-ak6NoX_4Aeg_554711530")]
    [DisplayName("Requested Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSttlmCcy")]
    #endif
    [IsoXmlTag("ReqdSttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? RequestedSettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedSettlementCurrency { get; init; } 
    #else
    public string? RequestedSettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_VVHol9p-Ed-ak6NoX_4Aeg_554712040")]
    [DisplayName("Requested NAV Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdNAVCcy")]
    #endif
    [IsoXmlTag("ReqdNAVCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? RequestedNAVCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedNAVCurrency { get; init; } 
    #else
    public string? RequestedNAVCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Return of cash that has been overpaid for a subscription.
    /// </summary>
    [IsoId("_VVHomNp-Ed-ak6NoX_4Aeg_554712659")]
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
    [IsoId("_VVHomdp-Ed-ak6NoX_4Aeg_554712988")]
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
    [IsoId("_VVRZkNp-Ed-ak6NoX_4Aeg_556558190")]
    [DisplayName("Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlmDtls")]
    #endif
    [IsoXmlTag("CshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction13? CashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction13? CashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction13? CashSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
