// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the cancelled status.
    /// </summary>
    [KnownType(typeof(CancelledStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus13Choice.Reason))]
    [KnownType(typeof(CancelledStatus13Choice.ExtendedReason))]
    [KnownType(typeof(CancelledStatus13Choice.DataSourceScheme))]
    [JsonDerivedType(typeof(CancelledStatus13Choice.NoSpecifiedReason),nameof(CancelledStatus13Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancelledStatus13Choice.Reason),nameof(CancelledStatus13Choice.Reason))]
    [JsonDerivedType(typeof(CancelledStatus13Choice.ExtendedReason),nameof(CancelledStatus13Choice.ExtendedReason))]
    [JsonDerivedType(typeof(CancelledStatus13Choice.DataSourceScheme),nameof(CancelledStatus13Choice.DataSourceScheme))]
    [IsoId("_Pa7e0SY5EeW_ZNn8gbfY7Q")]
    [DisplayName("Cancelled Status 13 Choice")]
    public abstract partial record CancelledStatus13Choice_
    {
    }
}
