// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus22Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus22Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus22Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus22Choice.AcknowledgedAccepted),nameof(ProcessingStatus22Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus22Choice.Rejected),nameof(ProcessingStatus22Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus22Choice.Proprietary),nameof(ProcessingStatus22Choice.Proprietary))]
    [IsoId("_2zEPMf7rEeCvPoRGOxRobQ")]
    [DisplayName("Processing Status 22 Choice")]
    public abstract partial record ProcessingStatus22Choice_
    {
    }
}
