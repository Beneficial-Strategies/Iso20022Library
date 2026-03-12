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
[IsoId("_E2br6W4-EeiU9cctagi5ow")]
[DisplayName("Limit Query")]
public partial record LimitQuery4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_FDP_424-EeiU9cctagi5ow")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; } 
    
    /// <summary>
    /// Defines the limit query criteria.
    /// </summary>
    [IsoId("_FDP_5W4-EeiU9cctagi5ow")]
    [DisplayName("Limit Criteria")]
    [IsoXmlTag("LmtCrit")]
    public LimitCriteria6Choice_? LimitCriteria { get; init; } 
    
    
    #nullable disable
    
}
