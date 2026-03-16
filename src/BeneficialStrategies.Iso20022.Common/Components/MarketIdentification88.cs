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
[IsoId("_5YWZ4UeIEeSzluxs8tdrVw")]
[DisplayName("Market Identification")]
public record MarketIdentification88
{
    /// <summary>
    /// Code allocated to places of trade, ie, stock exchanges, regulated markets, for example, Electronic Trading Platforms (ECN), and unregulated markets, for example, Automated Trading Systems (ATS), as sources of prices and related information, in order to facilitate automated processing.
    /// </summary>
    [IsoId("__h7nQEeIEeSzluxs8tdrVw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public MarketIdentification1Choice_? Identification { get; init; }

    /// <summary>
    /// Nature of a market in which transactions take place.
    /// </summary>
    [IsoId("_F9wbMEeJEeSzluxs8tdrVw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MarketType13Choice_ Type { get; init; }
}
