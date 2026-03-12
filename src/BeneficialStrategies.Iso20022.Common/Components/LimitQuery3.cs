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
[IsoId("_PXu9WZlcEeeE1Ya-LgRsuQ")]
[DisplayName("Limit Query")]
public partial record LimitQuery3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_PgIEU5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; } 
    
    /// <summary>
    /// Defines the limit query criteria.
    /// </summary>
    [IsoId("_PgIEVZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Limit Criteria")]
    [IsoXmlTag("LmtCrit")]
    public LimitCriteria5Choice_? LimitCriteria { get; init; } 
    
    
    #nullable disable
    
}
