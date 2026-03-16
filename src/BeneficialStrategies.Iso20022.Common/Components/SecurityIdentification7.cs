// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between ISIN and an alternative format for the identification of a security. ISIN is the preferred format.
/// </summary>
[IsoId("_QdZErtp-Ed-ak6NoX_4Aeg_-2112411865")]
[DisplayName("Security Identification")]
public record SecurityIdentification7
{
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_QdZEr9p-Ed-ak6NoX_4Aeg_-2112411847")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    public required IsoISINIdentifier ISIN { get; init; }

    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_QdZEsNp-Ed-ak6NoX_4Aeg_-2112411727")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public required AlternateSecurityIdentification3 OtherIdentification { get; init; }

    /// <summary>
    /// Textual description of a security instrument.
    /// </summary>
    [IsoId("_QdZEsdp-Ed-ak6NoX_4Aeg_-1321876969")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; }
}
