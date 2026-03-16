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
[IsoId("_DGuj8YrrEeq91phomTRDDA")]
[DisplayName("Security Identification")]
public record SecurityIdentification22
{
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_DHeK0YrrEeq91phomTRDDA")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISIN2021Identifier)]
    public IsoISIN2021Identifier? ISIN { get; init; }

    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_ESTmQYrrEeq91phomTRDDA")]
    [DisplayName("Unique Product Identifier")]
    [IsoXmlTag("UnqPdctIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? UniqueProductIdentifier { get; init; }

    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_DHeK04rrEeq91phomTRDDA")]
    [DisplayName("Alternative Instrument Identification")]
    [IsoXmlTag("AltrntvInstrmId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? AlternativeInstrumentIdentification { get; init; }
}
