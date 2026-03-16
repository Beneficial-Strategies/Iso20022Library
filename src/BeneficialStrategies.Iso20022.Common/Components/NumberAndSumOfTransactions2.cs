// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing the total sum of entries.
/// </summary>
[IsoId("_Q7fV4dp-Ed-ak6NoX_4Aeg_321425004")]
[DisplayName("Number And Sum Of Transactions")]
public record NumberAndSumOfTransactions2
{
    /// <summary>
    /// Number of individual entries included in the report.
    /// </summary>
    [IsoId("_Q7fV4tp-Ed-ak6NoX_4Aeg_321425036")]
    [DisplayName("Number Of Entries")]
    [IsoXmlTag("NbOfNtries")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfEntries { get; init; }

    /// <summary>
    /// Total of all individual entries included in the report.
    /// </summary>
    [IsoId("_Q7fV49p-Ed-ak6NoX_4Aeg_322345029")]
    [DisplayName("Sum")]
    [IsoXmlTag("Sum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Sum { get; init; }

    /// <summary>
    /// Resulting amount of the netted amounts for all debit and credit entries.
    /// </summary>
    [IsoId("_Q7fV5Np-Ed-ak6NoX_4Aeg_191865338")]
    [DisplayName("Total Net Entry Amount")]
    [IsoXmlTag("TtlNetNtryAmt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalNetEntryAmount { get; init; }

    /// <summary>
    /// Indicates whether the total net entry amount is a credit or a debit amount.
    /// </summary>
    [IsoId("_Q7fV5dp-Ed-ak6NoX_4Aeg_191865339")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }
}
