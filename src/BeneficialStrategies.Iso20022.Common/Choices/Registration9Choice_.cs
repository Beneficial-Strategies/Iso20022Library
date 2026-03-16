// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the registration information.
    /// </summary>
    [KnownType(typeof(Registration9Choice.Code))]
    [KnownType(typeof(Registration9Choice.Proprietary))]
    [JsonDerivedType(typeof(Registration9Choice.Code), nameof(Registration9Choice.Code))]
    [JsonDerivedType(
        typeof(Registration9Choice.Proprietary),
        nameof(Registration9Choice.Proprietary)
    )]
    [IsoId("_C_MhYTqGEeWVrPy0StzzSg")]
    [DisplayName("Registration 9 Choice")]
    public abstract record Registration9Choice_ { }
}
