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
[IsoId("_isISEZlPEee-Zps0fZQaFQ")]
[DisplayName("Standing Order Query")]
public record StandingOrderQuery2
{
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_i0KMsZlPEee-Zps0fZQaFQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; }

    /// <summary>
    /// Definition of the standing order query criteria.
    /// </summary>
    [IsoId("_i0KMs5lPEee-Zps0fZQaFQ")]
    [DisplayName("Standing Order Criteria")]
    [IsoXmlTag("StgOrdrCrit")]
    public StandingOrderCriteria2Choice_? StandingOrderCriteria { get; init; }
}
