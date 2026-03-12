// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(MemberCriteriaDefinition1Choice.QueryName))]
    [KnownType(typeof(MemberCriteriaDefinition1Choice.NewCriteria))]
    [JsonDerivedType(typeof(MemberCriteriaDefinition1Choice.QueryName),nameof(MemberCriteriaDefinition1Choice.QueryName))]
    [JsonDerivedType(typeof(MemberCriteriaDefinition1Choice.NewCriteria),nameof(MemberCriteriaDefinition1Choice.NewCriteria))]
    [IsoId("_tLC5R5lVEeeE1Ya-LgRsuQ")]
    [DisplayName("Member Criteria Definition 1 Choice")]
    public abstract partial record MemberCriteriaDefinition1Choice_
    {
    }
}
