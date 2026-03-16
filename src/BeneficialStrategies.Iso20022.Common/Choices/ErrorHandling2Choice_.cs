// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the choice between the listed and the proprietary error codes.
    /// </summary>
    [KnownType(typeof(ErrorHandling2Choice.Code))]
    [KnownType(typeof(ErrorHandling2Choice.Proprietary))]
    [JsonDerivedType(typeof(ErrorHandling2Choice.Code), nameof(ErrorHandling2Choice.Code))]
    [JsonDerivedType(
        typeof(ErrorHandling2Choice.Proprietary),
        nameof(ErrorHandling2Choice.Proprietary)
    )]
    [IsoId("_jXcINxbvEeOy-PlRuFSUzQ")]
    [DisplayName("Error Handling 2 Choice")]
    public abstract record ErrorHandling2Choice_ { }
}
