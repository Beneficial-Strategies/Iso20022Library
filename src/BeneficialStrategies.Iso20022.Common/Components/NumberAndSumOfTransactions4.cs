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
[IsoId("_lH52cyGxEeKjd4jizyIDGA")]
[DisplayName("Number And Sum Of Transactions")]
public record NumberAndSumOfTransactions4
{
    /// <summary>
    /// Number of individual entries included in the report.
    /// </summary>
    [IsoId("_lc6dGSGxEeKjd4jizyIDGA")]
    [DisplayName("Number Of Entries")]
    [IsoXmlTag("NbOfNtries")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfEntries { get; init; }

    /// <summary>
    /// Total of all individual entries included in the report.
    /// </summary>
    [IsoId("_lc6dHSGxEeKjd4jizyIDGA")]
    [DisplayName("Sum")]
    [IsoXmlTag("Sum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Sum { get; init; }

    /// <summary>
    /// Resulting debit or credit amount of the netted amounts for all debit and credit entries.
    /// </summary>
    [IsoId("_TjTFBimlEeKdFJmzhTDOvQ")]
    [DisplayName("Total Net Entry")]
    [IsoXmlTag("TtlNetNtry")]
    public AmountAndDirection35? TotalNetEntry { get; init; }
}
