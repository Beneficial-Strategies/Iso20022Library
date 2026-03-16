// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report Query Criteria3.
/// </summary>
[IsoId("_6c02UTEyEe6g-ffJsqGiSA")]
[DisplayName("Report Query Criteria3")]
public record ReportQueryCriteria3
{
    /// <summary>
    /// New Query Name.
    /// </summary>
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    public IsoMax35Text? NewQueryName { get; init; }

    /// <summary>
    /// Search Criteria.
    /// </summary>
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public required ReportQuerySearchCriteria3 SearchCriteria { get; init; }
}
