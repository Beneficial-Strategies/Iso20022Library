// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal or deposit of an amount of money defined in cash coins.
/// </summary>
[IsoId("_lb1etEBcEfCGo6pGJ7j7Eg")]
[DisplayName("Cash Coin1")]
public record CashCoin1
{
    /// <summary>
    /// Type of cash.
    /// </summary>
    [IsoId("_qN7JYFDeEfCRhs5qxCujTw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashType1Choice_? Type { get; init; }

    /// <summary>
    /// Reference for the box holding these coins.
    /// </summary>
    [IsoId("_VIIlIatkEfC6tbn8zOl_iw")]
    [DisplayName("Box Reference")]
    [IsoXmlTag("BxRef")]
    public IsoMax35Text? BoxReference { get; init; }

    /// <summary>
    /// Specifies the coin denomination, including the currency, such as a euro 50 cent coin.
    /// </summary>
    [IsoId("_lb1et0BcEfCGo6pGJ7j7Eg")]
    [DisplayName("Coin Denomination")]
    [IsoXmlTag("CoinDnmtn")]
    public ActiveCurrencyAndAmount? CoinDenomination { get; init; }

    /// <summary>
    /// Specifies the number of coins of the same denomination.
    /// </summary>
    [IsoId("_lb1etUBcEfCGo6pGJ7j7Eg")]
    [DisplayName("Number Of Coins")]
    [IsoXmlTag("NbOfCoins")]
    public IsoMax15NumericText? NumberOfCoins { get; init; }

    /// <summary>
    /// Specifies the total amount of money for this coin denomination, that is the coin denomination times the number of coins.
    /// </summary>
    [IsoId("_lb1etkBcEfCGo6pGJ7j7Eg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
