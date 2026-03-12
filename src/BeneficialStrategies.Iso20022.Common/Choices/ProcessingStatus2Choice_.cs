// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus2Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus2Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus2Choice.Repair))]
    [KnownType(typeof(ProcessingStatus2Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus2Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus2Choice.Denied))]
    [KnownType(typeof(ProcessingStatus2Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.PendingCancellation),nameof(ProcessingStatus2Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.Rejected),nameof(ProcessingStatus2Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.Repair),nameof(ProcessingStatus2Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.AcknowledgedAccepted),nameof(ProcessingStatus2Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.Proprietary),nameof(ProcessingStatus2Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.Denied),nameof(ProcessingStatus2Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus2Choice.Cancelled),nameof(ProcessingStatus2Choice.Cancelled))]
    [IsoId("_UUJ60dp-Ed-ak6NoX_4Aeg_1316468360")]
    [DisplayName("Processing Status 2 Choice")]
    public abstract partial record ProcessingStatus2Choice_
    {
    }
}
