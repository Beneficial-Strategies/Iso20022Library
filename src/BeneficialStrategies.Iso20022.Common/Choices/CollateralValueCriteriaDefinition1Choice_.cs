// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Definition of the collateral value query criteria.
    /// </summary>
    [KnownType(typeof(CollateralValueCriteriaDefinition1Choice.QueryName))]
    [KnownType(typeof(CollateralValueCriteriaDefinition1Choice.NewCriteria))]
    [JsonDerivedType(typeof(CollateralValueCriteriaDefinition1Choice.QueryName),nameof(CollateralValueCriteriaDefinition1Choice.QueryName))]
    [JsonDerivedType(typeof(CollateralValueCriteriaDefinition1Choice.NewCriteria),nameof(CollateralValueCriteriaDefinition1Choice.NewCriteria))]
    [IsoId("_jJgDo-5NEeCisYr99QEiWA_-333364953")]
    [DisplayName("Collateral Value Criteria Definition 1 Choice")]
    public abstract partial record CollateralValueCriteriaDefinition1Choice_
    {
    }
}
