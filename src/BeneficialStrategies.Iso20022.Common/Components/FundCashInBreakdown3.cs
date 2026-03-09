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
[IsoId("_KIxN_QatEeS3lpTattq7hg")]
[DisplayName("Fund Cash In Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundCashInBreakdown3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundCashInBreakdown3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundCashInBreakdown3( InvestmentFundTransactionInType1Choice_ reqInvestmentFundTransactionInType,QuantityType1Choice_ reqOriginalOrderQuantityType )
    {
        InvestmentFundTransactionInType = reqInvestmentFundTransactionInType;
        OriginalOrderQuantityType = reqOriginalOrderQuantityType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of cash flow in, expressed as an amount of money.
    /// </summary>
    [IsoId("_KigjpwatEeS3lpTattq7hg")]
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
    [IsoId("_KigjqQatEeS3lpTattq7hg")]
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
    /// Indicates whether the cash flow is an item that did not appear on the previously sent report, for example, because it was received close to cut-off time.
    /// </summary>
    [IsoId("_KigjqwatEeS3lpTattq7hg")]
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
    /// Type of transaction that resulted in the cash-in movement, for example, subscription, switch-in.
    /// </summary>
    [IsoId("_kJo8kQayEeS3lpTattq7hg")]
    [DisplayName("Investment Fund Transaction In Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtFndTxInTp")]
    #endif
    [IsoXmlTag("InvstmtFndTxInTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentFundTransactionInType1Choice_ InvestmentFundTransactionInType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentFundTransactionInType1Choice_ InvestmentFundTransactionInType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundTransactionInType1Choice_ InvestmentFundTransactionInType { get; init; } 
    #else
    public InvestmentFundTransactionInType1Choice_ InvestmentFundTransactionInType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the original order was expressed that resulted in the cash-in movement, that is cash or units.
    /// </summary>
    [IsoId("_lUBsEQayEeS3lpTattq7hg")]
    [DisplayName("Original Order Quantity Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlOrdrQtyTp")]
    #endif
    [IsoXmlTag("OrgnlOrdrQtyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QuantityType1Choice_ OriginalOrderQuantityType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QuantityType1Choice_ OriginalOrderQuantityType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityType1Choice_ OriginalOrderQuantityType { get; init; } 
    #else
    public QuantityType1Choice_ OriginalOrderQuantityType { get; set; } 
    #endif
    
    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    [IsoId("_KigjtQatEeS3lpTattq7hg")]
    [DisplayName("Charge Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgDtls")]
    #endif
    [IsoXmlTag("ChrgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge26? ChargeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge26? ChargeDetails { get; init; } 
    #else
    public Charge26? ChargeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the commission applied to an order, for example, back-end or front-end commission.
    /// </summary>
    [IsoId("_KigjtwatEeS3lpTattq7hg")]
    [DisplayName("Commission Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnDtls")]
    #endif
    [IsoXmlTag("ComssnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commission21? CommissionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commission21? CommissionDetails { get; init; } 
    #else
    public Commission21? CommissionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement currency for the transaction.
    /// </summary>
    [IsoId("_QYqcRAc9EeSyIPzOZ6VzBQ")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SettlementCurrency { get; init; } 
    #else
    public string? SettlementCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
