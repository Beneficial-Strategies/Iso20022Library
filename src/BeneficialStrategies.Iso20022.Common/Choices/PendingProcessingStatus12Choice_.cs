// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus12Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus12Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingProcessingStatus12Choice.NoSpecifiedReason),
        nameof(PendingProcessingStatus12Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingStatus12Choice.Reason),
        nameof(PendingProcessingStatus12Choice.Reason)
    )]
    [IsoId("_D0nCgTqyEeWyoP0PbocV1Q")]
    [DisplayName("Pending Processing Status 12 Choice")]
    public abstract record PendingProcessingStatus12Choice_ { }
}
