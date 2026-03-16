// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Criteria4Choice.
    /// </summary>
    [KnownType(typeof(AccountCriteria4Choice.NewCriteria))]
    [KnownType(typeof(AccountCriteria4Choice.QueryName))]
    [JsonDerivedType(typeof(AccountCriteria4Choice.NewCriteria),nameof(AccountCriteria4Choice.NewCriteria))]
    [JsonDerivedType(typeof(AccountCriteria4Choice.QueryName),nameof(AccountCriteria4Choice.QueryName))]
    [IsoId("_6My2QTEyEe6g-ffJsqGiSA")]
    [DisplayName("Account Criteria4Choice")]
    public abstract partial record AccountCriteria4Choice_
    {
    }
}
