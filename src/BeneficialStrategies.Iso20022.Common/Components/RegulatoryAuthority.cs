// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity requiring the regulatory reporting information.
/// </summary>
[IsoId("_PbYOANp-Ed-ak6NoX_4Aeg_602491363")]
[DisplayName("Regulatory Authority")]
public record RegulatoryAuthority
{
    /// <summary>
    /// Name of the entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_PbYOAdp-Ed-ak6NoX_4Aeg_1073487607")]
    [DisplayName("Authority Name")]
    [IsoXmlTag("AuthrtyNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AuthorityName { get; init; }

    /// <summary>
    /// Country of the entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_PbYOAtp-Ed-ak6NoX_4Aeg_1100271075")]
    [DisplayName("Authority Country")]
    [IsoXmlTag("AuthrtyCtry")]
    public CountryCode? AuthorityCountry { get; init; }
}
