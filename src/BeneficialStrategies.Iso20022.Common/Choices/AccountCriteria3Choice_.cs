// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(AccountCriteria3Choice.QueryName))]
    [KnownType(typeof(AccountCriteria3Choice.NewCriteria))]
    [JsonDerivedType(typeof(AccountCriteria3Choice.QueryName),nameof(AccountCriteria3Choice.QueryName))]
    [JsonDerivedType(typeof(AccountCriteria3Choice.NewCriteria),nameof(AccountCriteria3Choice.NewCriteria))]
    [IsoId("_PhEfF249EeiU9cctagi5ow")]
    [DisplayName("Account Criteria 3 Choice")]
    public abstract partial record AccountCriteria3Choice_
    {
    }
}
