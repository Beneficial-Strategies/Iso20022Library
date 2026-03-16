// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide summary information on entries.
/// </summary>
[IsoId("_yGoqcYaGEee8r9VKRbnJSg")]
[DisplayName("Total Transactions")]
public record TotalTransactions6
{
    /// <summary>
    /// Specifies the total number and sum of debit and credit entries.
    /// </summary>
    [IsoId("_yVb7cYaGEee8r9VKRbnJSg")]
    [DisplayName("Total Entries")]
    [IsoXmlTag("TtlNtries")]
    public NumberAndSumOfTransactions4? TotalEntries { get; init; }

    /// <summary>
    /// Specifies the total number and sum of credit entries.
    /// </summary>
    [IsoId("_yVb7c4aGEee8r9VKRbnJSg")]
    [DisplayName("Total Credit Entries")]
    [IsoXmlTag("TtlCdtNtries")]
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; init; }

    /// <summary>
    /// Specifies the total number and sum of debit entries.
    /// </summary>
    [IsoId("_yVb7dYaGEee8r9VKRbnJSg")]
    [DisplayName("Total Debit Entries")]
    [IsoXmlTag("TtlDbtNtries")]
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; init; }

    /// <summary>
    /// Specifies the total number and sum of entries per bank transaction code.
    /// </summary>
    [IsoId("_yVb7d4aGEee8r9VKRbnJSg")]
    [DisplayName("Total Entries Per Bank Transaction Code")]
    [IsoXmlTag("TtlNtriesPerBkTxCd")]
    public TotalsPerBankTransactionCode5? TotalEntriesPerBankTransactionCode { get; init; }
}
