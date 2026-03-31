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
[IsoId("_S6IhwzRTEe2id-MjcNoBdw")]
[DisplayName("Signed Quantity Format")]
public record SignedQuantityFormat14
{
    /// <summary>
    /// Sign of the quantity of securities.
    /// </summary>
    [IsoId("_S6IhxDRTEe2id-MjcNoBdw")]
    [DisplayName("Short Long Position")]
    [IsoXmlTag("ShrtLngPos")]
    public required ShortLong1Code ShortLongPosition { get; init; }

    /// <summary>
    /// Quantity of securities.
    /// </summary>
    [IsoId("_S6IhxTRTEe2id-MjcNoBdw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity45Choice_ Quantity { get; init; }
}
