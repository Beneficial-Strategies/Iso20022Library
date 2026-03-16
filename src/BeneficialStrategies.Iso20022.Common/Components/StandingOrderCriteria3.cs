// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for a standing order and to report on standing orders. A name may be given to the new query.
/// </summary>
[IsoId("_GMtiVW4-EeiU9cctagi5ow")]
[DisplayName("Standing Order Criteria")]
public record StandingOrderCriteria3
{
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_GWGH024-EeiU9cctagi5ow")]
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NewQueryName { get; init; }

    /// <summary>
    /// Defines the criteria to be used to extract the standing order information.
    /// </summary>
    [IsoId("_GWGH1W4-EeiU9cctagi5ow")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public StandingOrderSearchCriteria3? SearchCriteria { get; init; }

    /// <summary>
    /// Defines the expected standing order report.
    /// </summary>
    [IsoId("_GWGH124-EeiU9cctagi5ow")]
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public StandingOrderReturnCriteria1? ReturnCriteria { get; init; }
}
