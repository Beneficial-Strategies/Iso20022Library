// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific branch of a financial institution.
/// </summary>
[IsoId("_TFUwMdp-Ed-ak6NoX_4Aeg_-275983969")]
public interface IBranchData : IIsoComponent
{
    /// <summary>
    /// Unique and unambiguous identification of a branch of a financial institution.
    /// </summary>
    [IsoId("_TFUwMtp-Ed-ak6NoX_4Aeg_-242735819")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    Max35Text? Identification { get; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_TFUwM9p-Ed-ak6NoX_4Aeg_14002178")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    Max35Text? Name { get; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_TFUwNNp-Ed-ak6NoX_4Aeg_-1619654726")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    IPostalAddress1? PostalAddress { get; }
}
