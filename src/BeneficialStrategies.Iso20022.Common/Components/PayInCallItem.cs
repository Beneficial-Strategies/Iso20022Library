// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numerical representation of the net increases and decreases in an account at a specific point in time. A cash balance is calculated from a sum of cash credits minus a sum of cash debits.
/// </summary>
[IsoId("_SXbvdNp-Ed-ak6NoX_4Aeg_1496666102")]
[DisplayName("Pay In Call Item")]
public record PayInCallItem
{
    /// <summary>
    /// Specifies the currency and amount of the called item.
    /// </summary>
    [IsoId("_SXbvddp-Ed-ak6NoX_4Aeg_1674784774")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }
}
