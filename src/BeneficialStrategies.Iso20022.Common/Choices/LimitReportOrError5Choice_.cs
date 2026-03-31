// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Limit Report Or Error5Choice.
    /// </summary>
    [KnownType(typeof(LimitReportOrError5Choice.BusinessReport))]
    [KnownType(typeof(LimitReportOrError5Choice.OperationalError))]
    [JsonDerivedType(
        typeof(LimitReportOrError5Choice.BusinessReport),
        nameof(LimitReportOrError5Choice.BusinessReport)
    )]
    [JsonDerivedType(
        typeof(LimitReportOrError5Choice.OperationalError),
        nameof(LimitReportOrError5Choice.OperationalError)
    )]
    [IsoId("_5SQgoTEyEe6g-ffJsqGiSA")]
    [DisplayName("Limit Report Or Error5Choice")]
    public abstract record LimitReportOrError5Choice_ { }
}
