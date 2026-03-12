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
[IsoId("_71C2QKMgEeCJ6YNENx4h-w_-1928640529")]
[DisplayName("Currency Exchange Criteria")]
public partial record CurrencyExchangeCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_71C2QaMgEeCJ6YNENx4h-w_1369254414")]
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NewQueryName { get; init; } 
    
    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    [IsoId("_71C2QqMgEeCJ6YNENx4h-w_-294471871")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public ValueList<CurrencySourceTarget1> SearchCriteria { get; init; } = new ValueList<CurrencySourceTarget1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _71C2QqMgEeCJ6YNENx4h-w_-294471871
    
    
    #nullable disable
    
}
