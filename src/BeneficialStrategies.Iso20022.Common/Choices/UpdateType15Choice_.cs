// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the update information.
    /// </summary>
    [KnownType(typeof(UpdateType15Choice.Code))]
    [KnownType(typeof(UpdateType15Choice.Proprietary))]
    [JsonDerivedType(typeof(UpdateType15Choice.Code), nameof(UpdateType15Choice.Code))]
    [JsonDerivedType(
        typeof(UpdateType15Choice.Proprietary),
        nameof(UpdateType15Choice.Proprietary)
    )]
    [IsoId("_XMoFcTeQEeWm5uvLSn0jEw")]
    [DisplayName("Update Type 15 Choice")]
    public abstract record UpdateType15Choice_ { }
}
