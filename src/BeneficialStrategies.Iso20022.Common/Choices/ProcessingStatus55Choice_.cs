// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus55Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus55Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus55Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus55Choice.AcknowledgedAccepted),nameof(ProcessingStatus55Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus55Choice.Rejected),nameof(ProcessingStatus55Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus55Choice.Proprietary),nameof(ProcessingStatus55Choice.Proprietary))]
    [IsoId("_3-jxeTp4EeWVrPy0StzzSg")]
    [DisplayName("Processing Status 55 Choice")]
    public abstract partial record ProcessingStatus55Choice_
    {
    }
}
