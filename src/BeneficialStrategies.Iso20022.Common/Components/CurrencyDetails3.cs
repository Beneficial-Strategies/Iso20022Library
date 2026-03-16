// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a currency.
/// </summary>
[IsoId("_k8F0MfayEeerBJ4shjAzSA")]
[DisplayName("Currency Details")]
public record CurrencyDetails3
{
    /// <summary>
    /// Alpha currency code (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_lM53YfayEeerBJ4shjAzSA")]
    [DisplayName("Alpha Code")]
    [IsoXmlTag("AlphaCd")]
    public required ActiveCurrencyCode AlphaCode { get; init; }

    /// <summary>
    /// Numeric currency code (ISO 4217, 3 numeric characters).
    /// </summary>
    [IsoId("_lM53Y_ayEeerBJ4shjAzSA")]
    [DisplayName("Numeric Code")]
    [IsoXmlTag("NmrcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText NumericCode { get; init; }

    /// <summary>
    /// Maximal number of digits after the decimal separator for the currency.
    /// </summary>
    [IsoId("_lM53ZfayEeerBJ4shjAzSA")]
    [DisplayName("Decimal")]
    [IsoXmlTag("Dcml")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Decimal { get; init; }

    /// <summary>
    /// Full name of the currency.
    /// </summary>
    [IsoId("_lM53Z_ayEeerBJ4shjAzSA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }
}
