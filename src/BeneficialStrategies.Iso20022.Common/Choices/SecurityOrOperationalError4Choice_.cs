// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the financial instruments details or the operational error details.
    /// </summary>
    [KnownType(typeof(SecurityOrOperationalError4Choice.SecurityReportOrBusinessError))]
    [KnownType(typeof(SecurityOrOperationalError4Choice.OperationalError))]
    [JsonDerivedType(
        typeof(SecurityOrOperationalError4Choice.SecurityReportOrBusinessError),
        nameof(SecurityOrOperationalError4Choice.SecurityReportOrBusinessError)
    )]
    [JsonDerivedType(
        typeof(SecurityOrOperationalError4Choice.OperationalError),
        nameof(SecurityOrOperationalError4Choice.OperationalError)
    )]
    [IsoId("_P3wGYZJKEeuAlLVx8pyt3w")]
    [DisplayName("Security Or Operational Error 4 Choice")]
    public abstract record SecurityOrOperationalError4Choice_ { }
}
