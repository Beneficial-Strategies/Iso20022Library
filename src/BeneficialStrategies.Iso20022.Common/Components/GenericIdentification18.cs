// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, for example, party identification or account identification.
/// </summary>
[IsoId("_WeJGK9p-Ed-ak6NoX_4Aeg_-458352417")]
[DisplayName("Generic Identification")]
public record GenericIdentification18
{
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    [IsoId("_WeJGLNp-Ed-ak6NoX_4Aeg_1842470173")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax30Text)]
    [StringLength(maximumLength: 30, MinimumLength = 1)]
    public required IsoRestrictedFINXMax30Text Identification { get; init; }

    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_WeSQENp-Ed-ak6NoX_4Aeg_-151674533")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4AlphaNumericText? SchemeName { get; init; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_WeSQEdp-Ed-ak6NoX_4Aeg_-2145819239")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4AlphaNumericText? Issuer { get; init; }
}
