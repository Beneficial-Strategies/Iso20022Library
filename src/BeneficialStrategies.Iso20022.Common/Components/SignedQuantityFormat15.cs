// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed quantity of a security for various quantity formats.
/// </summary>
[IsoId("_eXQn8zT5Ee2j2eQlcOSMKg")]
[DisplayName("Signed Quantity Format")]
public record SignedQuantityFormat15
{
    /// <summary>
    /// Sign of the quantity of securities.
    /// </summary>
    [IsoId("_eXQn9DT5Ee2j2eQlcOSMKg")]
    [DisplayName("Short Long Position")]
    [IsoXmlTag("ShrtLngPos")]
    public required ShortLong1Code ShortLongPosition { get; init; }

    /// <summary>
    /// Quantity of securities.
    /// </summary>
    [IsoId("_eXQn9TT5Ee2j2eQlcOSMKg")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity46Choice_ Quantity { get; init; }
}
