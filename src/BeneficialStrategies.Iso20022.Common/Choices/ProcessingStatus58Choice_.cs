// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus58Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus58Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus58Choice.Completed))]
    [KnownType(typeof(ProcessingStatus58Choice.Denied))]
    [KnownType(typeof(ProcessingStatus58Choice.Pending))]
    [KnownType(typeof(ProcessingStatus58Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus58Choice.AcknowledgedAccepted),nameof(ProcessingStatus58Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus58Choice.Rejected),nameof(ProcessingStatus58Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus58Choice.Completed),nameof(ProcessingStatus58Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus58Choice.Denied),nameof(ProcessingStatus58Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus58Choice.Pending),nameof(ProcessingStatus58Choice.Pending))]
    [JsonDerivedType(typeof(ProcessingStatus58Choice.Proprietary),nameof(ProcessingStatus58Choice.Proprietary))]
    [IsoId("_6GW9O5NLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 58 Choice")]
    public abstract partial record ProcessingStatus58Choice_
    {
    }
}
