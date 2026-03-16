// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for generated report.
/// </summary>
[IsoId("_3NLDgZb6Eee4htziCyV8eA")]
[DisplayName("Report Query Criteria")]
public record ReportQueryCriteria2
{
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_3b6DEZb6Eee4htziCyV8eA")]
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NewQueryName { get; init; }

    /// <summary>
    /// Defines the criteria to be used to extract the account information.
    /// </summary>
    [IsoId("_3b6DE5b6Eee4htziCyV8eA")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public required ReportQuerySearchCriteria2 SearchCriteria { get; init; }
}
