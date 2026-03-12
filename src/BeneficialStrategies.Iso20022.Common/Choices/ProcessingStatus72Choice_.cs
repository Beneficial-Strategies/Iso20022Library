// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status and the reason of the operation.
    /// </summary>
    [KnownType(typeof(ProcessingStatus72Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus72Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus72Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus72Choice.Completed))]
    [KnownType(typeof(ProcessingStatus72Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus72Choice.AcknowledgedAccepted),nameof(ProcessingStatus72Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus72Choice.PendingProcessing),nameof(ProcessingStatus72Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus72Choice.Rejected),nameof(ProcessingStatus72Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus72Choice.Completed),nameof(ProcessingStatus72Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus72Choice.Proprietary),nameof(ProcessingStatus72Choice.Proprietary))]
    [IsoId("_atiHUeLtEeWOD7aAy2fAcA")]
    [DisplayName("Processing Status 72 Choice")]
    public abstract partial record ProcessingStatus72Choice_
    {
    }
}
