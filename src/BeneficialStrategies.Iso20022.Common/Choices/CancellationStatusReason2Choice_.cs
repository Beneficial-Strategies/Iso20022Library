// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the transaction cancellation status.
    /// </summary>
    [KnownType(typeof(CancellationStatusReason2Choice.Code))]
    [KnownType(typeof(CancellationStatusReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationStatusReason2Choice.Code),nameof(CancellationStatusReason2Choice.Code))]
    [JsonDerivedType(typeof(CancellationStatusReason2Choice.Proprietary),nameof(CancellationStatusReason2Choice.Proprietary))]
    [IsoId("_t4TcA1kyEeGeoaLUQk__nA_-1286440985")]
    [DisplayName("Cancellation Status Reason 2 Choice")]
    public abstract partial record CancellationStatusReason2Choice_
    {
    }
}
