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
/// Instruction from an investor to sell investment fund units back to the fund.
/// </summary>
[IsoId("_SCHmxdp-Ed-ak6NoX_4Aeg_37944764")]
[DisplayName("Redemption Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RedemptionOrder8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RedemptionOrder8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RedemptionOrder8( System.String reqOrderReference,FinancialInstrument10 reqFinancialInstrumentDetails,FinancialInstrumentQuantity1 reqUnitsNumber,ActiveOrHistoricCurrencyAndAmount reqGrossAmount,ActiveOrHistoricCurrencyAndAmount reqNetAmount,System.Decimal reqHoldingsRedemptionRate,System.String reqPhysicalDeliveryIndicator )
    {
        OrderReference = reqOrderReference;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        UnitsNumber = reqUnitsNumber;
        GrossAmount = reqGrossAmount;
        NetAmount = reqNetAmount;
        HoldingsRedemptionRate = reqHoldingsRedemptionRate;
        PhysicalDeliveryIndicator = reqPhysicalDeliveryIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SCRXwNp-Ed-ak6NoX_4Aeg_37944991")]
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
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_SCRXwdp-Ed-ak6NoX_4Aeg_37945024")]
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
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_SCRXwtp-Ed-ak6NoX_4Aeg_38865738")]
    [DisplayName("Order Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrTp")]
    #endif
    [IsoXmlTag("OrdrTp")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<FundOrderType2> OrderType { get; init; } = new ValueList<FundOrderType2>(){};
    
    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_SCRXw9p-Ed-ak6NoX_4Aeg_38865367")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument10 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument10 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Subdivision of an account used to segregate specific holdings.
    /// </summary>
    [IsoId("_SCRXxNp-Ed-ak6NoX_4Aeg_1022714760")]
    [DisplayName("Sub Account For Holding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctForHldg")]
    #endif
    [IsoXmlTag("SubAcctForHldg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubAccount1? SubAccountForHolding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubAccount1? SubAccountForHolding { get; init; } 
    #else
    public SubAccount1? SubAccountForHolding { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of investment fund units redeemed.
    /// </summary>
    [IsoId("_SCRXxdp-Ed-ak6NoX_4Aeg_37945119")]
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
    /// Amount of money used to derive the quantity of investment fund units to be sold, before deduction of charges, commissions, and taxes.|[Quantity * Price].
    /// </summary>
    [IsoId("_SCRXxtp-Ed-ak6NoX_4Aeg_38865203")]
    [DisplayName("Gross Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssAmt")]
    #endif
    [IsoXmlTag("GrssAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount GrossAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount GrossAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount GrossAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount GrossAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be received following redemption after deduction of charges, commissions and taxes and used to derive the quantity of investment fund units to be sold.|[(Quantity * Price) - (Charges + Commissions +Taxes)].
    /// </summary>
    [IsoId("_SCRXx9p-Ed-ak6NoX_4Aeg_38865150")]
    [DisplayName("Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmt")]
    #endif
    [IsoXmlTag("NetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount NetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount NetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount NetAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount NetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    [IsoId("_SCRXyNp-Ed-ak6NoX_4Aeg_38865185")]
    [DisplayName("Holdings Redemption Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgsRedRate")]
    #endif
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate HoldingsRedemptionRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal HoldingsRedemptionRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal HoldingsRedemptionRate { get; init; } 
    #else
    public System.Decimal HoldingsRedemptionRate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_SCRXydp-Ed-ak6NoX_4Aeg_38865168")]
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
    [IsoId("_SCbIwNp-Ed-ak6NoX_4Aeg_-161727731")]
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
    [IsoId("_SCbIwdp-Ed-ak6NoX_4Aeg_-161727636")]
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
    [IsoId("_SCbIwtp-Ed-ak6NoX_4Aeg_-1877883033")]
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
    /// </summary>
    [IsoId("_SCbIw9p-Ed-ak6NoX_4Aeg_38865401")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_SCbIxNp-Ed-ak6NoX_4Aeg_38865228")]
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
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_SCbIxdp-Ed-ak6NoX_4Aeg_38865245")]
    [DisplayName("Group 1 Or 2 Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grp1Or2Units")]
    #endif
    [IsoXmlTag("Grp1Or2Units")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; } 
    #else
    public UKTaxGroupUnitCode? Group1Or2Units { get; set; } 
    #endif
    
    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    [IsoId("_SCbIxtp-Ed-ak6NoX_4Aeg_38866064")]
    [DisplayName("Charge Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgDtls")]
    #endif
    [IsoXmlTag("ChrgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge17? ChargeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge17? ChargeDetails { get; init; } 
    #else
    public Charge17? ChargeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_SCbIx9p-Ed-ak6NoX_4Aeg_38866124")]
    [DisplayName("Commission Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnDtls")]
    #endif
    [IsoXmlTag("ComssnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commission10? CommissionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commission10? CommissionDetails { get; init; } 
    #else
    public Commission10? CommissionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    [IsoId("_SCbIyNp-Ed-ak6NoX_4Aeg_1147799801")]
    [DisplayName("Tax Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDtls")]
    #endif
    [IsoXmlTag("TaxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax16? TaxDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax16? TaxDetails { get; init; } 
    #else
    public Tax16? TaxDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_SCbIydp-Ed-ak6NoX_4Aeg_38865678")]
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
    [IsoId("_SCkSsNp-Ed-ak6NoX_4Aeg_38865263")]
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
    [IsoId("_SCkSsdp-Ed-ak6NoX_4Aeg_38865636")]
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
    [IsoId("_SCkSstp-Ed-ak6NoX_4Aeg_38865288")]
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
    [IsoId("_SCkSs9p-Ed-ak6NoX_4Aeg_38865305")]
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
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_SCkStNp-Ed-ak6NoX_4Aeg_38865773")]
    [DisplayName("Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlmDtls")]
    #endif
    [IsoXmlTag("CshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction21? CashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction21? CashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction21? CashSettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_SCkStdp-Ed-ak6NoX_4Aeg_38865323")]
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
    [IsoId("_SCkSttp-Ed-ak6NoX_4Aeg_1831318287")]
    [DisplayName("Staff Client Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StffClntBrkdwn")]
    #endif
    [IsoXmlTag("StffClntBrkdwn")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<InvestmentFundsOrderBreakdown1> StaffClientBreakdown { get; init; } = new ValueList<InvestmentFundsOrderBreakdown1>(){};
    
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_SCkSt9p-Ed-ak6NoX_4Aeg_1238617280")]
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
    [IsoId("_SCkSuNp-Ed-ak6NoX_4Aeg_-1144774982")]
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
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_SCkSudp-Ed-ak6NoX_4Aeg_38865721")]
    [DisplayName("Related Party Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPtyDtls")]
    #endif
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary8> RelatedPartyDetails { get; init; } = new ValueList<Intermediary8>(){};
    
    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_SCuDsNp-Ed-ak6NoX_4Aeg_-469047396")]
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
    
    
    #nullable disable
    
}
