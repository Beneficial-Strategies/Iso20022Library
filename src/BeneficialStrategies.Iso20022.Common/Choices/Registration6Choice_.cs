// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the registration information.
    /// </summary>
    [KnownType(typeof(Registration6Choice.Code))]
    [KnownType(typeof(Registration6Choice.Proprietary))]
    [JsonDerivedType(typeof(Registration6Choice.Code), nameof(Registration6Choice.Code))]
    [JsonDerivedType(
        typeof(Registration6Choice.Proprietary),
        nameof(Registration6Choice.Proprietary)
    )]
    [IsoId("_AZjk9NokEeC60axPepSq7g_13891142")]
    [DisplayName("Registration 6 Choice")]
    public abstract record Registration6Choice_ { }
}
