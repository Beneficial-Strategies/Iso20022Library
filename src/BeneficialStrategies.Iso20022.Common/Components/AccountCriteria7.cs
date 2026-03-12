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
[IsoId("_PxA_l249EeiU9cctagi5ow")]
[DisplayName("Account Criteria")]
public partial record AccountCriteria7
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_P8Cj0249EeiU9cctagi5ow")]
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NewQueryName { get; init; } 
    
    /// <summary>
    /// Defines the criteria to be used to extract the account information.
    /// </summary>
    [IsoId("_P8Cj1W49EeiU9cctagi5ow")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public CashAccountSearchCriteria7? SearchCriteria { get; init; } 
    
    /// <summary>
    /// Defines the expected account report.
    /// </summary>
    [IsoId("_P8Cj1249EeiU9cctagi5ow")]
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public CashAccountReturnCriteria5? ReturnCriteria { get; init; } 
    
    
    #nullable disable
    
}
