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
[IsoId("_zQlJ8U2UEe2bQ-Ksk8mwQg")]
[DisplayName("Detailed Report Statistics")]
public record DetailedReportStatistics6
{
    /// <summary>
    /// Total number of reports sent or received.
    /// </summary>
    [IsoId("_zRV-8U2UEe2bQ-Ksk8mwQg")]
    [DisplayName("Total Number Of Reports")]
    [IsoXmlTag("TtlNbOfRpts")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfReports { get; init; }

    /// <summary>
    /// Total number of reports accepted.
    /// </summary>
    [IsoId("_zRV-802UEe2bQ-Ksk8mwQg")]
    [DisplayName("Total Number Of Reports Accepted")]
    [IsoXmlTag("TtlNbOfRptsAccptd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfReportsAccepted { get; init; }

    /// <summary>
    /// Total number of reports rejected.
    /// </summary>
    [IsoId("_zRV-9U2UEe2bQ-Ksk8mwQg")]
    [DisplayName("Total Number Of Reports Rejected")]
    [IsoXmlTag("TtlNbOfRptsRjctd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfReportsRejected { get; init; }

    /// <summary>
    /// Number of reports rejected per error code.
    /// </summary>
    [IsoId("_zRV-902UEe2bQ-Ksk8mwQg")]
    [DisplayName("Number Of Reports Rejected Per Error")]
    [IsoXmlTag("NbOfRptsRjctdPerErr")]
    public NumberOfTransactionsPerValidationRule6? NumberOfReportsRejectedPerError { get; init; }
}
