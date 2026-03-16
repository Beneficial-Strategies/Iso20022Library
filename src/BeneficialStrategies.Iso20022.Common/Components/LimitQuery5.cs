// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit Query5.
/// </summary>
[IsoId("_zRf4ETEyEe6g-ffJsqGiSA")]
[DisplayName("Limit Query5")]
public partial record LimitQuery5
{
    #nullable enable

    /// <summary>
    /// Limit Criteria.
    /// </summary>
    [DisplayName("Limit Criteria")]
    [IsoXmlTag("LmtCrit")]
    public LimitCriteria7Choice_? LimitCriteria { get; init; } 

    /// <summary>
    /// Query Type.
    /// </summary>
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; } 

    
    #nullable disable
    
}
