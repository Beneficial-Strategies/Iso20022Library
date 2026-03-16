// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an order waiver reason.
    /// </summary>
    [KnownType(typeof(OrderWaiverReason3Choice.Code))]
    [KnownType(typeof(OrderWaiverReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(OrderWaiverReason3Choice.Code), nameof(OrderWaiverReason3Choice.Code))]
    [JsonDerivedType(
        typeof(OrderWaiverReason3Choice.Proprietary),
        nameof(OrderWaiverReason3Choice.Proprietary)
    )]
    [IsoId("_PJanIToREeabspMEjqY5TQ")]
    [DisplayName("Order Waiver Reason 3 Choice")]
    public abstract record OrderWaiverReason3Choice_ { }
}
