// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of garnishment.
/// </summary>
[IsoId("_LLLooYnnEeOORMXOfBk1Bw")]
public interface IGarnishmentType1 : IIsoComponent
{
    /// <summary>
    /// Provides the type details of the garnishment.
    /// </summary>
    [IsoId("_LWYzE4nnEeOORMXOfBk1Bw")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    IGarnishmentType1Choice CodeOrProprietary { get; }

    /// <summary>
    /// Identification of the issuer of the garnishment type.
    /// </summary>
    [IsoId("_LWYzFYnnEeOORMXOfBk1Bw")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    IsoMax35Text? Issuer { get; }
}
