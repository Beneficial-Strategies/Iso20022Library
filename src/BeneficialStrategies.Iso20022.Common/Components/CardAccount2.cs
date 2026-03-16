// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account involved in the card transaction.
/// </summary>
[IsoId("_tCyOgXuVEeSVeNXcmBQ4hQ")]
[DisplayName("Card Account")]
public record CardAccount2
{
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_tPJ2k3uVEeSVeNXcmBQ4hQ")]
    [DisplayName("Selected Account Type")]
    [IsoXmlTag("SelctdAcctTp")]
    public CardAccountType2Code? SelectedAccountType { get; init; }

    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_tPJ2lXuVEeSVeNXcmBQ4hQ")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AccountName { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_tPJ2l3uVEeSVeNXcmBQ4hQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public NameAndAddress3? AccountOwner { get; init; }

    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_PptmQHuWEeSVeNXcmBQ4hQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    [IsoId("_tPJ2mXuVEeSVeNXcmBQ4hQ")]
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public AccountIdentification30Choice_? AccountIdentifier { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_tPJ2m3uVEeSVeNXcmBQ4hQ")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification72Choice_? Servicer { get; init; }

    /// <summary>
    ///  Balance of the account.
    /// </summary>
    [IsoId("_XdzNoHuWEeSVeNXcmBQ4hQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection41? Balance { get; init; }

    /// <summary>
    ///  Date of the balance.
    /// </summary>
    [IsoId("_b05wwHuWEeSVeNXcmBQ4hQ")]
    [DisplayName("Balance Date")]
    [IsoXmlTag("BalDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BalanceDate { get; init; }
}
