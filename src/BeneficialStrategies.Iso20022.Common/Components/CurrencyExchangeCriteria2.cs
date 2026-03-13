// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for currency exchange information. A name may be given to the new query.
/// </summary>
[IsoId("_H5cuNZlZEeeE1Ya-LgRsuQ")]
[DisplayName("Currency Exchange Criteria")]
public partial record CurrencyExchangeCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_IB770ZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NewQueryName { get; init; } 
    
    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    [IsoId("_IB7705lZEeeE1Ya-LgRsuQ")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public ValueList<CurrencyExchangeSearchCriteria1> SearchCriteria { get; init; } = [];
    // ID for the above is _IB7705lZEeeE1Ya-LgRsuQ
    
    
    #nullable disable
    
}
