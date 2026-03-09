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
[IsoId("_VdBAW9p-Ed-ak6NoX_4Aeg_77313367")]
[DisplayName("Redemption Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RedemptionOrder4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RedemptionOrder4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RedemptionOrder4( System.String reqOrderReference,FinancialInstrument6 reqFinancialInstrumentDetails,FinancialInstrumentQuantity1 reqUnitsNumber,ActiveOrHistoricCurrencyAndAmount reqNetAmount,System.Decimal reqHoldingsRedemptionRate,System.String reqPhysicalDeliveryIndicator )
    {
        OrderReference = reqOrderReference;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        UnitsNumber = reqUnitsNumber;
        NetAmount = reqNetAmount;
        HoldingsRedemptionRate = reqHoldingsRedemptionRate;
        PhysicalDeliveryIndicator = reqPhysicalDeliveryIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_VdKxUNp-Ed-ak6NoX_4Aeg_77313376")]
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
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_VdKxUdp-Ed-ak6NoX_4Aeg_77313548")]
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
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_VdKxUtp-Ed-ak6NoX_4Aeg_77313801")]
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
    /// Quantity of investment fund units redeemed.
    /// </summary>
    [IsoId("_VdKxU9p-Ed-ak6NoX_4Aeg_77313410")]
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
    /// Amount of money used to derive the quantity of investment fund units to be sold.
    /// </summary>
    [IsoId("_VdKxVNp-Ed-ak6NoX_4Aeg_77313411")]
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
    [IsoId("_VdKxVdp-Ed-ak6NoX_4Aeg_77313453")]
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
    [IsoId("_VdKxVtp-Ed-ak6NoX_4Aeg_-1252128766")]
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
    /// Amount of money used to derive the quantity of investment fund units to be sold, including all charges, commissions, and tax.
    /// </summary>
    [IsoId("_VdKxV9p-Ed-ak6NoX_4Aeg_77313428")]
    [DisplayName("Gross Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssAmt")]
    #endif
    [IsoXmlTag("GrssAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_VdKxWNp-Ed-ak6NoX_4Aeg_223517708")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms5? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms5? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms5? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_VdKxWdp-Ed-ak6NoX_4Aeg_77313505")]
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
    [IsoId("_VdUiUNp-Ed-ak6NoX_4Aeg_77313523")]
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
    [IsoId("_VdUiUdp-Ed-ak6NoX_4Aeg_77313956")]
    [DisplayName("Charge Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgDtls")]
    #endif
    [IsoXmlTag("ChrgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge8? ChargeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge8? ChargeDetails { get; init; } 
    #else
    public Charge8? ChargeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Commission linked to the execution of an investment fund order.
    /// </summary>
    [IsoId("_VdUiUtp-Ed-ak6NoX_4Aeg_77313938")]
    [DisplayName("Commission Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnDtls")]
    #endif
    [IsoXmlTag("ComssnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commission6? CommissionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commission6? CommissionDetails { get; init; } 
    #else
    public Commission6? CommissionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    [IsoId("_VdUiU9p-Ed-ak6NoX_4Aeg_77313843")]
    [DisplayName("Tax Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDtls")]
    #endif
    [IsoXmlTag("TaxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax6? TaxDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax6? TaxDetails { get; init; } 
    #else
    public Tax6? TaxDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_VdUiVNp-Ed-ak6NoX_4Aeg_77313861")]
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
    [IsoId("_VdUiVdp-Ed-ak6NoX_4Aeg_77313565")]
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
    [IsoId("_VdUiVtp-Ed-ak6NoX_4Aeg_77313903")]
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
    [IsoId("_VdUiV9p-Ed-ak6NoX_4Aeg_77313470")]
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
    [IsoId("_VdUiWNp-Ed-ak6NoX_4Aeg_77313488")]
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
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VdUiWdp-Ed-ak6NoX_4Aeg_77314265")]
    [DisplayName("Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlmDtls")]
    #endif
    [IsoXmlTag("CshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction15? CashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction15? CashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction15? CashSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
