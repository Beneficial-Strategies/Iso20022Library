// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria to extract the limit information and the expected limit report. A name may be given to the new query.
/// </summary>
[IsoId("_FMyWZ24-EeiU9cctagi5ow")]
[DisplayName("Limit Criteria")]
public record LimitCriteria6
{
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_FZ5lV24-EeiU9cctagi5ow")]
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NewQueryName { get; init; }

    /// <summary>
    /// Defines the criteria to extract the limit information.
    /// </summary>
    [IsoId("_FZ5lWW4-EeiU9cctagi5ow")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public LimitSearchCriteria6? SearchCriteria { get; init; }

    /// <summary>
    /// Defines the expected limit report.
    /// </summary>
    [IsoId("_FZ5lW24-EeiU9cctagi5ow")]
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public LimitReturnCriteria2? ReturnCriteria { get; init; }
}
