// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus91Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus91Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus91Choice.Completed))]
    [KnownType(typeof(ProcessingStatus91Choice.Denied))]
    [KnownType(typeof(ProcessingStatus91Choice.Pending))]
    [KnownType(typeof(ProcessingStatus91Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus91Choice.AcknowledgedAccepted),nameof(ProcessingStatus91Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus91Choice.Rejected),nameof(ProcessingStatus91Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus91Choice.Completed),nameof(ProcessingStatus91Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus91Choice.Denied),nameof(ProcessingStatus91Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus91Choice.Pending),nameof(ProcessingStatus91Choice.Pending))]
    [JsonDerivedType(typeof(ProcessingStatus91Choice.Proprietary),nameof(ProcessingStatus91Choice.Proprietary))]
    [IsoId("_diXTAzi8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status 91 Choice")]
    public abstract partial record ProcessingStatus91Choice_
    {
    }
}
