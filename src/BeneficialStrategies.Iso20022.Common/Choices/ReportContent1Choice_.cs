// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of the report content format.
    /// </summary>
    [KnownType(typeof(ReportContent1Choice.Text))]
    [KnownType(typeof(ReportContent1Choice.Binary))]
    [KnownType(typeof(ReportContent1Choice.ProtectedData))]
    [JsonDerivedType(typeof(ReportContent1Choice.Text),nameof(ReportContent1Choice.Text))]
    [JsonDerivedType(typeof(ReportContent1Choice.Binary),nameof(ReportContent1Choice.Binary))]
    [JsonDerivedType(typeof(ReportContent1Choice.ProtectedData),nameof(ReportContent1Choice.ProtectedData))]
    [IsoId("_HsTagMlWEeuJ35KoBRZFOg")]
    [DisplayName("Report Content 1 Choice")]
    public abstract partial record ReportContent1Choice_
    {
    }
}
