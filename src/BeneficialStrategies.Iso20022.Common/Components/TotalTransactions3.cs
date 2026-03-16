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
[IsoId("_tshp1FkyEeGeoaLUQk__nA_-453924622")]
[DisplayName("Total Transactions")]
public record TotalTransactions3
{
    /// <summary>
    /// Specifies the total number and sum of debit and credit entries.
    /// </summary>
    [IsoId("_tshp1VkyEeGeoaLUQk__nA_802214388")]
    [DisplayName("Total Entries")]
    [IsoXmlTag("TtlNtries")]
    public NumberAndSumOfTransactions3? TotalEntries { get; init; }

    /// <summary>
    /// Specifies the total number and sum of credit entries.
    /// </summary>
    [IsoId("_tshp1lkyEeGeoaLUQk__nA_-1228730683")]
    [DisplayName("Total Credit Entries")]
    [IsoXmlTag("TtlCdtNtries")]
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; init; }

    /// <summary>
    /// Specifies the total number and sum of debit entries.
    /// </summary>
    [IsoId("_tsra0FkyEeGeoaLUQk__nA_-1310482759")]
    [DisplayName("Total Debit Entries")]
    [IsoXmlTag("TtlDbtNtries")]
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; init; }

    /// <summary>
    /// Specifies the total number and sum of entries per bank transaction code.
    /// </summary>
    [IsoId("_tsra0VkyEeGeoaLUQk__nA_107106544")]
    [DisplayName("Total Entries Per Bank Transaction Code")]
    [IsoXmlTag("TtlNtriesPerBkTxCd")]
    public TotalsPerBankTransactionCode2? TotalEntriesPerBankTransactionCode { get; init; }
}
