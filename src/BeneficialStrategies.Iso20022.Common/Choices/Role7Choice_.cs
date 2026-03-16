// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a party role.
    /// </summary>
    [KnownType(typeof(Role7Choice.Code))]
    [KnownType(typeof(Role7Choice.Proprietary))]
    [KnownType(typeof(Role7Choice.Text))]
    [JsonDerivedType(typeof(Role7Choice.Code), nameof(Role7Choice.Code))]
    [JsonDerivedType(typeof(Role7Choice.Proprietary), nameof(Role7Choice.Proprietary))]
    [JsonDerivedType(typeof(Role7Choice.Text), nameof(Role7Choice.Text))]
    [IsoId("_5WyhAZNLEeWGlc8L7oPDIg")]
    [DisplayName("Role 7 Choice")]
    public abstract record Role7Choice_ { }
}
