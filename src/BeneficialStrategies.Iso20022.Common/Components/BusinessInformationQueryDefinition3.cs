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
[IsoId("_1NvnkZlZEeeE1Ya-LgRsuQ")]
[DisplayName("Business Information Query Definition")]
public partial record BusinessInformationQueryDefinition3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_1VwUE5lZEeeE1Ya-LgRsuQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; } 
    
    /// <summary>
    /// Defines the general business information query criteria.
    /// </summary>
    [IsoId("_1VwUFZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("General Business Information Criteria")]
    [IsoXmlTag("GnlBizInfCrit")]
    public GeneralBusinessInformationCriteriaDefinition1Choice_? GeneralBusinessInformationCriteria { get; init; } 
    
    
    #nullable disable
    
}
