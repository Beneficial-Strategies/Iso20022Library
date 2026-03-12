// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the central counterparty clearing time.
    /// </summary>
    [KnownType(typeof(ClearingPartyAndTime21Choice.Reason))]
    [KnownType(typeof(ClearingPartyAndTime21Choice.Details))]
    [JsonDerivedType(typeof(ClearingPartyAndTime21Choice.Reason),nameof(ClearingPartyAndTime21Choice.Reason))]
    [JsonDerivedType(typeof(ClearingPartyAndTime21Choice.Details),nameof(ClearingPartyAndTime21Choice.Details))]
    [IsoId("_9znFoQtuEe2eQ-C-GTDpFA")]
    [DisplayName("Clearing Party And Time 21 Choice")]
    public abstract partial record ClearingPartyAndTime21Choice_
    {
    }
}
