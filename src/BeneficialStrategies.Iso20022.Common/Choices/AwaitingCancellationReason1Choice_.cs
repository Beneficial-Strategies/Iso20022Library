// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the allegment reason.
    /// </summary>
    [KnownType(typeof(AwaitingCancellationReason1Choice.Code))]
    [KnownType(typeof(AwaitingCancellationReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AwaitingCancellationReason1Choice.Code),
        nameof(AwaitingCancellationReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AwaitingCancellationReason1Choice.Proprietary),
        nameof(AwaitingCancellationReason1Choice.Proprietary)
    )]
    [IsoId("_A4HJN9okEeC60axPepSq7g_471897824")]
    [DisplayName("Awaiting Cancellation Reason 1 Choice")]
    public abstract record AwaitingCancellationReason1Choice_ { }
}
