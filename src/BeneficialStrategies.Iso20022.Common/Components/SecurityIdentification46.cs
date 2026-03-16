// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
/// </summary>
[IsoId("_f72qkWEUEe2P-L9DBerEgA")]
[DisplayName("Security Identification")]
public record SecurityIdentification46
{
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_f8tmM2EUEe2P-L9DBerEgA")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? ISIN { get; init; }

    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_f8tmNWEUEe2P-L9DBerEgA")]
    [DisplayName("Unique Product Identifier")]
    [IsoXmlTag("UnqPdctIdr")]
    public UniqueProductIdentifier2Choice_? UniqueProductIdentifier { get; init; }

    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_f8tmN2EUEe2P-L9DBerEgA")]
    [DisplayName("Alternative Instrument Identification")]
    [IsoXmlTag("AltrntvInstrmId")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AlternativeInstrumentIdentification { get; init; }

    /// <summary>
    /// Specifies a human readable description of the product.
    /// </summary>
    [IsoId("_f8tmOWEUEe2P-L9DBerEgA")]
    [DisplayName("Product Description")]
    [IsoXmlTag("PdctDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? ProductDescription { get; init; }
}
