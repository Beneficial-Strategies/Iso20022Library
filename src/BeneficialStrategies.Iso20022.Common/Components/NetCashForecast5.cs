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
/// Net cash movement to a fund as a result of investment funds transactions.
/// </summary>
[IsoId("_EYWw0V-JEeS7xuKaq75oiQ")]
[DisplayName("Net Cash Forecast")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetCashForecast5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NetCashForecast5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetCashForecast5( FlowDirectionType1Code reqFlowDirection )
    {
        FlowDirection = reqFlowDirection;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_EzlUQ1-JEeS7xuKaq75oiQ")]
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
    /// Net amount of the cash flow, expressed as an amount of money.
    /// </summary>
    [IsoId("_EzlURV-JEeS7xuKaq75oiQ")]
    [DisplayName("Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmt")]
    #endif
    [IsoXmlTag("NetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Net amount, expressed as a number of units.
    /// </summary>
    [IsoId("_EzlUR1-JEeS7xuKaq75oiQ")]
    [DisplayName("Net Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetUnitsNb")]
    #endif
    [IsoXmlTag("NetUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? NetUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? NetUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1? NetUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the direction of the cash flow from the perspective of the fund.
    /// </summary>
    [IsoId("_EzlUSV-JEeS7xuKaq75oiQ")]
    [DisplayName("Flow Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlowDrctn")]
    #endif
    [IsoXmlTag("FlowDrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FlowDirectionType1Code FlowDirection { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FlowDirectionType1Code FlowDirection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FlowDirectionType1Code FlowDirection { get; init; } 
    #else
    public FlowDirectionType1Code FlowDirection { get; set; } 
    #endif
    
    
    #nullable disable
    
}
