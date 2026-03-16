// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of element providing summary information on entries.
/// </summary>
[IsoId("_RUOmA9p-Ed-ak6NoX_4Aeg_896893198")]
[DisplayName("Total Transactions")]
public record TotalTransactions1
{
    /// <summary>
    /// Indicates the total number and sum of debit and credit entries.
    /// </summary>
    [IsoId("_RUOmBNp-Ed-ak6NoX_4Aeg_-1534408850")]
    [DisplayName("Total Entries")]
    [IsoXmlTag("TtlNtries")]
    public NumberAndSumOfTransactions2? TotalEntries { get; init; }

    /// <summary>
    /// Indicates the total number and sum of credit entries.
    /// </summary>
    [IsoId("_RUOmBdp-Ed-ak6NoX_4Aeg_-1217643484")]
    [DisplayName("Total Credit Entries")]
    [IsoXmlTag("TtlCdtNtries")]
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; init; }

    /// <summary>
    /// Indicates the total number and sum of debit entries.
    /// </summary>
    [IsoId("_RUOmBtp-Ed-ak6NoX_4Aeg_-1493776586")]
    [DisplayName("Total Debit Entries")]
    [IsoXmlTag("TtlDbtNtries")]
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; init; }

    /// <summary>
    /// Indicates the total number and sum of entries per bank transaction code.
    /// </summary>
    [IsoId("_RUOmB9p-Ed-ak6NoX_4Aeg_-1074496666")]
    [DisplayName("Total Entries Per Bank Transaction Code")]
    [IsoXmlTag("TtlNtriesPerBkTxCd")]
    public NumberAndSumOfTransactionsPerBankTransactionCode1? TotalEntriesPerBankTransactionCode { get; init; }
}
