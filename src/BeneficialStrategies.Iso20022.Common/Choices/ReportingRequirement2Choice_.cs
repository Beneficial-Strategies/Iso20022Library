// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicator whether there is a reporting requirement for both counterparties.
    /// </summary>
    [KnownType(typeof(ReportingRequirement2Choice.ReportingRequirement))]
    [KnownType(typeof(ReportingRequirement2Choice.NoReportingRequirement))]
    [JsonDerivedType(
        typeof(ReportingRequirement2Choice.ReportingRequirement),
        nameof(ReportingRequirement2Choice.ReportingRequirement)
    )]
    [JsonDerivedType(
        typeof(ReportingRequirement2Choice.NoReportingRequirement),
        nameof(ReportingRequirement2Choice.NoReportingRequirement)
    )]
    [IsoId("_IUKZoV55Ee2a_-MvhEjKmA")]
    [DisplayName("Reporting Requirement 2 Choice")]
    public abstract record ReportingRequirement2Choice_ { }
}
