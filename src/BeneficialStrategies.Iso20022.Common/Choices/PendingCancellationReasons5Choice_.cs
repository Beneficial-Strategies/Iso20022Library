// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending cancellation reason.
    /// </summary>
    [KnownType(typeof(PendingCancellationReasons5Choice.Code))]
    [KnownType(typeof(PendingCancellationReasons5Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingCancellationReasons5Choice.Code),nameof(PendingCancellationReasons5Choice.Code))]
    [JsonDerivedType(typeof(PendingCancellationReasons5Choice.Proprietary),nameof(PendingCancellationReasons5Choice.Proprietary))]
    [IsoId("_8Qc2K5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Cancellation Reasons 5 Choice")]
    public abstract partial record PendingCancellationReasons5Choice_
    {
    }
}
