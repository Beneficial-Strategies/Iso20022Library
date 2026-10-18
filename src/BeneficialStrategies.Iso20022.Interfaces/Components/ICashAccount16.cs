// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify an account.
/// </summary>
[IsoId("_SOfO0dp-Ed-ak6NoX_4Aeg_-1249068086")]
public interface ICashAccount16 : IIsoComponent
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SOfO0tp-Ed-ak6NoX_4Aeg_-1205661377")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IAccountIdentification4Choice Identification { get; }

    /// <summary>
    /// Specifies the nature, or use of the account.
    /// </summary>
    [IsoId("_SOfO09p-Ed-ak6NoX_4Aeg_-1249067501")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    ICashAccountType2? Type { get; }

    /// <summary>
    /// Identification of the currency in which the account is held. ||Usage: Currency should only be used in case one and the same account number covers several currencies|and the initiating party needs to identify which currency needs to be used for settlement on the account.
    /// </summary>
    [IsoId("_SOfO1Np-Ed-ak6NoX_4Aeg_-1249068056")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    ActiveOrHistoricCurrencyCode? Currency { get; }

    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.||Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_SOfO1dp-Ed-ak6NoX_4Aeg_-1249068025")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    IsoMax70Text? Name { get; }
}
