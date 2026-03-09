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
[IsoId("_VBwAo9p-Ed-ak6NoX_4Aeg_-855958594")]
[DisplayName("Fund Cash In Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundCashInBreakdown1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of cash flow in, expressed as an amount of money.
    /// </summary>
    [IsoId("_VBwApNp-Ed-ak6NoX_4Aeg_-578901921")]
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
    [IsoId("_VBwApdp-Ed-ak6NoX_4Aeg_-871053048")]
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
    [IsoId("_VBwAptp-Ed-ak6NoX_4Aeg_-566898010")]
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
    [IsoId("_VBwAp9p-Ed-ak6NoX_4Aeg_358470141")]
    [DisplayName("Investment Fund Transaction In Type Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtFndTxInTpDtls")]
    #endif
    [IsoXmlTag("InvstmtFndTxInTpDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentFundTransactionInType1? InvestmentFundTransactionInTypeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundTransactionInType1? InvestmentFundTransactionInTypeDetails { get; init; } 
    #else
    public InvestmentFundTransactionInType1? InvestmentFundTransactionInTypeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the cash movements into a fund by order type, eg, order by quantity of units or amount of money.
    /// </summary>
    [IsoId("_VBwAqNp-Ed-ak6NoX_4Aeg_31543655")]
    [DisplayName("Original Order Quantity Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlOrdrQtyDtls")]
    #endif
    [IsoXmlTag("OrgnlOrdrQtyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalOrderQuantityType1? OriginalOrderQuantityDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalOrderQuantityType1? OriginalOrderQuantityDetails { get; init; } 
    #else
    public OriginalOrderQuantityType1? OriginalOrderQuantityDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the commission applied to an order, eg, back-end or front-end commission.
    /// </summary>
    [IsoId("_VBwAqdp-Ed-ak6NoX_4Aeg_257394767")]
    [DisplayName("Commission Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnDtls")]
    #endif
    [IsoXmlTag("ComssnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commission4? CommissionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commission4? CommissionDetails { get; init; } 
    #else
    public Commission4? CommissionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
