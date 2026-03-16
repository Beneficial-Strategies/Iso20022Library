// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status26Choice.CancellationStatusReport))]
    [KnownType(typeof(Status26Choice.IndividualCancellationStatusReport))]
    [JsonDerivedType(
        typeof(Status26Choice.CancellationStatusReport),
        nameof(Status26Choice.CancellationStatusReport)
    )]
    [JsonDerivedType(
        typeof(Status26Choice.IndividualCancellationStatusReport),
        nameof(Status26Choice.IndividualCancellationStatusReport)
    )]
    [IsoId("_ZdGjEEgrEeaD2L_hzZaE0w")]
    [DisplayName("Status 26 Choice")]
    public abstract record Status26Choice_ { }
}
