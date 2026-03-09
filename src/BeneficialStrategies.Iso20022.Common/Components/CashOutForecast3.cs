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
/// Cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
/// </summary>
[IsoId("_SksIUNp-Ed-ak6NoX_4Aeg_1915292616")]
[DisplayName("Cash Out Forecast")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashOutForecast3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashOutForecast3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashOutForecast3( System.DateOnly reqCashSettlementDate )
    {
        CashSettlementDate = reqCashSettlementDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_SksIUdp-Ed-ak6NoX_4Aeg_1916213081")]
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
    /// Sub-total amount of the cash flow out, expressed as an amount of money.
    /// </summary>
    [IsoId("_SksIUtp-Ed-ak6NoX_4Aeg_1916213151")]
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
    /// Sub-total amount of the cash flow out, expressed as a number of units.
    /// </summary>
    [IsoId("_SksIU9p-Ed-ak6NoX_4Aeg_1916213565")]
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
    /// Indicates whether the estimated cash flow out is exceptional.
    /// </summary>
    [IsoId("_SksIVNp-Ed-ak6NoX_4Aeg_1916214941")]
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
    /// Breakdown of cash out amounts, eg, by transaction or order type.
    /// </summary>
    [IsoId("_SksIVdp-Ed-ak6NoX_4Aeg_1916216157")]
    [DisplayName("Cash Out Breakdown Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshOutBrkdwnDtls")]
    #endif
    [IsoXmlTag("CshOutBrkdwnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundCashOutBreakdown2? CashOutBreakdownDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundCashOutBreakdown2? CashOutBreakdownDetails { get; init; } 
    #else
    public FundCashOutBreakdown2? CashOutBreakdownDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
