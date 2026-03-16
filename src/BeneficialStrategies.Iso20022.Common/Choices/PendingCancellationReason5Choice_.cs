// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [KnownType(typeof(PendingCancellationReason5Choice.Code))]
    [KnownType(typeof(PendingCancellationReason5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PendingCancellationReason5Choice.Code),
        nameof(PendingCancellationReason5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PendingCancellationReason5Choice.Proprietary),
        nameof(PendingCancellationReason5Choice.Proprietary)
    )]
    [IsoId("_2WOZ5YluEeavwKddCbm3hg")]
    [DisplayName("Pending Cancellation Reason 5 Choice")]
    public abstract record PendingCancellationReason5Choice_ { }
}
