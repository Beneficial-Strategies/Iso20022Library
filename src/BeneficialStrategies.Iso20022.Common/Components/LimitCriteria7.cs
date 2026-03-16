// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit Criteria7.
/// </summary>
[IsoId("_zV-IYTEyEe6g-ffJsqGiSA")]
[DisplayName("Limit Criteria7")]
public record LimitCriteria7
{
    /// <summary>
    /// New Query Name.
    /// </summary>
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    public IsoMax35Text? NewQueryName { get; init; }

    /// <summary>
    /// Return Criteria.
    /// </summary>
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public LimitReturnCriteria2? ReturnCriteria { get; init; }

    /// <summary>
    /// Search Criteria.
    /// </summary>
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public ValueList<LimitSearchCriteria7> SearchCriteria { get; init; } = [];
}
