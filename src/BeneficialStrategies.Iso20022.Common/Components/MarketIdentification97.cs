// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
/// </summary>
[IsoId("_rACbkQeBEe2fOITqoTnSLQ")]
[DisplayName("Market Identification")]
public record MarketIdentification97
{
    /// <summary>
    /// Code allocated to places of trade, ie, stock exchanges, regulated markets, eg, Electronic Trading Platforms (ECN), and unregulated markets, eg, Automated Trading Systems (ATS), as sources of prices and related information, in order to facilitate automated processing.
    /// </summary>
    [IsoId("_rQui-QeBEe2fOITqoTnSLQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public MarketIdentification3Choice_? Identification { get; init; }

    /// <summary>
    /// Nature of a market in which transactions take place.
    /// </summary>
    [IsoId("_rQujAQeBEe2fOITqoTnSLQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MarketType8Choice_? Type { get; init; }
}
