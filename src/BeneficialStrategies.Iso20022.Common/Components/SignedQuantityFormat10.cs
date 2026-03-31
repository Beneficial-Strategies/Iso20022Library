// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed quantity of security formats.
/// </summary>
[IsoId("_GZ0jYRuyEeyhRdHRjakS2w")]
[DisplayName("Signed Quantity Format")]
public record SignedQuantityFormat10
{
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    [IsoId("_Gu-7ERuyEeyhRdHRjakS2w")]
    [DisplayName("Short Long Position")]
    [IsoXmlTag("ShrtLngPos")]
    public required ShortLong1Code ShortLongPosition { get; init; }

    /// <summary>
    /// Quantity of security.
    /// </summary>
    [IsoId("_Gu-7ExuyEeyhRdHRjakS2w")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity33Choice_ Quantity { get; init; }
}
