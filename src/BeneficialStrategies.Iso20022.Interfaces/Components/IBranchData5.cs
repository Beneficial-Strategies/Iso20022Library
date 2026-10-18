// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Branch Data5.
/// </summary>
[IsoId("_v0bUQTEyEe6g-ffJsqGiSA")]
public interface IBranchData5 : IIsoComponent
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    Max35Text? Identification { get; }

    /// <summary>
    /// LEI.
    /// </summary>
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    LEIIdentifier? LEI { get; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    Max140Text? Name { get; }

    /// <summary>
    /// Postal Address.
    /// </summary>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    IPostalAddress27? PostalAddress { get; }
}
