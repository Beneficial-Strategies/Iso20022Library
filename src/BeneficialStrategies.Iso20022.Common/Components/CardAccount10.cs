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
[IsoId("_Em5UYa4IEeWL1uap3dNhCQ")]
[DisplayName("Card Account")]
public record CardAccount10
{
    /// <summary>
    /// Sequence number of the account data for multi-account deposit.
    /// </summary>
    [IsoId("_EzAdwa4IEeWL1uap3dNhCQ")]
    [DisplayName("Account Sequence Number")]
    [IsoXmlTag("AcctSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? AccountSequenceNumber { get; init; }

    /// <summary>
    /// Method used by the cardholder and the terminal for the choice of the account.
    /// </summary>
    [IsoId("_EzAdw64IEeWL1uap3dNhCQ")]
    [DisplayName("Selection Method")]
    [IsoXmlTag("SelctnMtd")]
    public AccountChoiceMethod1Code? SelectionMethod { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_EzAdxa4IEeWL1uap3dNhCQ")]
    [DisplayName("Selected Account Type")]
    [IsoXmlTag("SelctdAcctTp")]
    public CardAccountType3Code? SelectedAccountType { get; init; }

    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_EzAdx64IEeWL1uap3dNhCQ")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AccountName { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_EzAdya4IEeWL1uap3dNhCQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public NameAndAddress3? AccountOwner { get; init; }

    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_EzAdy64IEeWL1uap3dNhCQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    [IsoId("_EzAdza4IEeWL1uap3dNhCQ")]
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public AccountIdentification31Choice_? AccountIdentifier { get; init; }

    /// <summary>
    /// Internal account reference in case of credit account.
    /// </summary>
    [IsoId("_EzAdz64IEeWL1uap3dNhCQ")]
    [DisplayName("Credit Reference")]
    [IsoXmlTag("CdtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditReference { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_EzAd0a4IEeWL1uap3dNhCQ")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification72Choice_? Servicer { get; init; }

    /// <summary>
    /// Balance of the account.
    /// </summary>
    [IsoId("_ROWkIK4IEeWL1uap3dNhCQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection43? Balance { get; init; }

    /// <summary>
    /// Indicates if the balance must be displayed to the customer on the ATM.
    /// </summary>
    [IsoId("_VRg3kK4IEeWL1uap3dNhCQ")]
    [DisplayName("Balance Display Flag")]
    [IsoXmlTag("BalDispFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BalanceDisplayFlag { get; init; }

    /// <summary>
    /// Indicates if this is the default account.
    /// </summary>
    [IsoId("_ZazBIK4IEeWL1uap3dNhCQ")]
    [DisplayName("Default Account Indicator")]
    [IsoXmlTag("DfltAcctInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DefaultAccountIndicator { get; init; }

    /// <summary>
    /// Limit of amounts for the customer.
    /// </summary>
    [IsoId("_eV4bEK4IEeWL1uap3dNhCQ")]
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ATMTransactionAmounts8? Limits { get; init; }
}
