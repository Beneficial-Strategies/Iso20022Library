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
[IsoId("_EVgs8YoiEeSaAcF2oE2GNQ")]
[DisplayName("Card Account")]
public record CardAccount3
{
    /// <summary>
    /// Method used by the cardholder and the terminal for the choice of the account.
    /// </summary>
    [IsoId("_EjCyoYoiEeSaAcF2oE2GNQ")]
    [DisplayName("Selection Method")]
    [IsoXmlTag("SelctnMtd")]
    public AccountChoiceMethod1Code? SelectionMethod { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_EjCyo4oiEeSaAcF2oE2GNQ")]
    [DisplayName("Selected Account Type")]
    [IsoXmlTag("SelctdAcctTp")]
    public CardAccountType2Code? SelectedAccountType { get; init; }

    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_EjCypYoiEeSaAcF2oE2GNQ")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AccountName { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_EjCyp4oiEeSaAcF2oE2GNQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public NameAndAddress3? AccountOwner { get; init; }

    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_ZSvU0IoiEeSaAcF2oE2GNQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    [IsoId("_EjCyqYoiEeSaAcF2oE2GNQ")]
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public AccountIdentification31Choice_? AccountIdentifier { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_EjCyq4oiEeSaAcF2oE2GNQ")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification72Choice_? Servicer { get; init; }
}
