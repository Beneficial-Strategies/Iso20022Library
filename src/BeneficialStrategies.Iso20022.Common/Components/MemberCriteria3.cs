// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a member and to report on the member. A name may be given to the new query.
/// </summary>
[IsoId("_tToNhZlVEeeE1Ya-LgRsuQ")]
[DisplayName("Member Criteria")]
public record MemberCriteria3
{
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_tb1HQ5lVEeeE1Ya-LgRsuQ")]
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NewQueryName { get; init; }

    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    [IsoId("_tb1HRZlVEeeE1Ya-LgRsuQ")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public MemberSearchCriteria2? SearchCriteria { get; init; }

    /// <summary>
    /// Defines the expected report.
    /// </summary>
    [IsoId("_tb1HR5lVEeeE1Ya-LgRsuQ")]
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public MemberReturnCriteria1? ReturnCriteria { get; init; }
}
