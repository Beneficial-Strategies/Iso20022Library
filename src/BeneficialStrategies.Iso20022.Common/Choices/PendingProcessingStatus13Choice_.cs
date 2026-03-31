// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus13Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingProcessingStatus13Choice.NoSpecifiedReason),
        nameof(PendingProcessingStatus13Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingStatus13Choice.Reason),
        nameof(PendingProcessingStatus13Choice.Reason)
    )]
    [IsoId("_rlGNoTq1EeWyoP0PbocV1Q")]
    [DisplayName("Pending Processing Status 13 Choice")]
    public abstract record PendingProcessingStatus13Choice_ { }
}
