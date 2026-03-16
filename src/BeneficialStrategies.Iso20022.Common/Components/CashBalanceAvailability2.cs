// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates when the amount of money will become available, ie can be accessed and start generating interest.
/// </summary>
[IsoId("_TU-Vw9p-Ed-ak6NoX_4Aeg_-168274260")]
[DisplayName("Cash Balance Availability")]
public record CashBalanceAvailability2
{
    /// <summary>
    /// Indicates when the amount of money will become available.
    /// </summary>
    [IsoId("_TU-VxNp-Ed-ak6NoX_4Aeg_-168274014")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required CashBalanceAvailabilityDate1 Date { get; init; }

    /// <summary>
    /// Identifies the available amount.
    /// </summary>
    [IsoId("_TU-Vxdp-Ed-ak6NoX_4Aeg_-168274229")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether the availability balance is a credit or a debit balance. |Usage: A zero balance is considered to be a credit balance.
    /// </summary>
    [IsoId("_TU-Vxtp-Ed-ak6NoX_4Aeg_-168274199")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }
}
