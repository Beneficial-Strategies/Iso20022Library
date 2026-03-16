// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the expected collateral type and direction for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(ExpectedCollateral2Choice.ExpectedCollateralDetails))]
    [KnownType(typeof(ExpectedCollateral2Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(
        typeof(ExpectedCollateral2Choice.ExpectedCollateralDetails),
        nameof(ExpectedCollateral2Choice.ExpectedCollateralDetails)
    )]
    [JsonDerivedType(
        typeof(ExpectedCollateral2Choice.SegregatedIndependentAmount),
        nameof(ExpectedCollateral2Choice.SegregatedIndependentAmount)
    )]
    [IsoId("_-UW_QYLZEeWrrO9HojbPQA")]
    [DisplayName("Expected Collateral 2 Choice")]
    public abstract record ExpectedCollateral2Choice_ { }
}
