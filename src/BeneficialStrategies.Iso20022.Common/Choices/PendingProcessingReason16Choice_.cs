// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason16Choice.Code))]
    [KnownType(typeof(PendingProcessingReason16Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingProcessingReason16Choice.Code),nameof(PendingProcessingReason16Choice.Code))]
    [JsonDerivedType(typeof(PendingProcessingReason16Choice.Proprietary),nameof(PendingProcessingReason16Choice.Proprietary))]
    [IsoId("_gTcrAekHEemm4qhb2yFPOw")]
    [DisplayName("Pending Processing Reason 16 Choice")]
    public abstract partial record PendingProcessingReason16Choice_
    {
    }
}
