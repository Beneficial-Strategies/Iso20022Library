// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a party.
/// </summary>
[IsoId("_0MzpxzEyEe6g-ffJsqGiSA")]
public interface INameAndAddress18 : IIsoComponent
{
    /// <summary>
    /// Name by which a party is known and is usually used to identify that party.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    Max140Text Name { get; }

    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    IPostalAddress27 Address { get; }
}
