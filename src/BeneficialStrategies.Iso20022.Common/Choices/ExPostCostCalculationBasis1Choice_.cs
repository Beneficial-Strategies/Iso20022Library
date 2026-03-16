// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the ex-post cost calculation basis.
    /// </summary>
    [KnownType(typeof(ExPostCostCalculationBasis1Choice.Code))]
    [KnownType(typeof(ExPostCostCalculationBasis1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ExPostCostCalculationBasis1Choice.Code),
        nameof(ExPostCostCalculationBasis1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ExPostCostCalculationBasis1Choice.Proprietary),
        nameof(ExPostCostCalculationBasis1Choice.Proprietary)
    )]
    [IsoId("_Wb5bQJ9XEeqxTNfi5y7ywQ")]
    [DisplayName("Ex Post Cost Calculation Basis 1 Choice")]
    public abstract record ExPostCostCalculationBasis1Choice_ { }
}
