// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary quantity format.
/// </summary>
[IsoId("_3XncoTq5EeWQ1Y7f8kds2A")]
[DisplayName("Proprietary Quantity")]
public record ProprietaryQuantity7
{
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    [IsoId("_3jqUlTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Short Long Position")]
    [IsoXmlTag("ShrtLngPos")]
    public ShortLong1Code? ShortLongPosition { get; init; }

    /// <summary>
    /// Provides the proprietary quantity with a decimal number.
    /// </summary>
    [IsoId("_3jqUlzq5EeWQ1Y7f8kds2A")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Quantity { get; init; }

    /// <summary>
    /// Identifies the type of proprietary quantity reported.
    /// </summary>
    [IsoId("_3jqUmTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Quantity Type")]
    [IsoXmlTag("QtyTp")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText QuantityType { get; init; }

    /// <summary>
    /// Provides information related to issuer in free format.
    /// </summary>
    [IsoId("_3jqUmzq5EeWQ1Y7f8kds2A")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Issuer { get; init; }

    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_3jqUozq5EeWQ1Y7f8kds2A")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SchemeName { get; init; }
}
