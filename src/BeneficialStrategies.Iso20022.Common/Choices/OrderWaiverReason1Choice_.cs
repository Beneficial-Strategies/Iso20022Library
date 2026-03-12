// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of order waiver reason.
    /// </summary>
    [KnownType(typeof(OrderWaiverReason1Choice.Reason))]
    [KnownType(typeof(OrderWaiverReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(OrderWaiverReason1Choice.Reason),nameof(OrderWaiverReason1Choice.Reason))]
    [JsonDerivedType(typeof(OrderWaiverReason1Choice.Proprietary),nameof(OrderWaiverReason1Choice.Proprietary))]
    [IsoId("_SdiXddp-Ed-ak6NoX_4Aeg_-117604914")]
    [DisplayName("Order Waiver Reason 1 Choice")]
    public abstract partial record OrderWaiverReason1Choice_
    {
    }
}
