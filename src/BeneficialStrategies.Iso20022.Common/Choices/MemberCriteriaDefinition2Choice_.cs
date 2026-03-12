// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(MemberCriteriaDefinition2Choice.QueryName))]
    [KnownType(typeof(MemberCriteriaDefinition2Choice.NewCriteria))]
    [JsonDerivedType(typeof(MemberCriteriaDefinition2Choice.QueryName),nameof(MemberCriteriaDefinition2Choice.QueryName))]
    [JsonDerivedType(typeof(MemberCriteriaDefinition2Choice.NewCriteria),nameof(MemberCriteriaDefinition2Choice.NewCriteria))]
    [IsoId("_igVbx3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Criteria Definition 2 Choice")]
    public abstract partial record MemberCriteriaDefinition2Choice_
    {
    }
}
