// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Collateral Value Criteria4.
/// </summary>
[IsoId("_x2suBTEyEe6g-ffJsqGiSA")]
[DisplayName("Collateral Value Criteria4")]
public partial record CollateralValueCriteria4
{
    #nullable enable

    /// <summary>
    /// Query Name.
    /// </summary>
    [DisplayName("Query Name")]
    [IsoXmlTag("QryNm")]
    public IsoMax35Text? QueryName { get; init; } 

    /// <summary>
    /// Return Criteria.
    /// </summary>
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public CollateralValueReturnCriteria1? ReturnCriteria { get; init; } 

    /// <summary>
    /// Search Criteria.
    /// </summary>
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public CollateralValueSearchCriteria4? SearchCriteria { get; init; } 

    
    #nullable disable
    
}
