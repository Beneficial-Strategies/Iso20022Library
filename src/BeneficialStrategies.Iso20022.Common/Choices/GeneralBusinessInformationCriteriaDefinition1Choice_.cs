// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(GeneralBusinessInformationCriteriaDefinition1Choice.QueryName))]
    [KnownType(typeof(GeneralBusinessInformationCriteriaDefinition1Choice.NewCriteria))]
    [JsonDerivedType(
        typeof(GeneralBusinessInformationCriteriaDefinition1Choice.QueryName),
        nameof(GeneralBusinessInformationCriteriaDefinition1Choice.QueryName)
    )]
    [JsonDerivedType(
        typeof(GeneralBusinessInformationCriteriaDefinition1Choice.NewCriteria),
        nameof(GeneralBusinessInformationCriteriaDefinition1Choice.NewCriteria)
    )]
    [IsoId("_1VwUF5lZEeeE1Ya-LgRsuQ")]
    [DisplayName("General Business Information Criteria Definition 1 Choice")]
    public abstract record GeneralBusinessInformationCriteriaDefinition1Choice_ { }
}
