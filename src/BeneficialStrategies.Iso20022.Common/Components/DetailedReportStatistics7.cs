// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed Report Statistics7.
/// </summary>
[IsoId("_CNlAofrfEe2mU4Wi2q3MzQ")]
[DisplayName("Detailed Report Statistics7")]
public partial record DetailedReportStatistics7
{
    #nullable enable

    /// <summary>
    /// Number Of Reports Rejected Per Error.
    /// </summary>
    [DisplayName("Number Of Reports Rejected Per Error")]
    [IsoXmlTag("NbOfRptsRjctdPerErr")]
    public ValueList<NumberOfTransactionsPerValidationRule6> NumberOfReportsRejectedPerError { get; init; } = [];

    /// <summary>
    /// Total Number Of Reports.
    /// </summary>
    [DisplayName("Total Number Of Reports")]
    [IsoXmlTag("TtlNbOfRpts")]
    public required IsoMax20PositiveNumber TotalNumberOfReports { get; init; } 

    /// <summary>
    /// Total Number Of Reports Accepted.
    /// </summary>
    [DisplayName("Total Number Of Reports Accepted")]
    [IsoXmlTag("TtlNbOfRptsAccptd")]
    public required IsoMax20PositiveNumber TotalNumberOfReportsAccepted { get; init; } 

    /// <summary>
    /// Total Number Of Reports Rejected.
    /// </summary>
    [DisplayName("Total Number Of Reports Rejected")]
    [IsoXmlTag("TtlNbOfRptsRjctd")]
    public required IsoMax20PositiveNumber TotalNumberOfReportsRejected { get; init; } 

    
    #nullable disable
    
}
