// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the report item rejection reason in a coded or proprietary form.
    /// </summary>
    [KnownType(typeof(ReportItemRejectionReason1Choice.Code))]
    [KnownType(typeof(ReportItemRejectionReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ReportItemRejectionReason1Choice.Code),
        nameof(ReportItemRejectionReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ReportItemRejectionReason1Choice.Proprietary),
        nameof(ReportItemRejectionReason1Choice.Proprietary)
    )]
    [IsoId("_havMI73REeO2FLWuu_JIqg")]
    [DisplayName("Report Item Rejection Reason 1 Choice")]
    public abstract record ReportItemRejectionReason1Choice_ { }
}
