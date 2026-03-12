// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the transaction cancellation status.
    /// </summary>
    [KnownType(typeof(CancellationStatusReason3Choice.Code))]
    [KnownType(typeof(CancellationStatusReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationStatusReason3Choice.Code),nameof(CancellationStatusReason3Choice.Code))]
    [JsonDerivedType(typeof(CancellationStatusReason3Choice.Proprietary),nameof(CancellationStatusReason3Choice.Proprietary))]
    [IsoId("_skGdSYlrEeePr-EGJjGYzQ")]
    [DisplayName("Cancellation Status Reason 3 Choice")]
    public abstract partial record CancellationStatusReason3Choice_
    {
    }
}
