// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus4Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus4Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessingStatus4Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus4Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus4Choice.Rejected),
        nameof(ProcessingStatus4Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus4Choice.Proprietary),
        nameof(ProcessingStatus4Choice.Proprietary)
    )]
    [IsoId("_UUTExtp-Ed-ak6NoX_4Aeg_-735060643")]
    [DisplayName("Processing Status 4 Choice")]
    public abstract record ProcessingStatus4Choice_ { }
}
