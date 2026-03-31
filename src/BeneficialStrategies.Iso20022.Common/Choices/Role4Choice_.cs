// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a party role.
    /// </summary>
    [KnownType(typeof(Role4Choice.Code))]
    [KnownType(typeof(Role4Choice.Proprietary))]
    [JsonDerivedType(typeof(Role4Choice.Code), nameof(Role4Choice.Code))]
    [JsonDerivedType(typeof(Role4Choice.Proprietary), nameof(Role4Choice.Proprietary))]
    [IsoId("_VXT_QR6YEeOolf0-cMYhrw")]
    [DisplayName("Role 4 Choice")]
    public abstract record Role4Choice_ { }
}
