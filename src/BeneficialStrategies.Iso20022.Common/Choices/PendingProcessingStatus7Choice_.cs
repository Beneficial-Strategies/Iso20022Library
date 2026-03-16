// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus7Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus7Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingProcessingStatus7Choice.NoSpecifiedReason),
        nameof(PendingProcessingStatus7Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingStatus7Choice.Reason),
        nameof(PendingProcessingStatus7Choice.Reason)
    )]
    [IsoId("_0i7nEAlIEeGATtfOBToyew_810652191")]
    [DisplayName("Pending Processing Status 7 Choice")]
    public abstract record PendingProcessingStatus7Choice_ { }
}
