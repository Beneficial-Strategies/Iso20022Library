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
/// Balances of units and cash derived from investment fund orders.
/// </summary>
[IsoId("_zGdM0QdEEeSyIPzOZ6VzBQ")]
[DisplayName("Fund Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundBalance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total number of units from orders placed in units.
    /// </summary>
    [IsoId("_DmM8wAdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Total Units From Unit Orders")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsFrUnitOrdrs")]
    #endif
    [IsoXmlTag("TtlUnitsFrUnitOrdrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? TotalUnitsFromUnitOrders { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? TotalUnitsFromUnitOrders { get; init; } 
    #else
    public FinancialInstrumentQuantity1? TotalUnitsFromUnitOrders { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units derived from orders placed in cash.
    /// </summary>
    [IsoId("_UwVtgAdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Total Units From Cash Orders")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsFrCshOrdrs")]
    #endif
    [IsoXmlTag("TtlUnitsFrCshOrdrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? TotalUnitsFromCashOrders { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? TotalUnitsFromCashOrders { get; init; } 
    #else
    public FinancialInstrumentQuantity1? TotalUnitsFromCashOrders { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of cash derived from orders placed as units.
    /// </summary>
    [IsoId("_MLMcoAdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Total Cash From Unit Orders")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCshFrUnitOrdrs")]
    #endif
    [IsoXmlTag("TtlCshFrUnitOrdrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFromUnitOrders { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFromUnitOrders { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFromUnitOrders { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of cash from orders placed in cash.
    /// </summary>
    [IsoId("_RgyoUAdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Total Cash From Cash Orders")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCshFrCshOrdrs")]
    #endif
    [IsoXmlTag("TtlCshFrCshOrdrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFromCashOrders { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFromCashOrders { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFromCashOrders { get; set; } 
    #endif
    
    
    #nullable disable
    
}
