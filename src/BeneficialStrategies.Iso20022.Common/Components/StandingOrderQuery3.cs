// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the query criteria.
/// </summary>
[IsoId("_F3jKq24-EeiU9cctagi5ow")]
[DisplayName("Standing Order Query")]
public record StandingOrderQuery3
{
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_GBYcEW4-EeiU9cctagi5ow")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; }

    /// <summary>
    /// Definition of the standing order query criteria.
    /// </summary>
    [IsoId("_GBYcE24-EeiU9cctagi5ow")]
    [DisplayName("Standing Order Criteria")]
    [IsoXmlTag("StgOrdrCrit")]
    public StandingOrderCriteria3Choice_? StandingOrderCriteria { get; init; }
}
