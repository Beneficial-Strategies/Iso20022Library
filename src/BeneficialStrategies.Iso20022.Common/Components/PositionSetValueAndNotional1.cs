// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables used to quantify the different calculations for position sets and currency position sets reports.
/// </summary>
[IsoId("_wx1DhcWEEeiRga8tPu1L4Q")]
[DisplayName("Position Set Value And Notional")]
public partial record PositionSetValueAndNotional1
{
    #nullable enable
    
    /// <summary>
    /// Aggregations of all notional values of the derivatives pertaining to a position set.
    /// </summary>
    [IsoId("_wx1Dh8WEEeiRga8tPu1L4Q")]
    [DisplayName("Notional")]
    [IsoXmlTag("Ntnl")]
    public ActiveOrHistoricCurrencyAnd20Amount? Notional { get; init; } 
    
    /// <summary>
    /// Aggregations of all values of the derivatives pertaining to a position set.
    /// </summary>
    [IsoId("_wx1DiMWEEeiRga8tPu1L4Q")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public ActiveOrHistoricCurrencyAnd20Amount? Value { get; init; } 
    
    
    #nullable disable
    
}
