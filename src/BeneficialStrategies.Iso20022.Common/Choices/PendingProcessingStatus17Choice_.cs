// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus17Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus17Choice.Reason))]
    [JsonDerivedType(typeof(PendingProcessingStatus17Choice.NoSpecifiedReason),nameof(PendingProcessingStatus17Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingProcessingStatus17Choice.Reason),nameof(PendingProcessingStatus17Choice.Reason))]
    [IsoId("_fAcK8ekHEemm4qhb2yFPOw")]
    [DisplayName("Pending Processing Status 17 Choice")]
    public abstract partial record PendingProcessingStatus17Choice_
    {
    }
}
