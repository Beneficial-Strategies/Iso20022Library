// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the source used to generate the reporting.
    /// </summary>
    [KnownType(typeof(ReportingSource1Choice.Code))]
    [KnownType(typeof(ReportingSource1Choice.Proprietary))]
    [JsonDerivedType(typeof(ReportingSource1Choice.Code),nameof(ReportingSource1Choice.Code))]
    [JsonDerivedType(typeof(ReportingSource1Choice.Proprietary),nameof(ReportingSource1Choice.Proprietary))]
    [IsoId("_RqIkkdp-Ed-ak6NoX_4Aeg_-1706426921")]
    [DisplayName("Reporting Source 1 Choice")]
    public abstract partial record ReportingSource1Choice_
    {
    }
}
