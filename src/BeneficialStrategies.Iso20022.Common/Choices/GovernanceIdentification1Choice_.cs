// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the governance rules.
    /// </summary>
    [KnownType(typeof(GovernanceIdentification1Choice.Code))]
    [KnownType(typeof(GovernanceIdentification1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(GovernanceIdentification1Choice.Code),
        nameof(GovernanceIdentification1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(GovernanceIdentification1Choice.Proprietary),
        nameof(GovernanceIdentification1Choice.Proprietary)
    )]
    [IsoId("_929T0HltEeG7BsjMvd1mEw_-112960495")]
    [DisplayName("Governance Identification 1 Choice")]
    public abstract record GovernanceIdentification1Choice_ { }
}
