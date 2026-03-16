// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the query criteria.
/// </summary>
[IsoId("_x03f5ZlcEeeE1Ya-LgRsuQ")]
[DisplayName("Business Day Query")]
public record BusinessDayQuery2
{
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_x84MY5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; }

    /// <summary>
    /// Defines the business day information query criteria.
    /// </summary>
    [IsoId("_x84MZZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Criteria")]
    [IsoXmlTag("Crit")]
    public BusinessDayCriteria3Choice_? Criteria { get; init; }
}
