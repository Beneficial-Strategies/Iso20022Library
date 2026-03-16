// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for business day information and to report on the business day information. A name may be given to the new query.
/// </summary>
[IsoId("_yFXaB5lcEeeE1Ya-LgRsuQ")]
[DisplayName("Business Day Criteria")]
public record BusinessDayCriteria2
{
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_yNYGg5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NewQueryName { get; init; }

    /// <summary>
    /// Defines the criteria on which the information is extracted.
    /// </summary>
    [IsoId("_yNYGhZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public ValueList<BusinessDaySearchCriteria2> SearchCriteria { get; init; } = [];

    /// <summary>
    /// Defines the expected report.
    /// </summary>
    [IsoId("_yNYGh5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public BusinessDayReturnCriteria2? ReturnCriteria { get; init; }
}
