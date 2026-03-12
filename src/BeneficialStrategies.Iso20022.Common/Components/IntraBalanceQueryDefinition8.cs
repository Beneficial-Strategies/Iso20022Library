// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the information that is searched through specific criteria.
/// </summary>
[IsoId("_30RF4Tp8EemwKdP955WBJQ")]
[DisplayName("Intra Balance Query Definition")]
public partial record IntraBalanceQueryDefinition8
{
    #nullable enable
    
    /// <summary>
    /// Defines the type of query.
    /// </summary>
    [IsoId("_3_TRMTp8EemwKdP955WBJQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public required MovementResponseType1Code QueryType { get; init; } 
    
    /// <summary>
    /// Defines the criteria to extract the intra-balance movement instruction information.
    /// </summary>
    [IsoId("_3_TRMzp8EemwKdP955WBJQ")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public required IntraBalanceQueryCriteria8 SearchCriteria { get; init; } 
    
    
    #nullable disable
    
}
