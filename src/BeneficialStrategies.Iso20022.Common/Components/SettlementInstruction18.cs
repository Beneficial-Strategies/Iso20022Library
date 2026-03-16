// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Instruction18.
/// </summary>
[IsoId("_g3RCUBHXEe-kEa3VymLrcQ")]
[DisplayName("Settlement Instruction18")]
public record SettlementInstruction18
{
    /// <summary>
    /// Buy Sell Indicator.
    /// </summary>
    [DisplayName("Buy Sell Indicator")]
    [IsoXmlTag("")]
    public required IsoYesNoIndicator BuySellIndicator { get; init; }

    /// <summary>
    /// Currency Amount.
    /// </summary>
    [DisplayName("Currency Amount")]
    [IsoXmlTag("")]
    public required CurrencyAndAmount CurrencyAmount { get; init; }

    /// <summary>
    /// Delivery Agent.
    /// </summary>
    [DisplayName("Delivery Agent")]
    [IsoXmlTag("")]
    public SettlementParty1? DeliveryAgent { get; init; }

    /// <summary>
    /// Intermediary.
    /// </summary>
    [DisplayName("Intermediary")]
    [IsoXmlTag("")]
    public SettlementParty1? Intermediary { get; init; }

    /// <summary>
    /// Receiving Agent.
    /// </summary>
    [DisplayName("Receiving Agent")]
    [IsoXmlTag("")]
    public required SettlementParty1 ReceivingAgent { get; init; }

    /// <summary>
    /// Settlement Account.
    /// </summary>
    [DisplayName("Settlement Account")]
    [IsoXmlTag("")]
    public CashAccount43? SettlementAccount { get; init; }
}
