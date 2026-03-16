// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a position in a financial instrument or financial product.
/// </summary>
[IsoId("_hpBo0LC8EeaSl6vJk5Bd8w")]
[DisplayName("Position")]
public record Position1
{
    /// <summary>
    /// CCP’s unique internal identifier for product.
    /// </summary>
    [IsoId("_pAx5gLC8EeaSl6vJk5Bd8w")]
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text ProductIdentification { get; init; }

    /// <summary>
    /// Obligations of a clearing member with respect to a central counterparty based on the position at end of day.
    /// </summary>
    [IsoId("_9_UI8LC8EeaSl6vJk5Bd8w")]
    [DisplayName("Risk Requirement")]
    [IsoXmlTag("RskRqrmnt")]
    public EndOfDayRequirement1? RiskRequirement { get; init; }

    /// <summary>
    /// Gross notional of positions of the product without netting of long/short positions, or delta equivalent notional for options.
    /// </summary>
    [IsoId("_kmlCQLDAEeaSl6vJk5Bd8w")]
    [DisplayName("Gross Notional")]
    [IsoXmlTag("GrssNtnl")]
    public required ActiveCurrencyAnd24Amount GrossNotional { get; init; }

    /// <summary>
    /// Net notional of positions of the product with netting between long and short positions, or delta equivalent notional for options. Indicates whether net long position is positive.
    /// </summary>
    [IsoId("_tsKGsLDAEeaSl6vJk5Bd8w")]
    [DisplayName("Net Notional")]
    [IsoXmlTag("NetNtnl")]
    public required AmountAndDirection102 NetNotional { get; init; }

    /// <summary>
    /// Change in value of position for a unit change in the index. Usage: for interest rate swaps the PV01 of the gross position, for credit default swaps the DV01 of the gross position, for index products with a fixed value per unit move, the total weighted value of a one unit move in the index for the gross contracts in the position, weighted by the delta of the contracts in the position.
    /// </summary>
    [IsoId("_pDrzcOPIEea7_eMQH225xA")]
    [DisplayName("Gross Delta Equivalent Value")]
    [IsoXmlTag("GrssDltaEqvtVal")]
    public ActiveCurrencyAndAmount? GrossDeltaEquivalentValue { get; init; }

    /// <summary>
    /// Change in value of position for a unit change in the index. Usage: for interest rate swaps the PV01 of the net position, for credit default swaps the DV01 of the net position, for index products with a fixed value per unit move, the total weighted value of a one unit move in the index for the net contracts in the position, weighted by the delta of the contracts in the position. Indicates whether net long position is positive.
    /// </summary>
    [IsoId("_sNRakOPIEea7_eMQH225xA")]
    [DisplayName("Net Delta Equivalent Value")]
    [IsoXmlTag("NetDltaEqvtVal")]
    public AmountAndDirection102? NetDeltaEquivalentValue { get; init; }

    /// <summary>
    /// Gross weighted quantity of the lots in the position weighted by the delta of the contracts in the position.
    /// </summary>
    [IsoId("_v4CcIOPIEea7_eMQH225xA")]
    [DisplayName("Gross Delta Equivalent Quantity")]
    [IsoXmlTag("GrssDltaEqvtQty")]
    [IsoSimpleType(IsoSimpleType.NonNegativeFraction5DecimalNumber)]
    public IsoNonNegativeFraction5DecimalNumber? GrossDeltaEquivalentQuantity { get; init; }

    /// <summary>
    /// Net weighted quantity of the lots in the position weighted by the delta of the contracts in the position.
    /// </summary>
    [IsoId("_yafx0OPIEea7_eMQH225xA")]
    [DisplayName("Net Delta Equivalent Quantity")]
    [IsoXmlTag("NetDltaEqvtQty")]
    [IsoSimpleType(IsoSimpleType.Fraction5DecimalNumber)]
    public IsoFraction5DecimalNumber? NetDeltaEquivalentQuantity { get; init; }

    /// <summary>
    /// Gross market value of the positions of the product without netting of long/short positions.
    /// </summary>
    [IsoId("_Cx7KsDT1EemwtJBLtapBmw")]
    [DisplayName("Gross Market Value")]
    [IsoXmlTag("GrssMktVal")]
    public required ActiveCurrencyAndAmount GrossMarketValue { get; init; }
}
