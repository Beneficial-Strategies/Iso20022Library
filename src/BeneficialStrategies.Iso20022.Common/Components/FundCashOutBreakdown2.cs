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
/// Breakdown of cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
/// </summary>
[IsoId("_SjDJlNp-Ed-ak6NoX_4Aeg_-2020690769")]
[DisplayName("Fund Cash Out Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundCashOutBreakdown2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundCashOutBreakdown2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundCashOutBreakdown2( InvestmentFundTransactionOutType1Code reqInvestmentFundTransactionOutType,System.String reqExtendedInvestmentFundTransactionOutType,OrderQuantityType2Code reqOriginalOrderQuantityType,System.String reqExtendedOriginalOrderQuantityType )
    {
        InvestmentFundTransactionOutType = reqInvestmentFundTransactionOutType;
        ExtendedInvestmentFundTransactionOutType = reqExtendedInvestmentFundTransactionOutType;
        OriginalOrderQuantityType = reqOriginalOrderQuantityType;
        ExtendedOriginalOrderQuantityType = reqExtendedOriginalOrderQuantityType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of cash flow out, expressed as an amount of money.
    /// </summary>
    [IsoId("_SjDJldp-Ed-ak6NoX_4Aeg_-2019770158")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the cash flow out, expressed as a number of units.
    /// </summary>
    [IsoId("_SjDJltp-Ed-ak6NoX_4Aeg_-2019769690")]
    [DisplayName("Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsNb")]
    #endif
    [IsoXmlTag("UnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? UnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? UnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1? UnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the cash flow is an item that did not appear on the previously sent report, eg, because it was received close to cut-off time.
    /// </summary>
    [IsoId("_SjDJl9p-Ed-ak6NoX_4Aeg_-2019769305")]
    [DisplayName("New Amount Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewAmtInd")]
    #endif
    [IsoXmlTag("NewAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NewAmountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NewAmountIndicator { get; init; } 
    #else
    public System.String? NewAmountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the cash movements out of a fund by transaction type, eg, redemption, switch-out.
    /// </summary>
    [IsoId("_SjDJmNp-Ed-ak6NoX_4Aeg_881142863")]
    [DisplayName("Investment Fund Transaction Out Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtFndTxOutTp")]
    #endif
    [IsoXmlTag("InvstmtFndTxOutTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentFundTransactionOutType1Code InvestmentFundTransactionOutType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentFundTransactionOutType1Code InvestmentFundTransactionOutType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundTransactionOutType1Code InvestmentFundTransactionOutType { get; init; } 
    #else
    public InvestmentFundTransactionOutType1Code InvestmentFundTransactionOutType { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the cash movements out of a fund by transaction type, eg, redemption, switch-out.
    /// </summary>
    [IsoId("_SjM6kNp-Ed-ak6NoX_4Aeg_881142898")]
    [DisplayName("Extended Investment Fund Transaction Out Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedInvstmtFndTxOutTp")]
    #endif
    [IsoXmlTag("XtndedInvstmtFndTxOutTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedInvestmentFundTransactionOutType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedInvestmentFundTransactionOutType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedInvestmentFundTransactionOutType { get; init; } 
    #else
    public System.String ExtendedInvestmentFundTransactionOutType { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the cash movements into a fund by order type, eg, order by quantity of units or amount of money.
    /// </summary>
    [IsoId("_SjM6kdp-Ed-ak6NoX_4Aeg_881143175")]
    [DisplayName("Original Order Quantity Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlOrdrQtyTp")]
    #endif
    [IsoXmlTag("OrgnlOrdrQtyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderQuantityType2Code OriginalOrderQuantityType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderQuantityType2Code OriginalOrderQuantityType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderQuantityType2Code OriginalOrderQuantityType { get; init; } 
    #else
    public OrderQuantityType2Code OriginalOrderQuantityType { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the cash movements into a fund by transaction type, eg, subscription, switch-in.
    /// </summary>
    [IsoId("_SjM6ktp-Ed-ak6NoX_4Aeg_881143235")]
    [DisplayName("Extended Original Order Quantity Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedOrgnlOrdrQtyTp")]
    #endif
    [IsoXmlTag("XtndedOrgnlOrdrQtyTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedOriginalOrderQuantityType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedOriginalOrderQuantityType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedOriginalOrderQuantityType { get; init; } 
    #else
    public System.String ExtendedOriginalOrderQuantityType { get; set; } 
    #endif
    
    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    [IsoId("_SjM6k9p-Ed-ak6NoX_4Aeg_2117714463")]
    [DisplayName("Charge Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgDtls")]
    #endif
    [IsoXmlTag("ChrgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge16? ChargeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge16? ChargeDetails { get; init; } 
    #else
    public Charge16? ChargeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the commission applied to an order, eg, back-end or front-end commission.
    /// </summary>
    [IsoId("_SjM6lNp-Ed-ak6NoX_4Aeg_-2019767882")]
    [DisplayName("Commission Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnDtls")]
    #endif
    [IsoXmlTag("ComssnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commission9? CommissionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commission9? CommissionDetails { get; init; } 
    #else
    public Commission9? CommissionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
