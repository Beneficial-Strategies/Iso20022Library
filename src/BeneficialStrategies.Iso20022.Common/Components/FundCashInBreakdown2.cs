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
/// Breakdown of cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
/// </summary>
[IsoId("_SjM6m9p-Ed-ak6NoX_4Aeg_-1373036480")]
[DisplayName("Fund Cash In Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundCashInBreakdown2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundCashInBreakdown2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundCashInBreakdown2( InvestmentFundTransactionInType1Code reqInvestmentFundTransactionInType,System.String reqExtendedInvestmentFundTransactionInType,OrderQuantityType2Code reqOriginalOrderQuantityType,System.String reqExtendedOriginalOrderQuantityType )
    {
        InvestmentFundTransactionInType = reqInvestmentFundTransactionInType;
        ExtendedInvestmentFundTransactionInType = reqExtendedInvestmentFundTransactionInType;
        OriginalOrderQuantityType = reqOriginalOrderQuantityType;
        ExtendedOriginalOrderQuantityType = reqExtendedOriginalOrderQuantityType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of cash flow in, expressed as an amount of money.
    /// </summary>
    [IsoId("_SjM6nNp-Ed-ak6NoX_4Aeg_-1364728168")]
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
    /// Amount of the cash flow in, expressed as a number of units.
    /// </summary>
    [IsoId("_SjM6ndp-Ed-ak6NoX_4Aeg_-1364727995")]
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
    [IsoId("_SjWrkNp-Ed-ak6NoX_4Aeg_-1364727255")]
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
    /// Breakdown of the cash movements into a fund by transaction type, eg, subscription, switch-in.
    /// </summary>
    [IsoId("_SjWrkdp-Ed-ak6NoX_4Aeg_-1160974452")]
    [DisplayName("Investment Fund Transaction In Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtFndTxInTp")]
    #endif
    [IsoXmlTag("InvstmtFndTxInTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentFundTransactionInType1Code InvestmentFundTransactionInType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentFundTransactionInType1Code InvestmentFundTransactionInType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundTransactionInType1Code InvestmentFundTransactionInType { get; init; } 
    #else
    public InvestmentFundTransactionInType1Code InvestmentFundTransactionInType { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the cash movements into a fund by transaction type, eg, subscription, switch-in.
    /// </summary>
    [IsoId("_SjWrktp-Ed-ak6NoX_4Aeg_-1118608528")]
    [DisplayName("Extended Investment Fund Transaction In Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedInvstmtFndTxInTp")]
    #endif
    [IsoXmlTag("XtndedInvstmtFndTxInTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedInvestmentFundTransactionInType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedInvestmentFundTransactionInType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedInvestmentFundTransactionInType { get; init; } 
    #else
    public System.String ExtendedInvestmentFundTransactionInType { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the cash movements into a fund by order type, eg, order by quantity of units or amount of money.
    /// </summary>
    [IsoId("_SjWrk9p-Ed-ak6NoX_4Aeg_1971493639")]
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
    [IsoId("_SjWrlNp-Ed-ak6NoX_4Aeg_-1850633433")]
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
    [IsoId("_SjWrldp-Ed-ak6NoX_4Aeg_1648566786")]
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
    [IsoId("_SjWrltp-Ed-ak6NoX_4Aeg_-1363801795")]
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
