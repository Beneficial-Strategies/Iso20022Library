// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus16Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus16Choice.Reason))]
    [JsonDerivedType(typeof(PendingProcessingStatus16Choice.NoSpecifiedReason),nameof(PendingProcessingStatus16Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingProcessingStatus16Choice.Reason),nameof(PendingProcessingStatus16Choice.Reason))]
    [IsoId("_6QCdn5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Processing Status 16 Choice")]
    public abstract partial record PendingProcessingStatus16Choice_
    {
    }
}
