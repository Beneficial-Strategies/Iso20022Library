// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the identification of an individual person.
/// </summary>
[IsoId("_P-2HcNp-Ed-ak6NoX_4Aeg_498545579")]
[DisplayName("Generic Identification")]
public record GenericIdentification9
{
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    [IsoId("_P_b9UNp-Ed-ak6NoX_4Aeg_498545614")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies the nature of the identification.
    /// </summary>
    [IsoId("_P_b9Udp-Ed-ak6NoX_4Aeg_498545674")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required PersonIdentificationType1Code IdentificationType { get; init; }

    /// <summary>
    /// Specifies the nature of the identification.
    /// </summary>
    [IsoId("_P_b9Utp-Ed-ak6NoX_4Aeg_1879867766")]
    [DisplayName("Extended Identification Type")]
    [IsoXmlTag("XtndedIdTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedIdentificationType { get; init; }

    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    [IsoId("_P_b9U9p-Ed-ak6NoX_4Aeg_498545734")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }

    /// <summary>
    /// Date at which the identification was issued.
    /// </summary>
    [IsoId("_P_b9VNp-Ed-ak6NoX_4Aeg_285572379")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// Date at which the identification expires.
    /// </summary>
    [IsoId("_P_b9Vdp-Ed-ak6NoX_4Aeg_285573411")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; }
}
