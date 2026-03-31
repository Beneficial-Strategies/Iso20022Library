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
[IsoId("_Q0fWAtp-Ed-ak6NoX_4Aeg_-2068153748")]
[DisplayName("Proprietary Quantity")]
public record ProprietaryQuantity2
{
    /// <summary>
    /// Provides the proprietary quantity with a decimal number.
    /// </summary>
    [IsoId("_Q0fWA9p-Ed-ak6NoX_4Aeg_-832480143")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Quantity { get; init; }

    /// <summary>
    /// Identifies the type of proprietary quantity reported.
    /// </summary>
    [IsoId("_Q0fWBNp-Ed-ak6NoX_4Aeg_-1139088802")]
    [DisplayName("Quantity Type")]
    [IsoXmlTag("QtyTp")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText QuantityType { get; init; }

    /// <summary>
    /// Provides information related to issuer in free format.
    /// </summary>
    [IsoId("_Q0fWBdp-Ed-ak6NoX_4Aeg_-1320102317")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Issuer { get; init; }

    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_Q0fWBtp-Ed-ak6NoX_4Aeg_-1179725606")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SchemeName { get; init; }
}
