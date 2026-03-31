// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for global note.
    /// </summary>
    [KnownType(typeof(GlobalNote2Choice.Code))]
    [KnownType(typeof(GlobalNote2Choice.Proprietary))]
    [JsonDerivedType(typeof(GlobalNote2Choice.Code), nameof(GlobalNote2Choice.Code))]
    [JsonDerivedType(typeof(GlobalNote2Choice.Proprietary), nameof(GlobalNote2Choice.Proprietary))]
    [IsoId("_TiBdgeLaEeWFtOV72FbX9w")]
    [DisplayName("Global Note 2 Choice")]
    public abstract record GlobalNote2Choice_ { }
}
