// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus5Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus5Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus5Choice.Completed))]
    [KnownType(typeof(ProcessingStatus5Choice.Denied))]
    [KnownType(typeof(ProcessingStatus5Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus5Choice.Pending))]
    [JsonDerivedType(typeof(ProcessingStatus5Choice.AcknowledgedAccepted),nameof(ProcessingStatus5Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus5Choice.Rejected),nameof(ProcessingStatus5Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus5Choice.Completed),nameof(ProcessingStatus5Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus5Choice.Denied),nameof(ProcessingStatus5Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus5Choice.Proprietary),nameof(ProcessingStatus5Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus5Choice.Pending),nameof(ProcessingStatus5Choice.Pending))]
    [IsoId("_UUmmxdp-Ed-ak6NoX_4Aeg_861825222")]
    [DisplayName("Processing Status 5 Choice")]
    public abstract partial record ProcessingStatus5Choice_
    {
    }
}
