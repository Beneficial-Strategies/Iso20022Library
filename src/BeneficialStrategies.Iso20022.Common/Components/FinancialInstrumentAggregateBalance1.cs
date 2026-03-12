// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aggregated position of holdings held in a securities account for a specified financial instrument.
/// </summary>
[IsoId("_1TSje4jiEeONZKAAW4pOaQ")]
[DisplayName("Financial Instrument Aggregate Balance")]
public partial record FinancialInstrumentAggregateBalance1
{
    #nullable enable
    
    /// <summary>
    /// Date of the line of holding in the statement.
    /// </summary>
    [IsoId("_1TSjfIjiEeONZKAAW4pOaQ")]
    [DisplayName("Item Date")]
    [IsoXmlTag("ItmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ItemDate { get; init; } 
    
    /// <summary>
    /// Balances and sub-balances attributed to the holding.
    /// </summary>
    [IsoId("_SAtY8aCDEeOEyO7fCl8lLA")]
    [DisplayName("Holdings")]
    [IsoXmlTag("Hldgs")]
    public required FinancialInstrumentAggregateBalance1Choice_ Holdings { get; init; } 
    
    /// <summary>
    /// Details on the price value, type and source.
    /// </summary>
    [IsoId("_KMa34TywEeSBD_ZW60GwCQ")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public Price6? Price { get; init; } 
    
    
    #nullable disable
    
}
