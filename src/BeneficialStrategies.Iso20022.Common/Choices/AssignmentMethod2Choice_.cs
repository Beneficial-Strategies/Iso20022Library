// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for assignment method.
    /// </summary>
    [KnownType(typeof(AssignmentMethod2Choice.Code))]
    [KnownType(typeof(AssignmentMethod2Choice.Proprietary))]
    [JsonDerivedType(typeof(AssignmentMethod2Choice.Code), nameof(AssignmentMethod2Choice.Code))]
    [JsonDerivedType(
        typeof(AssignmentMethod2Choice.Proprietary),
        nameof(AssignmentMethod2Choice.Proprietary)
    )]
    [IsoId("_hJG-heLaEeWFtOV72FbX9w")]
    [DisplayName("Assignment Method 2 Choice")]
    public abstract record AssignmentMethod2Choice_ { }
}
