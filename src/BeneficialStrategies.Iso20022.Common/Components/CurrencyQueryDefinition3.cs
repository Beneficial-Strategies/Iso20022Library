// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the query criteria.
/// </summary>
[IsoId("_Ho80EZlZEeeE1Ya-LgRsuQ")]
[DisplayName("Currency Query Definition")]
public partial record CurrencyQueryDefinition3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_HxiIU5lZEeeE1Ya-LgRsuQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; } 
    
    /// <summary>
    /// Defines of the currency query criteria.
    /// </summary>
    [IsoId("_HxiIVZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("Currency Criteria")]
    [IsoXmlTag("CcyCrit")]
    public CurrencyCriteriaDefinition1Choice_? CurrencyCriteria { get; init; } 
    
    
    #nullable disable
    
}
