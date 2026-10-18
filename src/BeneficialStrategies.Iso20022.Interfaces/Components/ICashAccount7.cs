// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used for identifying an account.
/// </summary>
[IsoId("_SOWE5dp-Ed-ak6NoX_4Aeg_1852119759")]
public interface ICashAccount7 : IIsoComponent
{
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SOWE5tp-Ed-ak6NoX_4Aeg_-199286992")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IAccountIdentification3Choice Identification { get; }

    /// <summary>
    /// Nature, or use, of the account.
    /// </summary>
    [IsoId("_SOWE59p-Ed-ak6NoX_4Aeg_-1087100330")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    ICashAccountType2? Type { get; }

    /// <summary>
    /// Identification of the currency in which the account is held. ||Usage: Currency should only be used in case one and the same account number covers several currencies and the initiating party needs to identify which currency needs to be used for settlement on the account.
    /// </summary>
    [IsoId("_SOWE6Np-Ed-ak6NoX_4Aeg_-199287087")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    CurrencyCode? Currency { get; }

    /// <summary>
    /// Name of the account, assigned by the account servicing institution in agreement with the account owner in order to provide an additional means of identification of the account.||Usage: the account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_SOfO0Np-Ed-ak6NoX_4Aeg_-199287052")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    Max70Text? Name { get; }
}
