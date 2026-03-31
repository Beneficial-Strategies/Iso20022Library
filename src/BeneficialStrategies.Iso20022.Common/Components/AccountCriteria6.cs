// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for an account and to report on the account. A name may be given to the new query.
/// </summary>
[IsoId("_4GLX15laEeeE1Ya-LgRsuQ")]
[DisplayName("Account Criteria")]
public record AccountCriteria6
{
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_4OF9s5laEeeE1Ya-LgRsuQ")]
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NewQueryName { get; init; }

    /// <summary>
    /// Defines the criteria to be used to extract the account information.
    /// </summary>
    [IsoId("_4OF9tZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public ValueList<CashAccountSearchCriteria6> SearchCriteria { get; init; } = [];

    /// <summary>
    /// Defines the expected account report.
    /// </summary>
    [IsoId("_4OF9t5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public CashAccountReturnCriteria4? ReturnCriteria { get; init; }
}
