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
[IsoId("_SuUbsa4AEeWL1uap3dNhCQ")]
[DisplayName("Card Account")]
public record CardAccount9
{
    /// <summary>
    /// Sequence number of the account data for multi-account deposit.
    /// </summary>
    [IsoId("_ePFJIK4AEeWL1uap3dNhCQ")]
    [DisplayName("Account Sequence Number")]
    [IsoXmlTag("AcctSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? AccountSequenceNumber { get; init; }

    /// <summary>
    /// Method used by the cardholder and the terminal for the choice of the account.
    /// </summary>
    [IsoId("_S6i50a4AEeWL1uap3dNhCQ")]
    [DisplayName("Selection Method")]
    [IsoXmlTag("SelctnMtd")]
    public AccountChoiceMethod1Code? SelectionMethod { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_S6i5064AEeWL1uap3dNhCQ")]
    [DisplayName("Selected Account Type")]
    [IsoXmlTag("SelctdAcctTp")]
    public CardAccountType3Code? SelectedAccountType { get; init; }

    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_S6i51a4AEeWL1uap3dNhCQ")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AccountName { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_S6i5164AEeWL1uap3dNhCQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public NameAndAddress3? AccountOwner { get; init; }

    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_S6i52a4AEeWL1uap3dNhCQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    [IsoId("_S6i5264AEeWL1uap3dNhCQ")]
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public AccountIdentification31Choice_? AccountIdentifier { get; init; }

    /// <summary>
    /// Internal account reference in case of credit account.
    /// </summary>
    [IsoId("_rUA_EK4AEeWL1uap3dNhCQ")]
    [DisplayName("Credit Reference")]
    [IsoXmlTag("CdtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditReference { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_S6i53a4AEeWL1uap3dNhCQ")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification72Choice_? Servicer { get; init; }
}
