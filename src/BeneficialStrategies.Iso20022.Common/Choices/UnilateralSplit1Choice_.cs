// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [KnownType(typeof(UnilateralSplit1Choice.Code))]
    [KnownType(typeof(UnilateralSplit1Choice.Proprietary))]
    [JsonDerivedType(typeof(UnilateralSplit1Choice.Code), nameof(UnilateralSplit1Choice.Code))]
    [JsonDerivedType(
        typeof(UnilateralSplit1Choice.Proprietary),
        nameof(UnilateralSplit1Choice.Proprietary)
    )]
    [IsoId("_QtogGdp-Ed-ak6NoX_4Aeg_510702003")]
    [DisplayName("Unilateral Split 1 Choice")]
    public abstract record UnilateralSplit1Choice_ { }
}
