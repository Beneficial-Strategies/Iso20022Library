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
[IsoId("_lwUpMa-1EemF0ZVFnxVu4g")]
[DisplayName("Security Commodity Cash")]
public record SecurityCommodityCash1
{
    /// <summary>
    /// Data specific to securities being subject to the transaction.
    /// </summary>
    [IsoId("_l0q9sa-1EemF0ZVFnxVu4g")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public Security17? Security { get; init; }

    /// <summary>
    /// Data specific to commodities being subject to the transaction.
    /// </summary>
    [IsoId("_l0q9s6-1EemF0ZVFnxVu4g")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public Commodity21? Commodity { get; init; }

    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_pTFlUK-1EemF0ZVFnxVu4g")]
    [DisplayName("Cash")]
    [IsoXmlTag("Csh")]
    public CashCompare1? Cash { get; init; }
}
