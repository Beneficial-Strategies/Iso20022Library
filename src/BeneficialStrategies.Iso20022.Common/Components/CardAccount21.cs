// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Account21.
/// </summary>
[IsoId("_TWaNoaDrEe-MRKYsaX6JDg")]
[DisplayName("Card Account21")]
public record CardAccount21
{
    /// <summary>
    /// Account Identifier.
    /// </summary>
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public AccountIdentification80Choice_? AccountIdentifier { get; init; }

    /// <summary>
    /// Account Name.
    /// </summary>
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    public IsoMax70Text? AccountName { get; init; }

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public NameAndAddress3? AccountOwner { get; init; }

    /// <summary>
    /// Account Sequence Number.
    /// </summary>
    [DisplayName("Account Sequence Number")]
    [IsoXmlTag("AcctSeqNb")]
    public IsoNumber? AccountSequenceNumber { get; init; }

    /// <summary>
    /// Balance.
    /// </summary>
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection111? Balance { get; init; }

    /// <summary>
    /// Balance Display Flag.
    /// </summary>
    [DisplayName("Balance Display Flag")]
    [IsoXmlTag("BalDispFlg")]
    public IsoTrueFalseIndicator? BalanceDisplayFlag { get; init; }

    /// <summary>
    /// Credit Reference.
    /// </summary>
    [DisplayName("Credit Reference")]
    [IsoXmlTag("CdtRef")]
    public IsoMax35Text? CreditReference { get; init; }

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Default Account Indicator.
    /// </summary>
    [DisplayName("Default Account Indicator")]
    [IsoXmlTag("DfltAcctInd")]
    public IsoTrueFalseIndicator? DefaultAccountIndicator { get; init; }

    /// <summary>
    /// Limits.
    /// </summary>
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ATMTransactionAmounts11? Limits { get; init; }

    /// <summary>
    /// Selected Account Type.
    /// </summary>
    [DisplayName("Selected Account Type")]
    [IsoXmlTag("SelctdAcctTp")]
    public CardAccountType3Code? SelectedAccountType { get; init; }

    /// <summary>
    /// Selection Method.
    /// </summary>
    [DisplayName("Selection Method")]
    [IsoXmlTag("SelctnMtd")]
    public AccountChoiceMethod1Code? SelectionMethod { get; init; }

    /// <summary>
    /// Servicer.
    /// </summary>
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification177Choice_? Servicer { get; init; }
}
