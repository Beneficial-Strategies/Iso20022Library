// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Collateral Value Criteria Definition4Choice.
    /// </summary>
    [KnownType(typeof(CollateralValueCriteriaDefinition4Choice.NewCriteria))]
    [KnownType(typeof(CollateralValueCriteriaDefinition4Choice.QueryName))]
    [JsonDerivedType(
        typeof(CollateralValueCriteriaDefinition4Choice.NewCriteria),
        nameof(CollateralValueCriteriaDefinition4Choice.NewCriteria)
    )]
    [JsonDerivedType(
        typeof(CollateralValueCriteriaDefinition4Choice.QueryName),
        nameof(CollateralValueCriteriaDefinition4Choice.QueryName)
    )]
    [IsoId("_x0dSUTEyEe6g-ffJsqGiSA")]
    [DisplayName("Collateral Value Criteria Definition4Choice")]
    public abstract record CollateralValueCriteriaDefinition4Choice_ { }
}
