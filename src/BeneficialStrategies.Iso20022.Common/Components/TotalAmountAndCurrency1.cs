// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing the total amount of all operations.
/// </summary>
[IsoId("_73bb46MgEeCJ6YNENx4h-w_2011477148")]
[DisplayName("Total Amount And Currency")]
public record TotalAmountAndCurrency1
{
    /// <summary>
    /// Total net amount for all operations taken into account in the report.
    /// </summary>
    [IsoId("_73bb5KMgEeCJ6YNENx4h-w_1808506706")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Indicates whether the total amount is a credit or a debit amount.
    /// </summary>
    [IsoId("_73bb5aMgEeCJ6YNENx4h-w_-2016384180")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Currency in which the total amount is expressed.
    /// </summary>
    [IsoId("_73bb5qMgEeCJ6YNENx4h-w_1541681800")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }
}
