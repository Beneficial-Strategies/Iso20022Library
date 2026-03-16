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
[IsoId("_QK4R0Yq5EeSIDtZ76p6McQ")]
[DisplayName("Card Account")]
public record CardAccount6
{
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_QW8X44q5EeSIDtZ76p6McQ")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType2Code? AccountType { get; init; }

    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_QW8X5Yq5EeSIDtZ76p6McQ")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AccountName { get; init; }

    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_QW8X54q5EeSIDtZ76p6McQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    [IsoId("_QW8X6Yq5EeSIDtZ76p6McQ")]
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public AccountIdentification31Choice_? AccountIdentifier { get; init; }

    /// <summary>
    /// Internal account reference in case of credit account.
    /// </summary>
    [IsoId("_QW8X64q5EeSIDtZ76p6McQ")]
    [DisplayName("Credit Reference")]
    [IsoXmlTag("CdtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditReference { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_QW8X7Yq5EeSIDtZ76p6McQ")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification72Choice_? Servicer { get; init; }

    /// <summary>
    /// Balance of the account.
    /// </summary>
    [IsoId("_QW8X74q5EeSIDtZ76p6McQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection43? Balance { get; init; }

    /// <summary>
    /// Indicates if the balance must be displayed to the customer on the ATM.
    /// </summary>
    [IsoId("_thBFYIq5EeSIDtZ76p6McQ")]
    [DisplayName("Balance Display Flag")]
    [IsoXmlTag("BalDispFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BalanceDisplayFlag { get; init; }

    /// <summary>
    /// Indicates if this is the default account.
    /// </summary>
    [IsoId("_6RE3gIq5EeSIDtZ76p6McQ")]
    [DisplayName("Default Account Indicator")]
    [IsoXmlTag("DfltAcctInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DefaultAccountIndicator { get; init; }

    /// <summary>
    /// Services allowed on the account.
    /// </summary>
    [IsoId("_kPxHAIq6EeSHjtO_wHA7PQ")]
    [DisplayName("Allowed Services")]
    [IsoXmlTag("AllwdSvcs")]
    public SimpleValueList<ATMServiceType4Code> AllowedServices { get; init; } = [];

    /// <summary>
    /// Withdrawal limits for the account.
    /// </summary>
    [IsoId("_2SK8gIq6EeSHjtO_wHA7PQ")]
    [DisplayName("Withdrawal Limits")]
    [IsoXmlTag("WdrwlLmts")]
    public ATMTransactionAmounts4? WithdrawalLimits { get; init; }

    /// <summary>
    /// Deposit limits for the account.
    /// </summary>
    [IsoId("_cl2S0Iq7EeSHjtO_wHA7PQ")]
    [DisplayName("Deposit Limits")]
    [IsoXmlTag("DpstLmts")]
    public ATMTransactionAmounts5? DepositLimits { get; init; }
}
