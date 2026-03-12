// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected status reason.
    /// </summary>
    [KnownType(typeof(RejectedStatusReason1Choice.Reason))]
    [KnownType(typeof(RejectedStatusReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedStatusReason1Choice.Reason),nameof(RejectedStatusReason1Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatusReason1Choice.Proprietary),nameof(RejectedStatusReason1Choice.Proprietary))]
    [IsoId("_Rhov5tp-Ed-ak6NoX_4Aeg_-75492796")]
    [DisplayName("Rejected Status Reason 1 Choice")]
    public abstract partial record RejectedStatusReason1Choice_
    {
    }
}
