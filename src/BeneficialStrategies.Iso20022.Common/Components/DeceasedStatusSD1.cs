// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deceased beneficial owner information details.
/// </summary>
[IsoId("_JuPnQcX8EeexPc-mfUU5zQ")]
[DisplayName("Deceased Status SD")]
public record DeceasedStatusSD1
{
    /// <summary>
    /// Name by which the beneficial owner is known.
    /// </summary>
    [IsoId("_5C1u8cX9EeexPc-mfUU5zQ")]
    [DisplayName("Beneficial Owner Name")]
    [IsoXmlTag("BnfclOwnrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text BeneficialOwnerName { get; init; }

    /// <summary>
    /// Date of death of the beneficial owner.
    /// </summary>
    [IsoId("_JuPnQ8X8EeexPc-mfUU5zQ")]
    [DisplayName("Death Date")]
    [IsoXmlTag("DthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DeathDate { get; init; }

    /// <summary>
    /// Death certificate number of the beneficial owner.
    /// </summary>
    [IsoId("_JuPnRMX8EeexPc-mfUU5zQ")]
    [DisplayName("Death Certificate Serial Number")]
    [IsoXmlTag("DthCertSrlNb")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? DeathCertificateSerialNumber { get; init; }

    /// <summary>
    /// Jurisdiction by which the certificate of deposit was issued.
    /// </summary>
    [IsoId("_JuPnQsX8EeexPc-mfUU5zQ")]
    [DisplayName("Issuing Jurisdiction")]
    [IsoXmlTag("IssgJursdctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IssuingJurisdiction { get; init; }
}
