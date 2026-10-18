// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of creditor reference.
/// </summary>
[IsoId("_T4ItMtp-Ed-ak6NoX_4Aeg_604337645")]
public interface ICreditorReferenceType2 : IIsoComponent
{
    /// <summary>
    /// Coded or proprietary format creditor reference type.
    /// </summary>
    [IsoId("_T4ItM9p-Ed-ak6NoX_4Aeg_710539957")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    ICreditorReferenceType1Choice CodeOrProprietary { get; }

    /// <summary>
    /// Entity that assigns the credit reference type.
    /// </summary>
    [IsoId("_T4ItNNp-Ed-ak6NoX_4Aeg_604337984")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    Max35Text? Issuer { get; }
}
