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
[IsoId("_RpY9sNp-Ed-ak6NoX_4Aeg_-365325273")]
[DisplayName("Total Transactions")]
public record TotalTransactions2
{
    /// <summary>
    /// Specifies the total number and sum of debit and credit entries.
    /// </summary>
    [IsoId("_RpY9sdp-Ed-ak6NoX_4Aeg_-365324871")]
    [DisplayName("Total Entries")]
    [IsoXmlTag("TtlNtries")]
    public NumberAndSumOfTransactions2? TotalEntries { get; init; }

    /// <summary>
    /// Specifies the total number and sum of credit entries.
    /// </summary>
    [IsoId("_RpY9stp-Ed-ak6NoX_4Aeg_-365325210")]
    [DisplayName("Total Credit Entries")]
    [IsoXmlTag("TtlCdtNtries")]
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; init; }

    /// <summary>
    /// Specifies the total number and sum of debit entries.
    /// </summary>
    [IsoId("_RpY9s9p-Ed-ak6NoX_4Aeg_-365324932")]
    [DisplayName("Total Debit Entries")]
    [IsoXmlTag("TtlDbtNtries")]
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; init; }

    /// <summary>
    /// Specifies the total number and sum of entries per bank transaction code.
    /// </summary>
    [IsoId("_RpY9tNp-Ed-ak6NoX_4Aeg_-365324817")]
    [DisplayName("Total Entries Per Bank Transaction Code")]
    [IsoXmlTag("TtlNtriesPerBkTxCd")]
    public TotalsPerBankTransactionCode2? TotalEntriesPerBankTransactionCode { get; init; }
}
