// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organisation Identification39.
/// </summary>
[IsoId("_bKD8BTFIEe651u5xu3f5iw")]
public interface IOrganisationIdentification39 : IIsoComponent
{
    /// <summary>
    /// Any BIC.
    /// </summary>
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    AnyBICDec2014Identifier? AnyBIC { get; }

    /// <summary>
    /// LEI.
    /// </summary>
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    LEIIdentifier? LEI { get; }

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    IEnumerable<IGenericOrganisationIdentification3> Other { get; }
}
