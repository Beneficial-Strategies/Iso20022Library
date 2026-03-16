// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus11Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus11Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingProcessingStatus11Choice.NoSpecifiedReason),
        nameof(PendingProcessingStatus11Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingStatus11Choice.Reason),
        nameof(PendingProcessingStatus11Choice.Reason)
    )]
    [IsoId("_LqPHcTqdEeWyoP0PbocV1Q")]
    [DisplayName("Pending Processing Status 11 Choice")]
    public abstract record PendingProcessingStatus11Choice_ { }
}
