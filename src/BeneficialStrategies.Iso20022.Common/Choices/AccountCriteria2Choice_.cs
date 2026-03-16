// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(AccountCriteria2Choice.QueryName))]
    [KnownType(typeof(AccountCriteria2Choice.NewCriteria))]
    [JsonDerivedType(
        typeof(AccountCriteria2Choice.QueryName),
        nameof(AccountCriteria2Choice.QueryName)
    )]
    [JsonDerivedType(
        typeof(AccountCriteria2Choice.NewCriteria),
        nameof(AccountCriteria2Choice.NewCriteria)
    )]
    [IsoId("_39sKN5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Criteria 2 Choice")]
    public abstract record AccountCriteria2Choice_ { }
}
