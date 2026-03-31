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
[IsoId("_8SD2Aa17EeWMg5rOByfExw")]
[DisplayName("Card Account")]
public record CardAccount8
{
    /// <summary>
    /// Method used by the cardholder and the terminal for the choice of the account.
    /// </summary>
    [IsoId("_8eSUIa17EeWMg5rOByfExw")]
    [DisplayName("Selection Method")]
    [IsoXmlTag("SelctnMtd")]
    public AccountChoiceMethod1Code? SelectionMethod { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_8eSUI617EeWMg5rOByfExw")]
    [DisplayName("Selected Account Type")]
    [IsoXmlTag("SelctdAcctTp")]
    public CardAccountType3Code? SelectedAccountType { get; init; }

    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_8eSUJa17EeWMg5rOByfExw")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AccountName { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_8eSUJ617EeWMg5rOByfExw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public NameAndAddress3? AccountOwner { get; init; }

    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_8eSUKa17EeWMg5rOByfExw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    [IsoId("_8eSUK617EeWMg5rOByfExw")]
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public AccountIdentification31Choice_? AccountIdentifier { get; init; }

    /// <summary>
    /// Internal account reference in case of credit account.
    /// </summary>
    [IsoId("_8eSULa17EeWMg5rOByfExw")]
    [DisplayName("Credit Reference")]
    [IsoXmlTag("CdtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditReference { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_8eSUL617EeWMg5rOByfExw")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification72Choice_? Servicer { get; init; }

    /// <summary>
    /// Balance of the account.
    /// </summary>
    [IsoId("_8eSUMa17EeWMg5rOByfExw")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection43? Balance { get; init; }

    /// <summary>
    /// Indicates if the balance must be displayed to the customer on the ATM.
    /// </summary>
    [IsoId("_8eSUM617EeWMg5rOByfExw")]
    [DisplayName("Balance Display Flag")]
    [IsoXmlTag("BalDispFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BalanceDisplayFlag { get; init; }

    /// <summary>
    /// Indicates if this is the default account.
    /// </summary>
    [IsoId("_8eSUNa17EeWMg5rOByfExw")]
    [DisplayName("Default Account Indicator")]
    [IsoXmlTag("DfltAcctInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DefaultAccountIndicator { get; init; }
}
