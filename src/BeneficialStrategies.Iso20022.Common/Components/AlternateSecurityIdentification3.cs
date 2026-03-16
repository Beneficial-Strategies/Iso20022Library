// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary or domestic identification scheme that uniquely identifies a security.
/// </summary>
[IsoId("_SlI0Q9p-Ed-ak6NoX_4Aeg_735400890")]
[DisplayName("Alternate Security Identification")]
public record AlternateSecurityIdentification3
{
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    [IsoId("_SlI0RNp-Ed-ak6NoX_4Aeg_735401045")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text Identification { get; init; }

    /// <summary>
    /// Country of the proprietary identification scheme.
    /// </summary>
    [IsoId("_SlI0Rdp-Ed-ak6NoX_4Aeg_735400907")]
    [DisplayName("Domestic Identification Source")]
    [IsoXmlTag("DmstIdSrc")]
    public required CountryCode DomesticIdentificationSource { get; init; }

    /// <summary>
    /// Entity that issues the proprietary identification.
    /// </summary>
    [IsoId("_SlI0Rtp-Ed-ak6NoX_4Aeg_735400960")]
    [DisplayName("Proprietary Identification Source")]
    [IsoXmlTag("PrtryIdSrc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ProprietaryIdentificationSource { get; init; }
}
