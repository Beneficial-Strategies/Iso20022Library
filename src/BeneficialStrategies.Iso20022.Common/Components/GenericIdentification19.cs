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
[IsoId("_P-Zbi9p-Ed-ak6NoX_4Aeg_-805818818")]
[DisplayName("Generic Identification")]
public record GenericIdentification19
{
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    [IsoId("_P-ZbjNp-Ed-ak6NoX_4Aeg_993133587")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_P-Zbjdp-Ed-ak6NoX_4Aeg_174179906")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Issuer { get; init; }

    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    [IsoId("_P-ilcNp-Ed-ak6NoX_4Aeg_879294521")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SchemeName { get; init; }
}
