// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to provide the collateral balance for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralBalance1Choice.TotalCollateral))]
    [KnownType(typeof(CollateralBalance1Choice.CollateralDetails))]
    [KnownType(typeof(CollateralBalance1Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(
        typeof(CollateralBalance1Choice.TotalCollateral),
        nameof(CollateralBalance1Choice.TotalCollateral)
    )]
    [JsonDerivedType(
        typeof(CollateralBalance1Choice.CollateralDetails),
        nameof(CollateralBalance1Choice.CollateralDetails)
    )]
    [JsonDerivedType(
        typeof(CollateralBalance1Choice.SegregatedIndependentAmount),
        nameof(CollateralBalance1Choice.SegregatedIndependentAmount)
    )]
    [IsoId("_UnXxx9p-Ed-ak6NoX_4Aeg_-92530976")]
    [DisplayName("Collateral Balance 1 Choice")]
    public abstract record CollateralBalance1Choice_ { }
}
