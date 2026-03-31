// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of amount values.
/// </summary>
[IsoId("_PVQ-9Np-Ed-ak6NoX_4Aeg_-844951100")]
[DisplayName("Currency And Amount Range")]
public record CurrencyAndAmountRange2
{
    /// <summary>
    /// Specified amount or amount range.
    /// </summary>
    [IsoId("_PVQ-9dp-Ed-ak6NoX_4Aeg_-844951098")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAmountRangeChoice_ Amount { get; init; }

    /// <summary>
    /// Indicates whether the amount is a credited or debited amount.
    /// </summary>
    [IsoId("_PVQ-9tp-Ed-ak6NoX_4Aeg_-844951039")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Medium of exchange of value, used to qualify an amount.
    /// </summary>
    [IsoId("_PVQ-99p-Ed-ak6NoX_4Aeg_-844951070")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; }
}
