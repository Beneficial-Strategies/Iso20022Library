// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus66Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus66Choice.Repair))]
    [KnownType(typeof(ProcessingStatus66Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus66Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessingStatus66Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus66Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus66Choice.Repair),
        nameof(ProcessingStatus66Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus66Choice.Cancelled),
        nameof(ProcessingStatus66Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus66Choice.Proprietary),
        nameof(ProcessingStatus66Choice.Proprietary)
    )]
    [IsoId("_BmSl9eFUEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status 66 Choice")]
    public abstract record ProcessingStatus66Choice_ { }
}
