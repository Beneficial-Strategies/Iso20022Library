// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a party.
/// </summary>
[IsoId("_Pa7iEdp-Ed-ak6NoX_4Aeg_1232530799")]
public interface INameAndAddress10 : IIsoComponent
{
    /// <summary>
    /// Name by which a party is known and is usually used to identify that party.
    /// </summary>
    [IsoId("_Pa7iEtp-Ed-ak6NoX_4Aeg_1232531078")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    Max140Text Name { get; }

    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_Pa7iE9p-Ed-ak6NoX_4Aeg_1232531138")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    IPostalAddress6 Address { get; }
}
