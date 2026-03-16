// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Accepted Status13Choice.
    /// </summary>
    [KnownType(typeof(AcceptedStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcceptedStatus13Choice.Reason))]
    [JsonDerivedType(typeof(AcceptedStatus13Choice.NoSpecifiedReason),nameof(AcceptedStatus13Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcceptedStatus13Choice.Reason),nameof(AcceptedStatus13Choice.Reason))]
    [IsoId("_lHqNYZzoEe-DHYbvdRjdbA")]
    [DisplayName("Accepted Status13Choice")]
    public abstract partial record AcceptedStatus13Choice_
    {
    }
}
