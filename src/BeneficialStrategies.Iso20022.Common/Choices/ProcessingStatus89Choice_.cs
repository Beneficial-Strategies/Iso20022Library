// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus89Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus89Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus89Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus89Choice.AcknowledgedAccepted),nameof(ProcessingStatus89Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus89Choice.Rejected),nameof(ProcessingStatus89Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus89Choice.Proprietary),nameof(ProcessingStatus89Choice.Proprietary))]
    [IsoId("_SF8U8StYEeyhipY4f42fZQ")]
    [DisplayName("Processing Status 89 Choice")]
    public abstract partial record ProcessingStatus89Choice_
    {
    }
}
