// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason17Choice.Code))]
    [KnownType(typeof(CancellationReason17Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason17Choice.Code),nameof(CancellationReason17Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason17Choice.Proprietary),nameof(CancellationReason17Choice.Proprietary))]
    [IsoId("_THXyASzzEeOsiuMH68so7Q")]
    [DisplayName("Cancellation Reason 17 Choice")]
    public abstract partial record CancellationReason17Choice_
    {
    }
}
