// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer account information.
/// </summary>
[IsoId("_1deaMa4zEeWpsoxRhdX-8A")]
[DisplayName("Card Account")]
public record CardAccount13
{
    /// <summary>
    /// Type of account used for the transaction.
    /// </summary>
    [IsoId("_1pjHU64zEeWpsoxRhdX-8A")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType3Code? AccountType { get; init; }

    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_1pjHVa4zEeWpsoxRhdX-8A")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AccountName { get; init; }

    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_1pjHWa4zEeWpsoxRhdX-8A")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    [IsoId("_1pjHW64zEeWpsoxRhdX-8A")]
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public AccountIdentification31Choice_? AccountIdentifier { get; init; }

    /// <summary>
    /// Internal account reference in case of credit account.
    /// </summary>
    [IsoId("_LprWoK40EeWpsoxRhdX-8A")]
    [DisplayName("Credit Reference")]
    [IsoXmlTag("CdtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditReference { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_1pjHXa4zEeWpsoxRhdX-8A")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification72Choice_? Servicer { get; init; }

    /// <summary>
    /// Balance of the account before the transfer.
    /// </summary>
    [IsoId("_SxcqkK40EeWpsoxRhdX-8A")]
    [DisplayName("Balance Before")]
    [IsoXmlTag("BalBfr")]
    public AmountAndDirection43? BalanceBefore { get; init; }

    /// <summary>
    /// Balance of the account after the transfer.
    /// </summary>
    [IsoId("_VmsZYK40EeWpsoxRhdX-8A")]
    [DisplayName("Balance After")]
    [IsoXmlTag("BalAftr")]
    public AmountAndDirection43? BalanceAfter { get; init; }
}
