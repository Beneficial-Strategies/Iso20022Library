// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document Type1.
/// </summary>
[IsoId("_O2EK4TE0Ee62xuUQ2zyZww")]
public interface IDocumentType1 : IIsoComponent
{
    /// <summary>
    /// Code Or Proprietary.
    /// </summary>
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    IDocumentType2Choice CodeOrProprietary { get; }

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    IsoMax35Text? Issuer { get; }
}
