// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus3Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingProcessingStatus3Choice.NoSpecifiedReason),
        nameof(PendingProcessingStatus3Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingStatus3Choice.Reason),
        nameof(PendingProcessingStatus3Choice.Reason)
    )]
    [IsoId("_0_sCgf7qEeCvPoRGOxRobQ")]
    [DisplayName("Pending Processing Status 3 Choice")]
    public abstract record PendingProcessingStatus3Choice_ { }
}
