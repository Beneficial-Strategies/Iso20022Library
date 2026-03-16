// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rebate form to an award.
/// </summary>
[IsoId("_M2VZgNxOEeioifFt1dhnJA")]
[DisplayName("Loyalty Rebates")]
public record LoyaltyRebates1
{
    /// <summary>
    /// The global awarded amount that is not attached to an item.
    /// </summary>
    [IsoId("_Wj6SENxOEeioifFt1dhnJA")]
    [DisplayName("Total Rebate")]
    [IsoXmlTag("TtlRbt")]
    public ImpliedCurrencyAndAmount? TotalRebate { get; init; }

    /// <summary>
    /// Short text to qualify a rebate on an line item.
    /// </summary>
    [IsoId("_ZewSkNxOEeioifFt1dhnJA")]
    [DisplayName("Rebate Label")]
    [IsoXmlTag("RbtLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RebateLabel { get; init; }

    /// <summary>
    /// Amount of the payment transaction related to the Loyalty.
    /// </summary>
    [IsoId("_dE2PgNxOEeioifFt1dhnJA")]
    [DisplayName("Sale Item Rebate")]
    [IsoXmlTag("SaleItmRbt")]
    public ValueList<SaleItemRebate1> SaleItemRebate { get; init; } = [];
}
