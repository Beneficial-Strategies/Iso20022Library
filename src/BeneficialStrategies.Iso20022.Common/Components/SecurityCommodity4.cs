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
[IsoId("_lGdtga-tEemF0ZVFnxVu4g")]
[DisplayName("Security Commodity")]
public record SecurityCommodity4
{
    /// <summary>
    /// Data specific to securities being subject to the transaction.
    /// </summary>
    [IsoId("_lLk3Aa-tEemF0ZVFnxVu4g")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public Security17? Security { get; init; }

    /// <summary>
    /// Data specific to commodities being subject to the transaction.
    /// </summary>
    [IsoId("_lLk3A6-tEemF0ZVFnxVu4g")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public Commodity21? Commodity { get; init; }
}
