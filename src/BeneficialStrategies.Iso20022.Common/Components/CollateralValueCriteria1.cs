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
[IsoId("_jJp0oe5NEeCisYr99QEiWA_181019716")]
[DisplayName("Collateral Value Criteria")]
public partial record CollateralValueCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_jJp0ou5NEeCisYr99QEiWA_-275893458")]
    [DisplayName("Query Name")]
    [IsoXmlTag("QryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QueryName { get; init; } 
    
    /// <summary>
    /// Defines the criteria to be used to extract the account information.
    /// </summary>
    [IsoId("_jJp0o-5NEeCisYr99QEiWA_-1182011055")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public CollateralValueSearchCriteria1? SearchCriteria { get; init; } 
    
    /// <summary>
    /// Defines the expected account report.
    /// </summary>
    [IsoId("_jJp0pO5NEeCisYr99QEiWA_-1499787716")]
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public CashAccountReturnCriteria2? ReturnCriteria { get; init; } 
    
    
    #nullable disable
    
}
