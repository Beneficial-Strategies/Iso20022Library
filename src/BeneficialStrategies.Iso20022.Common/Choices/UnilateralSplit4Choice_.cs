// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [KnownType(typeof(UnilateralSplit4Choice.Code))]
    [KnownType(typeof(UnilateralSplit4Choice.Proprietary))]
    [JsonDerivedType(typeof(UnilateralSplit4Choice.Code), nameof(UnilateralSplit4Choice.Code))]
    [JsonDerivedType(
        typeof(UnilateralSplit4Choice.Proprietary),
        nameof(UnilateralSplit4Choice.Proprietary)
    )]
    [IsoId("_6GWWMZNLEeWGlc8L7oPDIg")]
    [DisplayName("Unilateral Split 4 Choice")]
    public abstract record UnilateralSplit4Choice_ { }
}
