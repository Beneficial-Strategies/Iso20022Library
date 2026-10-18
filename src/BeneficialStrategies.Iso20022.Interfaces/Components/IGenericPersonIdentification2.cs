// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Generic Person Identification2.
/// </summary>
[IsoId("__Aaz9TFLEe651u5xu3f5iw")]
public interface IGenericPersonIdentification2 : IIsoComponent
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    Max256Text Identification { get; }

    /// <summary>
    /// Scheme Name.
    /// </summary>
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    IPersonIdentificationSchemeName1Choice? SchemeName { get; }

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    Max35Text? Issuer { get; }
}
