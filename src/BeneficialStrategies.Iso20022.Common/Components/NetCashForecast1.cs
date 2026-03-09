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
/// Net cash movements to a fund as a result of investment funds transactions.
/// </summary>
[IsoId("_VB5xptp-Ed-ak6NoX_4Aeg_906159660")]
[DisplayName("Net Cash Forecast")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetCashForecast1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NetCashForecast1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetCashForecast1( FlowDirectionType1Code reqFlowDirection )
    {
        FlowDirection = reqFlowDirection;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_VB5xp9p-Ed-ak6NoX_4Aeg_870568569")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SettlementDate { get; init; } 
    #else
    public System.DateOnly? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Net amount of the cash flow, expressed as an amount of money.
    /// </summary>
    [IsoId("_VB5xqNp-Ed-ak6NoX_4Aeg_906159679")]
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
    [IsoId("_VB5xqdp-Ed-ak6NoX_4Aeg_-189402816")]
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
    [IsoId("_VCC7kNp-Ed-ak6NoX_4Aeg_906159720")]
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
