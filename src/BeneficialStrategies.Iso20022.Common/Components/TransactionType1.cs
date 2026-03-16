// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the transactions to be reported.
/// </summary>
[IsoId("_P9p0otp-Ed-ak6NoX_4Aeg_943039965")]
[DisplayName("Transaction Type")]
public record TransactionType1
{
    /// <summary>
    /// Specifies the status on the books of the account servicer of the transactions to be reported.
    /// </summary>
    [IsoId("_P9p0o9p-Ed-ak6NoX_4Aeg_943040277")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required EntryStatus2Code Status { get; init; }

    /// <summary>
    /// Indicates whether the reporting request refers to credit or debit entries.
    /// </summary>
    [IsoId("_P9p0pNp-Ed-ak6NoX_4Aeg_943040000")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies the minimum value of entries to be reported in the requested message.
    /// </summary>
    [IsoId("_P9p0pdp-Ed-ak6NoX_4Aeg_-1506075611")]
    [DisplayName("Floor Limit")]
    [IsoXmlTag("FlrLmt")]
    public ValueList<Limit2> FloorLimit { get; init; } = [];
}
