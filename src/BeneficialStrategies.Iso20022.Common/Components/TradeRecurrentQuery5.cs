// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Recurrent query criteria.
/// </summary>
[IsoId("_esoycd1dEeqxpKDfBZC1vg")]
[DisplayName("Trade Recurrent Query")]
public record TradeRecurrentQuery5
{
    /// <summary>
    /// Defines the type of recurrent query which is requested.
    /// </summary>
    [IsoId("_et5Wsd1dEeqxpKDfBZC1vg")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public required IsoMax1000Text QueryType { get; init; }

    /// <summary>
    /// Defines the requested frequency of the recurrent query.
    /// </summary>
    [IsoId("_et5Ws91dEeqxpKDfBZC1vg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required TradeQueryExecutionFrequency3 Frequency { get; init; }

    /// <summary>
    /// Defines the date until which the query will be executed.
    /// </summary>
    [IsoId("_et5Wtd1dEeqxpKDfBZC1vg")]
    [DisplayName("Valid Until")]
    [IsoXmlTag("VldUntil")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValidUntil { get; init; }
}
