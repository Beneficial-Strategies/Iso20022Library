// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason1Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason1Choice.Code),nameof(RejectionAndRepairReason1Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason1Choice.Proprietary),nameof(RejectionAndRepairReason1Choice.Proprietary))]
    [IsoId("_UWrqZdp-Ed-ak6NoX_4Aeg_-254225608")]
    [DisplayName("Rejection And Repair Reason 1 Choice")]
    public abstract partial record RejectionAndRepairReason1Choice_
    {
    }
}
