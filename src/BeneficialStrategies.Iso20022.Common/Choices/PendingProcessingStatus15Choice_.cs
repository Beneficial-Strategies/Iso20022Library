// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus15Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus15Choice.Reason))]
    [JsonDerivedType(typeof(PendingProcessingStatus15Choice.NoSpecifiedReason),nameof(PendingProcessingStatus15Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingProcessingStatus15Choice.Reason),nameof(PendingProcessingStatus15Choice.Reason))]
    [IsoId("_6P-zDZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Processing Status 15 Choice")]
    public abstract partial record PendingProcessingStatus15Choice_
    {
    }
}
