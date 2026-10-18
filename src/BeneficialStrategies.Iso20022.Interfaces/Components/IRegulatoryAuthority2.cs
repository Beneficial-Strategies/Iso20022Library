// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity requiring the regulatory reporting information.
/// </summary>
[IsoId("_Pc3bxNp-Ed-ak6NoX_4Aeg_-1526379440")]
public interface IRegulatoryAuthority2 : IIsoComponent
{
    /// <summary>
    /// Name of the entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_Pc3bxdp-Ed-ak6NoX_4Aeg_-1526379192")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    IsoMax140Text? Name { get; }

    /// <summary>
    /// Country of the entity that requires the regulatory reporting information.
    /// </summary>
    [IsoId("_Pc3bxtp-Ed-ak6NoX_4Aeg_-1526379191")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    CountryCode? Country { get; }
}
