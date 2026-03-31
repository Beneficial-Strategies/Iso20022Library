// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus79Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus79Choice.Rejected))]
    [JsonDerivedType(
        typeof(ProcessingStatus79Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus79Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus79Choice.Rejected),
        nameof(ProcessingStatus79Choice.Rejected)
    )]
    [IsoId("_Hk0BYZwZEeqtp-LOti013g")]
    [DisplayName("Processing Status 79 Choice")]
    public abstract record ProcessingStatus79Choice_ { }
}
