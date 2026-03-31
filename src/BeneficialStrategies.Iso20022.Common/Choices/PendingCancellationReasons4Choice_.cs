// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending cancellation reason.
    /// </summary>
    [KnownType(typeof(PendingCancellationReasons4Choice.Code))]
    [KnownType(typeof(PendingCancellationReasons4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PendingCancellationReasons4Choice.Code),
        nameof(PendingCancellationReasons4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PendingCancellationReasons4Choice.Proprietary),
        nameof(PendingCancellationReasons4Choice.Proprietary)
    )]
    [IsoId("_cLaSYTqrEeWyoP0PbocV1Q")]
    [DisplayName("Pending Cancellation Reasons 4 Choice")]
    public abstract record PendingCancellationReasons4Choice_ { }
}
