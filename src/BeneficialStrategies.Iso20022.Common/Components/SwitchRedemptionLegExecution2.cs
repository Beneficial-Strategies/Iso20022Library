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
/// Execution of the redemption part, in a switch between investment funds or investment fund classes.
/// </summary>
[IsoId("_VWBAgtp-Ed-ak6NoX_4Aeg_-733728591")]
[DisplayName("Switch Redemption Leg Execution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SwitchRedemptionLegExecution2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SwitchRedemptionLegExecution2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SwitchRedemptionLegExecution2( FinancialInstrument6 reqFinancialInstrumentDetails,FinancialInstrumentQuantity1 reqUnitsNumber,ActiveCurrencyAndAmount reqNetAmount,DateAndDateTimeChoice_ reqTradeDateTime,UnitPrice5 reqPriceDetails,System.String reqCumDividendIndicator,System.String reqPhysicalDeliveryIndicator )
    {
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        UnitsNumber = reqUnitsNumber;
        NetAmount = reqNetAmount;
        TradeDateTime = reqTradeDateTime;
        PriceDetails = reqPriceDetails;
        CumDividendIndicator = reqCumDividendIndicator;
        PhysicalDeliveryIndicator = reqPhysicalDeliveryIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_VWBAg9p-Ed-ak6NoX_4Aeg_-733727652")]
    [DisplayName("Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegId")]
    #endif
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegIdentification { get; init; } 
    #else
    public System.String? LegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for an instance of a leg execution within a switch confirmation.
    /// </summary>
    [IsoId("_VWKxcNp-Ed-ak6NoX_4Aeg_-733727635")]
    [DisplayName("Leg Execution Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegExctnId")]
    #endif
    [IsoXmlTag("LegExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LegExecutionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegExecutionIdentification { get; init; } 
    #else
    public System.String? LegExecutionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Investment fund class to which an investment fund order execution is related.
    /// </summary>
    [IsoId("_VWKxcdp-Ed-ak6NoX_4Aeg_-732807532")]
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
    /// Number of investment funds units redeemed.
    /// </summary>
    [IsoId("_VWKxctp-Ed-ak6NoX_4Aeg_-733728565")]
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
    /// Portion of the investor&apos;s holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    [IsoId("_VWKxc9p-Ed-ak6NoX_4Aeg_-733728265")]
    [DisplayName("Holdings Redemption Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgsRedRate")]
    #endif
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? HoldingsRedemptionRate { get; init; } 
    #else
    public System.Decimal? HoldingsRedemptionRate { get; set; } 
    #endif
    
    /// <summary>
    /// Net amount of money paid to the investor as a result of the redemption.
    /// </summary>
    [IsoId("_VWKxdNp-Ed-ak6NoX_4Aeg_-733728548")]
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
    /// Gross amount of money as a result of the redemption.
    /// </summary>
    [IsoId("_VWKxddp-Ed-ak6NoX_4Aeg_-733728531")]
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
    [IsoId("_VWKxdtp-Ed-ak6NoX_4Aeg_-733728170")]
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
    [IsoId("_VWKxd9p-Ed-ak6NoX_4Aeg_-733727616")]
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
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_VWKxeNp-Ed-ak6NoX_4Aeg_-733728144")]
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
    [IsoId("_VWKxedp-Ed-ak6NoX_4Aeg_-733727695")]
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
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_VWT7YNp-Ed-ak6NoX_4Aeg_-733728007")]
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
    [IsoId("_VWT7Ydp-Ed-ak6NoX_4Aeg_-733727737")]
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
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_VWT7Ytp-Ed-ak6NoX_4Aeg_932528977")]
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
    [IsoId("_VWT7Y9p-Ed-ak6NoX_4Aeg_932529072")]
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
    /// Charge for the execution of an order.
    /// </summary>
    [IsoId("_VWT7ZNp-Ed-ak6NoX_4Aeg_-732807585")]
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
    /// Commission for the execution of an investment fund order.
    /// </summary>
    [IsoId("_VWT7Zdp-Ed-ak6NoX_4Aeg_-732807550")]
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
    /// Tax applicable to execution of an investment fund order.
    /// </summary>
    [IsoId("_VWT7Ztp-Ed-ak6NoX_4Aeg_-732807602")]
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
    [IsoId("_VWT7Z9p-Ed-ak6NoX_4Aeg_-732807431")]
    [DisplayName("Settlement And Custody Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAndCtdyDtls")]
    #endif
    [IsoXmlTag("SttlmAndCtdyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; init; } 
    #else
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_VWT7aNp-Ed-ak6NoX_4Aeg_-733727677")]
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
    [IsoId("_VWT7adp-Ed-ak6NoX_4Aeg_-732807471")]
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
    
    
    #nullable disable
    
}
