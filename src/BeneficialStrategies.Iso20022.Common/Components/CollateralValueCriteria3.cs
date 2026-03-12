// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for an account and to report on the account. A name may be given to the new query.
/// </summary>
[IsoId("__xWrgTpsEemk2e6qGBk8IQ")]
[DisplayName("Collateral Value Criteria")]
public partial record CollateralValueCriteria3
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("__7yZ4TpsEemk2e6qGBk8IQ")]
    [DisplayName("Query Name")]
    [IsoXmlTag("QryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QueryName { get; init; } 
    
    /// <summary>
    /// Defines the criteria to be used to extract the account information.
    /// </summary>
    [IsoId("__7yZ4zpsEemk2e6qGBk8IQ")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public CollateralValueSearchCriteria3? SearchCriteria { get; init; } 
    
    /// <summary>
    /// Defines the expected account report.
    /// </summary>
    [IsoId("__7yZ5TpsEemk2e6qGBk8IQ")]
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public CollateralValueReturnCriteria1? ReturnCriteria { get; init; } 
    
    
    #nullable disable
    
}
