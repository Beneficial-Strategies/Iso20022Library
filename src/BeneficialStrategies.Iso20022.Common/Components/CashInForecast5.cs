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
/// Cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
/// </summary>
[IsoId("_JvLpTQatEeS3lpTattq7hg")]
[DisplayName("Cash In Forecast")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashInForecast5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashInForecast5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashInForecast5( System.DateOnly reqCashSettlementDate )
    {
        CashSettlementDate = reqCashSettlementDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_KIxN8watEeS3lpTattq7hg")]
    [DisplayName("Cash Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlmDt")]
    #endif
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate CashSettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly CashSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly CashSettlementDate { get; init; } 
    #else
    public System.DateOnly CashSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-total amount of the cash flow in, expressed as an amount of money.
    /// </summary>
    [IsoId("_KIxN9QatEeS3lpTattq7hg")]
    [DisplayName("Sub Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubTtlAmt")]
    #endif
    [IsoXmlTag("SubTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-total amount of the cash flow in, expressed as a number of units.
    /// </summary>
    [IsoId("_KIxN9watEeS3lpTattq7hg")]
    [DisplayName("Sub Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubTtlUnitsNb")]
    #endif
    [IsoXmlTag("SubTtlUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the estimated cash flow in is exceptional.
    /// </summary>
    [IsoId("_KIxN-QatEeS3lpTattq7hg")]
    [DisplayName("Exceptional Cash Flow Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcptnlCshFlowInd")]
    #endif
    [IsoXmlTag("XcptnlCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ExceptionalCashFlowIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExceptionalCashFlowIndicator { get; init; } 
    #else
    public System.String? ExceptionalCashFlowIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of cash in amounts by transaction and order type.
    /// </summary>
    [IsoId("_KIxN-watEeS3lpTattq7hg")]
    [DisplayName("Cash In Breakdown Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInBrkdwnDtls")]
    #endif
    [IsoXmlTag("CshInBrkdwnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundCashInBreakdown3? CashInBreakdownDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundCashInBreakdown3? CashInBreakdownDetails { get; init; } 
    #else
    public FundCashInBreakdown3? CashInBreakdownDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional balances for cash amounts and number of units. 
    /// In an estimated report, the total cash derived from orders placed as a number of units is an estimated cash amount and the total number of units derived from orders placed as a cash amount is an estimated number of units.
    /// </summary>
    [IsoId("_px_-4QdEEeSyIPzOZ6VzBQ")]
    [DisplayName("Additional Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlBal")]
    #endif
    [IsoXmlTag("AddtlBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundBalance1? AdditionalBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundBalance1? AdditionalBalance { get; init; } 
    #else
    public FundBalance1? AdditionalBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
