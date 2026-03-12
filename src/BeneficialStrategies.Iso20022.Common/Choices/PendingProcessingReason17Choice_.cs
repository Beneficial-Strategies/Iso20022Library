// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason17Choice.Code))]
    [KnownType(typeof(PendingProcessingReason17Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingProcessingReason17Choice.Code),nameof(PendingProcessingReason17Choice.Code))]
    [JsonDerivedType(typeof(PendingProcessingReason17Choice.Proprietary),nameof(PendingProcessingReason17Choice.Proprietary))]
    [IsoId("_68Bw0QpJEeup4r-PFG2T5Q")]
    [DisplayName("Pending Processing Reason 17 Choice")]
    public abstract partial record PendingProcessingReason17Choice_
    {
    }
}
