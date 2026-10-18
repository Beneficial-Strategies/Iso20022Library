// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the authorised tax paying party.
/// </summary>
[IsoId("_Pc3bx9p-Ed-ak6NoX_4Aeg_-197973580")]
public interface ITaxAuthorisation1 : IIsoComponent
{
    /// <summary>
    /// Title or position of debtor or the debtor&apos;s authorised representative.
    /// </summary>
    [IsoId("_Pc3byNp-Ed-ak6NoX_4Aeg_-197973519")]
    [DisplayName("Title")]
    [IsoXmlTag("Titl")]
    IsoMax35Text? Title { get; }

    /// <summary>
    /// Name of the debtor or the debtor&apos;s authorised representative.
    /// </summary>
    [IsoId("_PdBMwNp-Ed-ak6NoX_4Aeg_-197973549")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    IsoMax140Text? Name { get; }
}
