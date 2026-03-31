// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus19Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus19Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingProcessingStatus19Choice.NoSpecifiedReason),
        nameof(PendingProcessingStatus19Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingStatus19Choice.Reason),
        nameof(PendingProcessingStatus19Choice.Reason)
    )]
    [IsoId("_qTGQXyAdEeuyDZ-ukt4YRg")]
    [DisplayName("Pending Processing Status 19 Choice")]
    public abstract record PendingProcessingStatus19Choice_ { }
}
