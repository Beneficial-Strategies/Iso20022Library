// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the old and new values for a market specific attribute.
/// </summary>
[IsoId("_8g_CI2jSEeiRg5NzP0jkQg")]
[DisplayName("Update Log Market Specific Attribute")]
public record UpdateLogMarketSpecificAttribute1
{
    /// <summary>
    /// Old value before the update.
    /// </summary>
    [IsoId("_8g_pMWjSEeiRg5NzP0jkQg")]
    [DisplayName("Old")]
    [IsoXmlTag("Od")]
    public required MarketSpecificAttribute1 Old { get; init; }

    /// <summary>
    /// New value after the update.
    /// </summary>
    [IsoId("_8g_pMGjSEeiRg5NzP0jkQg")]
    [DisplayName("New")]
    [IsoXmlTag("New")]
    public required MarketSpecificAttribute1 New { get; init; }
}
