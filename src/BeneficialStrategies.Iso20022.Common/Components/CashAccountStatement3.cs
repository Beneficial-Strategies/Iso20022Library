// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides system date for all of the changes occurred for an entity.
/// </summary>
[IsoId("_dB-GUeTXEfC01pKpYIyMTA")]
[DisplayName("Cash Account Statement3")]
public record CashAccountStatement3
{
    /// <summary>
    /// Date for which the statement is valid.
    /// </summary>
    [IsoId("_dFQq4OTXEfC01pKpYIyMTA")]
    [DisplayName("System Date")]
    [IsoXmlTag("SysDt")]
    public required IsoISODate SystemDate { get; init; }

    /// <summary>
    /// Provides information on the actual change occurred to the cash account.
    /// </summary>
    [IsoId("_dFQq4uTXEfC01pKpYIyMTA")]
    [DisplayName("Change")]
    [IsoXmlTag("Chng")]
    public ValueList<CashAccountReferenceDataChange3> Change { get; init; } = [];
}
