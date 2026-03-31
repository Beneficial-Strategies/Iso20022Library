// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of governance process.
    /// </summary>
    [KnownType(typeof(GovernanceProcess1Choice.Code))]
    [KnownType(typeof(GovernanceProcess1Choice.Proprietary))]
    [JsonDerivedType(typeof(GovernanceProcess1Choice.Code), nameof(GovernanceProcess1Choice.Code))]
    [JsonDerivedType(
        typeof(GovernanceProcess1Choice.Proprietary),
        nameof(GovernanceProcess1Choice.Proprietary)
    )]
    [IsoId("_f3PLYID4Eeiw-daIkkmMqQ")]
    [DisplayName("Governance Process 1 Choice")]
    public abstract record GovernanceProcess1Choice_ { }
}
