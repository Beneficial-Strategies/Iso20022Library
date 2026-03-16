// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a party role.
    /// </summary>
    [KnownType(typeof(Role2Choice.Code))]
    [KnownType(typeof(Role2Choice.Proprietary))]
    [KnownType(typeof(Role2Choice.Text))]
    [JsonDerivedType(typeof(Role2Choice.Code), nameof(Role2Choice.Code))]
    [JsonDerivedType(typeof(Role2Choice.Proprietary), nameof(Role2Choice.Proprietary))]
    [JsonDerivedType(typeof(Role2Choice.Text), nameof(Role2Choice.Text))]
    [IsoId("_Qwm7k9p-Ed-ak6NoX_4Aeg_-1001393826")]
    [DisplayName("Role 2 Choice")]
    public abstract record Role2Choice_ { }
}
