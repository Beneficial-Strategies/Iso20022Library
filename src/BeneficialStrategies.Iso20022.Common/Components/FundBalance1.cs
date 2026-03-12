// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balances of units and cash derived from investment fund orders.
/// </summary>
[IsoId("_zGdM0QdEEeSyIPzOZ6VzBQ")]
[DisplayName("Fund Balance")]
public partial record FundBalance1
{
    #nullable enable
    
    /// <summary>
    /// Total number of units from orders placed in units.
    /// </summary>
    [IsoId("_DmM8wAdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Total Units From Unit Orders")]
    [IsoXmlTag("TtlUnitsFrUnitOrdrs")]
    public FinancialInstrumentQuantity1? TotalUnitsFromUnitOrders { get; init; } 
    
    /// <summary>
    /// Number of units derived from orders placed in cash.
    /// </summary>
    [IsoId("_UwVtgAdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Total Units From Cash Orders")]
    [IsoXmlTag("TtlUnitsFrCshOrdrs")]
    public FinancialInstrumentQuantity1? TotalUnitsFromCashOrders { get; init; } 
    
    /// <summary>
    /// Total amount of cash derived from orders placed as units.
    /// </summary>
    [IsoId("_MLMcoAdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Total Cash From Unit Orders")]
    [IsoXmlTag("TtlCshFrUnitOrdrs")]
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFromUnitOrders { get; init; } 
    
    /// <summary>
    /// Total amount of cash from orders placed in cash.
    /// </summary>
    [IsoId("_RgyoUAdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Total Cash From Cash Orders")]
    [IsoXmlTag("TtlCshFrCshOrdrs")]
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFromCashOrders { get; init; } 
    
    
    #nullable disable
    
}
