// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of creditor reference.
/// </summary>
[IsoId("_7xH-hTEsEe6GxLzpkVnWYg")]
public interface ICreditorReferenceType3 : IIsoComponent
{
    /// <summary>
    /// Coded or proprietary format creditor reference type.
    /// </summary>
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    ICreditorReferenceType2Choice CodeOrProprietary { get; }

    /// <summary>
    /// Entity that assigns the credit reference type.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    Max35Text? Issuer { get; }
}
