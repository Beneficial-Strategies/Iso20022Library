// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_SU5Y2dp-Ed-ak6NoX_4Aeg_-437790811")]
[DisplayName("Pay In Schedule Items")]
[Obsolete]
public record PayInScheduleItems
{
    /// <summary>
    /// Currency and amount to be paid in.
    /// </summary>
    [IsoId("_SU5Y2tp-Ed-ak6NoX_4Aeg_958572324")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Time by which the amount must be paid in.
    /// </summary>
    [IsoId("_SVDJ0Np-Ed-ak6NoX_4Aeg_-1726696692")]
    [DisplayName("Deadline")]
    [IsoXmlTag("Ddln")]
    public required IsoISOTime Deadline { get; init; }
}
