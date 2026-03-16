// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Standing Order Criteria5.
/// </summary>
[IsoId("_0qxYJTEyEe6g-ffJsqGiSA")]
[DisplayName("Standing Order Criteria5")]
public partial record StandingOrderCriteria5
{
    #nullable enable

    /// <summary>
    /// New Query Name.
    /// </summary>
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    public IsoMax35Text? NewQueryName { get; init; } 

    /// <summary>
    /// Return Criteria.
    /// </summary>
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public StandingOrderReturnCriteria1? ReturnCriteria { get; init; } 

    /// <summary>
    /// Search Criteria.
    /// </summary>
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public ValueList<StandingOrderSearchCriteria5> SearchCriteria { get; init; } = [];

    
    #nullable disable
    
}
