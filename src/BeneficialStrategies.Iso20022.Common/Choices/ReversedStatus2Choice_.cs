// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the reversed status.
    /// </summary>
    [KnownType(typeof(ReversedStatus2Choice.Reason))]
    [KnownType(typeof(ReversedStatus2Choice.DataSourceScheme))]
    [KnownType(typeof(ReversedStatus2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(ReversedStatus2Choice.Reason), nameof(ReversedStatus2Choice.Reason))]
    [JsonDerivedType(
        typeof(ReversedStatus2Choice.DataSourceScheme),
        nameof(ReversedStatus2Choice.DataSourceScheme)
    )]
    [JsonDerivedType(
        typeof(ReversedStatus2Choice.NoSpecifiedReason),
        nameof(ReversedStatus2Choice.NoSpecifiedReason)
    )]
    [IsoId("_a4QdwSY5EeW_ZNn8gbfY7Q")]
    [DisplayName("Reversed Status 2 Choice")]
    public abstract record ReversedStatus2Choice_ { }
}
