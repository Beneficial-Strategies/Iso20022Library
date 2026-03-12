// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason23Choice.Code))]
    [KnownType(typeof(CancellationReason23Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason23Choice.Code),nameof(CancellationReason23Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason23Choice.Proprietary),nameof(CancellationReason23Choice.Proprietary))]
    [IsoId("_ELEakTw6EeW3QqUkIQtIUA")]
    [DisplayName("Cancellation Reason 23 Choice")]
    public abstract partial record CancellationReason23Choice_
    {
    }
}
