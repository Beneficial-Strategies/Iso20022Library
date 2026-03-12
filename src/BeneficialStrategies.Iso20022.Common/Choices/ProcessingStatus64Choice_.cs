// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus64Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus64Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus64Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus64Choice.AcknowledgedAccepted),nameof(ProcessingStatus64Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus64Choice.Rejected),nameof(ProcessingStatus64Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus64Choice.Proprietary),nameof(ProcessingStatus64Choice.Proprietary))]
    [IsoId("_8Rtax5NLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 64 Choice")]
    public abstract partial record ProcessingStatus64Choice_
    {
    }
}
