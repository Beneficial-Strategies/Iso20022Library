// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reporting Requirement3Choice.
    /// </summary>
    [KnownType(typeof(ReportingRequirement3Choice.NoReportingRequirement))]
    [KnownType(typeof(ReportingRequirement3Choice.ReportingRequirement))]
    [JsonDerivedType(typeof(ReportingRequirement3Choice.NoReportingRequirement),nameof(ReportingRequirement3Choice.NoReportingRequirement))]
    [JsonDerivedType(typeof(ReportingRequirement3Choice.ReportingRequirement),nameof(ReportingRequirement3Choice.ReportingRequirement))]
    [IsoId("_x7R5Ma-8Ee69JssYImngCA")]
    [DisplayName("Reporting Requirement3Choice")]
    public abstract partial record ReportingRequirement3Choice_
    {
    }
}
