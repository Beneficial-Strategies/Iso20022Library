// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the choice between the listed and the proprietary error codes.
    /// </summary>
    [KnownType(typeof(ErrorHandling3Choice.Code))]
    [KnownType(typeof(ErrorHandling3Choice.Proprietary))]
    [JsonDerivedType(typeof(ErrorHandling3Choice.Code), nameof(ErrorHandling3Choice.Code))]
    [JsonDerivedType(
        typeof(ErrorHandling3Choice.Proprietary),
        nameof(ErrorHandling3Choice.Proprietary)
    )]
    [IsoId("_RA_79XhdEeidzqjNEfehPg")]
    [DisplayName("Error Handling 3 Choice")]
    public abstract record ErrorHandling3Choice_ { }
}
