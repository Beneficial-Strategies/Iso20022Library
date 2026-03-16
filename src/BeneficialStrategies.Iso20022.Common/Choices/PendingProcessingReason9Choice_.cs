// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the reason of a pending status.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason9Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingReason9Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingProcessingReason9Choice.NoSpecifiedReason),
        nameof(PendingProcessingReason9Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingReason9Choice.Reason),
        nameof(PendingProcessingReason9Choice.Reason)
    )]
    [IsoId("_6LbpKVj1EeOnqqBHs8Gasw")]
    [DisplayName("Pending Processing Reason 9 Choice")]
    public abstract record PendingProcessingReason9Choice_ { }
}
