// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the registration information.
    /// </summary>
    [KnownType(typeof(Registration11Choice.Code))]
    [KnownType(typeof(Registration11Choice.Proprietary))]
    [JsonDerivedType(typeof(Registration11Choice.Code), nameof(Registration11Choice.Code))]
    [JsonDerivedType(
        typeof(Registration11Choice.Proprietary),
        nameof(Registration11Choice.Proprietary)
    )]
    [IsoId("_5TJ-uZNLEeWGlc8L7oPDIg")]
    [DisplayName("Registration 11 Choice")]
    public abstract record Registration11Choice_ { }
}
