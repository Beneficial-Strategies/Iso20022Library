// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money debited or credited on the books of an account servicer.
/// </summary>
[IsoId("_STHQKNp-Ed-ak6NoX_4Aeg_1039656981")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection21
{
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_STHQKdp-Ed-ak6NoX_4Aeg_925817915")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [IsoId("_STHQKtp-Ed-ak6NoX_4Aeg_-71254438")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }
}
