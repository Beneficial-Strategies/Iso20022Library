// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an amount of money as a debit or credit amount.
/// </summary>
[IsoId("_jO3r0e5NEeCisYr99QEiWA_1570893165")]
[DisplayName("Credit Debit Amount")]
public record CreditDebitAmount1
{
    /// <summary>
    /// Amount of money expressed in an eligible currency.
    /// </summary>
    [IsoId("_jO3r0u5NEeCisYr99QEiWA_1555748542")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount2Choice_ Amount { get; init; }

    /// <summary>
    /// Specifies whether the amount of money is a debit or a credit.
    /// </summary>
    [IsoId("_jO3r0-5NEeCisYr99QEiWA_-1868915142")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }
}
