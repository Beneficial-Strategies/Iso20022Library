// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Account20.
/// </summary>
[IsoId("_PICvEZ-TEe-nbM0aSPcoiQ")]
[DisplayName("Card Account20")]
public record CardAccount20
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
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

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
