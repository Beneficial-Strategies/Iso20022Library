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
[IsoId("_xnQKcT3XEe2uHKhHp3bXyA")]
[DisplayName("Notional Amount")]
public record NotionalAmount5
{
    /// <summary>
    /// Reference amount from which contractual payments are determined.
    /// Usage: In case of partial terminations, and amortisations and in case of contracts where the notional, due to the characteristics of the contract, varies over time, it shall reflect the remaining notional after the change took place.
    /// </summary>
    [IsoId("_xoHtIT3XEe2uHKhHp3bXyA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountAndDirection106? Amount { get; init; }

    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions negotiated in monetary amounts varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_xoHtIz3XEe2uHKhHp3bXyA")]
    [DisplayName("Schedule Period")]
    [IsoXmlTag("SchdlPrd")]
    public Schedule11? SchedulePeriod { get; init; }
}
