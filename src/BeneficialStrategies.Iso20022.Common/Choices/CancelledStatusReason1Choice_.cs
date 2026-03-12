// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cancelled status reason.
    /// </summary>
    [KnownType(typeof(CancelledStatusReason1Choice.Reason))]
    [KnownType(typeof(CancelledStatusReason1Choice.Proprietary))]
    [KnownType(typeof(CancelledStatusReason1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancelledStatusReason1Choice.Reason),nameof(CancelledStatusReason1Choice.Reason))]
    [JsonDerivedType(typeof(CancelledStatusReason1Choice.Proprietary),nameof(CancelledStatusReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(CancelledStatusReason1Choice.NoSpecifiedReason),nameof(CancelledStatusReason1Choice.NoSpecifiedReason))]
    [IsoId("_RiFb09p-Ed-ak6NoX_4Aeg_-275254352")]
    [DisplayName("Cancelled Status Reason 1 Choice")]
    public abstract partial record CancelledStatusReason1Choice_
    {
    }
}
