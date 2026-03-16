// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the reference amount from which contractual payments are determined and the schedule applicable to the payments.
/// </summary>
[IsoId("_0PFHoWEeEe2P-L9DBerEgA")]
[DisplayName("Notional Amount")]
public record NotionalAmount6
{
    /// <summary>
    /// Reference amount from which contractual payments are determined.
    /// Usage: In case of partial terminations, and amortisations and in case of contracts where the notional, due to the characteristics of the contract, varies over time, it shall reflect the remaining notional after the change took place.
    /// </summary>
    [IsoId("_0P8qUWEeEe2P-L9DBerEgA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountAndDirection106? Amount { get; init; }

    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions negotiated in monetary amounts varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_0P8qU2EeEe2P-L9DBerEgA")]
    [DisplayName("Schedule Period")]
    [IsoXmlTag("SchdlPrd")]
    public Schedule11? SchedulePeriod { get; init; }

    /// <summary>
    /// Specifies the currency of the notional amount.
    /// </summary>
    [IsoId("_oPQ70GTxEe2Qhbz5WMMCCA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }
}
