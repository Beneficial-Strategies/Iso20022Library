// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus18Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus18Choice.Reason))]
    [JsonDerivedType(typeof(PendingProcessingStatus18Choice.NoSpecifiedReason),nameof(PendingProcessingStatus18Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingProcessingStatus18Choice.Reason),nameof(PendingProcessingStatus18Choice.Reason))]
    [IsoId("_6icMMwpJEeup4r-PFG2T5Q")]
    [DisplayName("Pending Processing Status 18 Choice")]
    public abstract partial record PendingProcessingStatus18Choice_
    {
    }
}
