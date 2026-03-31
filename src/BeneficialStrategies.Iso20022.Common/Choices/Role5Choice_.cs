// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a party role.
    /// </summary>
    [KnownType(typeof(Role5Choice.Code))]
    [KnownType(typeof(Role5Choice.Proprietary))]
    [JsonDerivedType(typeof(Role5Choice.Code), nameof(Role5Choice.Code))]
    [JsonDerivedType(typeof(Role5Choice.Proprietary), nameof(Role5Choice.Proprietary))]
    [IsoId("_VyKu4Z-zEeO1d8sv7xazyA")]
    [DisplayName("Role 5 Choice")]
    public abstract record Role5Choice_ { }
}
