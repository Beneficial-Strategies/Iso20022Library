// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indication of the type of assets subject of the transaction.
/// </summary>
[IsoId("_97aFscg4Eeu4ecZgAYuz5w")]
[DisplayName("Security Commodity")]
public record SecurityCommodity9
{
    /// <summary>
    /// Data specific to securities being subject to the transaction.
    /// </summary>
    [IsoId("_99ODk8g4Eeu4ecZgAYuz5w")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public ValueList<Security51> Security { get; init; } = [];

    /// <summary>
    /// Data specific to commodities being subject to the transaction.
    /// </summary>
    [IsoId("_99ODlcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public ValueList<Commodity43> Commodity { get; init; } = [];
}
