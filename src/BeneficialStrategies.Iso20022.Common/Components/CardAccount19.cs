// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Account19.
/// </summary>
[IsoId("_q7MX0Z-REe-nbM0aSPcoiQ")]
[DisplayName("Card Account19")]
public record CardAccount19
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
    /// Account Type.
    /// </summary>
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType3Code? AccountType { get; init; }

    /// <summary>
    /// Balance After.
    /// </summary>
    [DisplayName("Balance After")]
    [IsoXmlTag("BalAftr")]
    public AmountAndDirection111? BalanceAfter { get; init; }

    /// <summary>
    /// Balance Before.
    /// </summary>
    [DisplayName("Balance Before")]
    [IsoXmlTag("BalBfr")]
    public AmountAndDirection111? BalanceBefore { get; init; }

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
    /// Servicer.
    /// </summary>
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification177Choice_? Servicer { get; init; }
}
