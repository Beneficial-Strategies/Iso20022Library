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
[IsoId("_VBwAqtp-Ed-ak6NoX_4Aeg_-1800161519")]
[DisplayName("Fund Cash Out Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundCashOutBreakdown1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of cash flow out, expressed as an amount of money.
    /// </summary>
    [IsoId("_VB5xoNp-Ed-ak6NoX_4Aeg_-1260826368")]
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
    [IsoId("_VB5xodp-Ed-ak6NoX_4Aeg_-724212157")]
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
    [IsoId("_VB5xotp-Ed-ak6NoX_4Aeg_-1534527424")]
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
    [IsoId("_VB5xo9p-Ed-ak6NoX_4Aeg_-540871792")]
    [DisplayName("Investment Fund Transaction Out Type Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtFndTxOutTpDtls")]
    #endif
    [IsoXmlTag("InvstmtFndTxOutTpDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentFundTransactionOutType1? InvestmentFundTransactionOutTypeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundTransactionOutType1? InvestmentFundTransactionOutTypeDetails { get; init; } 
    #else
    public InvestmentFundTransactionOutType1? InvestmentFundTransactionOutTypeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the cash movements into a fund by order type, eg, order by quantity of units or amount of money.
    /// </summary>
    [IsoId("_VB5xpNp-Ed-ak6NoX_4Aeg_-925979586")]
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
    [IsoId("_VB5xpdp-Ed-ak6NoX_4Aeg_1237784504")]
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
