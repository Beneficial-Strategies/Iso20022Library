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
[IsoId("_5W4n7ZNLEeWGlc8L7oPDIg")]
[DisplayName("Balance")]
public record Balance11
{
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_5W4n75NLEeWGlc8L7oPDIg")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public ShortLong1Code? ShortLongIndicator { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_5W4n95NLEeWGlc8L7oPDIg")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required BalanceQuantity10Choice_ Quantity { get; init; }
}
