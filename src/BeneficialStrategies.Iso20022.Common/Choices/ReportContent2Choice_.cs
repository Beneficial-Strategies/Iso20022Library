// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Report Content2Choice.
    /// </summary>
    [KnownType(typeof(ReportContent2Choice.Binary))]
    [KnownType(typeof(ReportContent2Choice.ProtectedData))]
    [KnownType(typeof(ReportContent2Choice.Text))]
    [JsonDerivedType(typeof(ReportContent2Choice.Binary),nameof(ReportContent2Choice.Binary))]
    [JsonDerivedType(typeof(ReportContent2Choice.ProtectedData),nameof(ReportContent2Choice.ProtectedData))]
    [JsonDerivedType(typeof(ReportContent2Choice.Text),nameof(ReportContent2Choice.Text))]
    [IsoId("_ftafcY7fEe6S0_1AaJzQCA")]
    [DisplayName("Report Content2Choice")]
    public abstract partial record ReportContent2Choice_
    {
    }
}
