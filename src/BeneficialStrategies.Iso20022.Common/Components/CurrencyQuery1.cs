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
[IsoId("_71C2Q6MgEeCJ6YNENx4h-w_507537630")]
[DisplayName("Currency Query")]
public partial record CurrencyQuery1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_71C2RKMgEeCJ6YNENx4h-w_-73159754")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; } 
    
    /// <summary>
    ///  Defines of the currency query criteria.
    /// </summary>
    [IsoId("_71C2RaMgEeCJ6YNENx4h-w_-1016665255")]
    [DisplayName("Currency Criteria")]
    [IsoXmlTag("CcyCrit")]
    public CurrencyCriteria1Choice_? CurrencyCriteria { get; init; } 
    
    
    #nullable disable
    
}
