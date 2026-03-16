// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus4Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingProcessingStatus4Choice.NoSpecifiedReason),
        nameof(PendingProcessingStatus4Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingStatus4Choice.Reason),
        nameof(PendingProcessingStatus4Choice.Reason)
    )]
    [IsoId("_Sn75wf7rEeCvPoRGOxRobQ")]
    [DisplayName("Pending Processing Status 4 Choice")]
    public abstract record PendingProcessingStatus4Choice_ { }
}
