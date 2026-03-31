// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the central counterparty intended clearing time.
    /// </summary>
    [KnownType(typeof(ClearingPartyAndTime22Choice.Reason))]
    [KnownType(typeof(ClearingPartyAndTime22Choice.Details))]
    [JsonDerivedType(
        typeof(ClearingPartyAndTime22Choice.Reason),
        nameof(ClearingPartyAndTime22Choice.Reason)
    )]
    [JsonDerivedType(
        typeof(ClearingPartyAndTime22Choice.Details),
        nameof(ClearingPartyAndTime22Choice.Details)
    )]
    [IsoId("_mkgZsRZOEe2QNcZTDeoKnQ")]
    [DisplayName("Clearing Party And Time 22 Choice")]
    public abstract record ClearingPartyAndTime22Choice_ { }
}
