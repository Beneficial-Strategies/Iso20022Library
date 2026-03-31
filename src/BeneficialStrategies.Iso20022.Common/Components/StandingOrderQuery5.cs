// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Standing Order Query5.
/// </summary>
[IsoId("_0mLzETEyEe6g-ffJsqGiSA")]
[DisplayName("Standing Order Query5")]
public record StandingOrderQuery5
{
    /// <summary>
    /// Query Type.
    /// </summary>
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; }

    /// <summary>
    /// Standing Order Criteria.
    /// </summary>
    [DisplayName("Standing Order Criteria")]
    [IsoXmlTag("StgOrdrCrit")]
    public StandingOrderCriteria5Choice_? StandingOrderCriteria { get; init; }
}
