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
[IsoId("_csW37Ti8Eeydid5dcNPKvg")]
[DisplayName("Balance")]
public record Balance25
{
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_csW37zi8Eeydid5dcNPKvg")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public ShortLong1Code? ShortLongIndicator { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_csW39zi8Eeydid5dcNPKvg")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required BalanceQuantity17Choice_ Quantity { get; init; }
}
