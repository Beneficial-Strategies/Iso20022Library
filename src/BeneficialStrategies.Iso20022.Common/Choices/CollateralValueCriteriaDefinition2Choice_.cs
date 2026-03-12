// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Definition of the collateral value query criteria.
    /// </summary>
    [KnownType(typeof(CollateralValueCriteriaDefinition2Choice.QueryName))]
    [KnownType(typeof(CollateralValueCriteriaDefinition2Choice.NewCriteria))]
    [JsonDerivedType(typeof(CollateralValueCriteriaDefinition2Choice.QueryName),nameof(CollateralValueCriteriaDefinition2Choice.QueryName))]
    [JsonDerivedType(typeof(CollateralValueCriteriaDefinition2Choice.NewCriteria),nameof(CollateralValueCriteriaDefinition2Choice.NewCriteria))]
    [IsoId("_zV1FIeFgEeWIA4E9cYSxxQ")]
    [DisplayName("Collateral Value Criteria Definition 2 Choice")]
    public abstract partial record CollateralValueCriteriaDefinition2Choice_
    {
    }
}
