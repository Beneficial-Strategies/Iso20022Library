// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about the entity involved in the tax paid or to be paid.
/// </summary>
[IsoId("_PdBMwdp-Ed-ak6NoX_4Aeg_920823246")]
public interface ITaxParty2 : IIsoComponent
{
    /// <summary>
    /// Tax identification number of the debtor.
    /// </summary>
    [IsoId("_PdBMwtp-Ed-ak6NoX_4Aeg_920823361")]
    [DisplayName("Tax Identification")]
    [IsoXmlTag("TaxId")]
    IsoMax35Text? TaxIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_PdBMw9p-Ed-ak6NoX_4Aeg_920823300")]
    [DisplayName("Registration Identification")]
    [IsoXmlTag("RegnId")]
    IsoMax35Text? RegistrationIdentification { get; }

    /// <summary>
    /// Type of tax payer.
    /// </summary>
    [IsoId("_PdBMxNp-Ed-ak6NoX_4Aeg_920823277")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    IsoMax35Text? TaxType { get; }

    /// <summary>
    /// Details of the authorised tax paying party.
    /// </summary>
    [IsoId("_PdBMxdp-Ed-ak6NoX_4Aeg_-137944593")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    ITaxAuthorisation1? Authorisation { get; }
}
