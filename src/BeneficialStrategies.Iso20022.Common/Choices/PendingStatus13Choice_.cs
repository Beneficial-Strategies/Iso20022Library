// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus13Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus13Choice.NoSpecifiedReason),nameof(PendingStatus13Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus13Choice.Reason),nameof(PendingStatus13Choice.Reason))]
    [IsoId("_5y9kQf7qEeCvPoRGOxRobQ")]
    [DisplayName("Pending Status 13 Choice")]
    public abstract partial record PendingStatus13Choice_
    {
    }
}
