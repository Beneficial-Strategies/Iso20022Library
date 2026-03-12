// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the expected collateral type and direction for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(ExpectedCollateral1Choice.ExpectedCollateralDetails))]
    [KnownType(typeof(ExpectedCollateral1Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(typeof(ExpectedCollateral1Choice.ExpectedCollateralDetails),nameof(ExpectedCollateral1Choice.ExpectedCollateralDetails))]
    [JsonDerivedType(typeof(ExpectedCollateral1Choice.SegregatedIndependentAmount),nameof(ExpectedCollateral1Choice.SegregatedIndependentAmount))]
    [IsoId("_QmevMtp-Ed-ak6NoX_4Aeg_-1576167501")]
    [DisplayName("Expected Collateral 1 Choice")]
    public abstract partial record ExpectedCollateral1Choice_
    {
    }
}
