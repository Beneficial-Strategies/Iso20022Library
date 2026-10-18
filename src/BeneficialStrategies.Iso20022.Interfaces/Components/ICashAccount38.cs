// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details to identify an account.
/// </summary>
[IsoId("_TnJx8Xh1EeidzqjNEfehPg")]
public interface ICashAccount38 : IIsoComponent
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_T4SlQ3h1EeidzqjNEfehPg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IAccountIdentification4Choice Identification { get; }

    /// <summary>
    /// Specifies the nature, or use of the account.
    /// </summary>
    [IsoId("_T4SlRXh1EeidzqjNEfehPg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    ICashAccountType2Choice? Type { get; }

    /// <summary>
    /// Identification of the currency in which the account is held. ||Usage: Currency should only be used in case one and the same account number covers several currencies|and the initiating party needs to identify which currency needs to be used for settlement on the account.
    /// </summary>
    [IsoId("_T4SlR3h1EeidzqjNEfehPg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    ActiveOrHistoricCurrencyCode? Currency { get; }

    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.||Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_T4SlSXh1EeidzqjNEfehPg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    Max70Text? Name { get; }

    /// <summary>
    /// Specifies an alternate assumed name for the identification of the account.
    /// </summary>
    [IsoId("_dOFYgXiMEeidzqjNEfehPg")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    IProxyAccountIdentification1? Proxy { get; }
}
