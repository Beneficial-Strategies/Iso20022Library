// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, eg, party identification or account identification.
/// </summary>
[IsoId("_VC8Tc9p-Ed-ak6NoX_4Aeg_704057901")]
[DisplayName("Generic Identification")]
public record GenericIdentification2
{
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_VC8TdNp-Ed-ak6NoX_4Aeg_704057909")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SchemeName { get; init; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_VC8Tddp-Ed-ak6NoX_4Aeg_704057910")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
