// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Definition of the collateral value query criteria.
    /// </summary>
    [KnownType(typeof(CollateralValueCriteriaDefinition3Choice.QueryName))]
    [KnownType(typeof(CollateralValueCriteriaDefinition3Choice.NewCriteria))]
    [JsonDerivedType(typeof(CollateralValueCriteriaDefinition3Choice.QueryName),nameof(CollateralValueCriteriaDefinition3Choice.QueryName))]
    [JsonDerivedType(typeof(CollateralValueCriteriaDefinition3Choice.NewCriteria),nameof(CollateralValueCriteriaDefinition3Choice.NewCriteria))]
    [IsoId("__ksIgTpsEemk2e6qGBk8IQ")]
    [DisplayName("Collateral Value Criteria Definition 3 Choice")]
    public abstract partial record CollateralValueCriteriaDefinition3Choice_
    {
    }
}
