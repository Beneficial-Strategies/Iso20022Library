// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed statistics on reports.
/// </summary>
[IsoId("_2KfKwcrVEeii_5g6VX90qQ")]
[DisplayName("Detailed Report Statistics")]
public record DetailedReportStatistics5
{
    /// <summary>
    /// Total number of reports sent or received.
    /// </summary>
    [IsoId("_2UBhQcrVEeii_5g6VX90qQ")]
    [DisplayName("Total Number Of Reports")]
    [IsoXmlTag("TtlNbOfRpts")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfReports { get; init; }

    /// <summary>
    /// Total number of reports accepted.
    /// </summary>
    [IsoId("_Ak4tEMrWEeii_5g6VX90qQ")]
    [DisplayName("Total Number Of Reports Accepted")]
    [IsoXmlTag("TtlNbOfRptsAccptd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfReportsAccepted { get; init; }

    /// <summary>
    /// Total number of reports rejected.
    /// </summary>
    [IsoId("_HPzW0MrfEeii_5g6VX90qQ")]
    [DisplayName("Total Number Of Reports Rejected")]
    [IsoXmlTag("TtlNbOfRptsRjctd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfReportsRejected { get; init; }

    /// <summary>
    /// Number of reports rejected per error code.
    /// </summary>
    [IsoId("_2UBhRcrVEeii_5g6VX90qQ")]
    [DisplayName("Number Of Reports Rejected Per Error")]
    [IsoXmlTag("NbOfRptsRjctdPerErr")]
    public ValueList<NumberOfTransactionsPerValidationRule5> NumberOfReportsRejectedPerError { get; init; } =
        [];
}
