// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of the document line identification.
/// </summary>
[IsoId("_cX4kMablEeKvUvwX_r3tzA")]
public interface IDocumentLineType1 : IIsoComponent
{
    /// <summary>
    /// Provides the type details of the referred document line identification.
    /// </summary>
    [IsoId("_ciKhlablEeKvUvwX_r3tzA")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    IDocumentLineType1Choice CodeOrProprietary { get; }

    /// <summary>
    /// Identification of the issuer of the reference document line identificationtype.
    /// </summary>
    [IsoId("_ciKhmablEeKvUvwX_r3tzA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    Max35Text? Issuer { get; }
}
