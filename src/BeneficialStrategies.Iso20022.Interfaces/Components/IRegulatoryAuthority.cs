// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity requiring the regulatory reporting information.
/// </summary>
[IsoId("_PbYOANp-Ed-ak6NoX_4Aeg_602491363")]
public interface IRegulatoryAuthority : IIsoComponent
{
    /// <summary>
    /// Name of the entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_PbYOAdp-Ed-ak6NoX_4Aeg_1073487607")]
    [DisplayName("Authority Name")]
    [IsoXmlTag("AuthrtyNm")]
    Max70Text? AuthorityName { get; }

    /// <summary>
    /// Country of the entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_PbYOAtp-Ed-ak6NoX_4Aeg_1100271075")]
    [DisplayName("Authority Country")]
    [IsoXmlTag("AuthrtyCtry")]
    CountryCode? AuthorityCountry { get; }
}
