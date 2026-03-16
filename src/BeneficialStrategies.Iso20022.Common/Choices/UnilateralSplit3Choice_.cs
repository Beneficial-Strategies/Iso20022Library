// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [KnownType(typeof(UnilateralSplit3Choice.Code))]
    [KnownType(typeof(UnilateralSplit3Choice.Proprietary))]
    [JsonDerivedType(typeof(UnilateralSplit3Choice.Code), nameof(UnilateralSplit3Choice.Code))]
    [JsonDerivedType(
        typeof(UnilateralSplit3Choice.Proprietary),
        nameof(UnilateralSplit3Choice.Proprietary)
    )]
    [IsoId("_eVzXMTt4EeW638lNyHKv7A")]
    [DisplayName("Unilateral Split 3 Choice")]
    public abstract record UnilateralSplit3Choice_ { }
}
