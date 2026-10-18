// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about the entity involved in the tax paid or to be paid.
/// </summary>
[IsoId("_PdBMxtp-Ed-ak6NoX_4Aeg_-1937885674")]
public interface ITaxParty1 : IIsoComponent
{
    /// <summary>
    /// Tax identification number of the creditor.
    /// </summary>
    [IsoId("_PdBMx9p-Ed-ak6NoX_4Aeg_-1937885612")]
    [DisplayName("Tax Identification")]
    [IsoXmlTag("TaxId")]
    IsoMax35Text? TaxIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_PdBMyNp-Ed-ak6NoX_4Aeg_-1937885613")]
    [DisplayName("Registration Identification")]
    [IsoXmlTag("RegnId")]
    IsoMax35Text? RegistrationIdentification { get; }

    /// <summary>
    /// Type of tax payer.
    /// </summary>
    [IsoId("_PdKWsNp-Ed-ak6NoX_4Aeg_-1937885634")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    IsoMax35Text? TaxType { get; }
}
