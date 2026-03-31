// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account. A securities balance is calculated from the sum of securities&apos; receipts minus the sum of securities&apos; deliveries.
/// </summary>
[IsoId("_j66xdSp6EeyR9JrVGfaMKw")]
[DisplayName("Balance")]
public record Balance17
{
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_kST9oSp6EeyR9JrVGfaMKw")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public required ShortLong1Code ShortLongIndicator { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_kST9qSp6EeyR9JrVGfaMKw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required BalanceQuantity13Choice_ Quantity { get; init; }
}
