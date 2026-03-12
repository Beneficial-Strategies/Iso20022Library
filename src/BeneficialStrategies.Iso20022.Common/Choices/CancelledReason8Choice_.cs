// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request is cancelled.
    /// </summary>
    [KnownType(typeof(CancelledReason8Choice.Code))]
    [KnownType(typeof(CancelledReason8Choice.Proprietary))]
    [JsonDerivedType(typeof(CancelledReason8Choice.Code),nameof(CancelledReason8Choice.Code))]
    [JsonDerivedType(typeof(CancelledReason8Choice.Proprietary),nameof(CancelledReason8Choice.Proprietary))]
    [IsoId("_xMRqU0GUEeWqy4niLuXETA")]
    [DisplayName("Cancelled Reason 8 Choice")]
    public abstract partial record CancelledReason8Choice_
    {
    }
}
