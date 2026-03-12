// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the risk level.
    /// </summary>
    [KnownType(typeof(RiskLevel2Choice.Code))]
    [KnownType(typeof(RiskLevel2Choice.Proprietary))]
    [JsonDerivedType(typeof(RiskLevel2Choice.Code),nameof(RiskLevel2Choice.Code))]
    [JsonDerivedType(typeof(RiskLevel2Choice.Proprietary),nameof(RiskLevel2Choice.Proprietary))]
    [IsoId("_BQa7kSGREeWO8_xZKx-MFg")]
    [DisplayName("Risk Level 2 Choice")]
    public abstract partial record RiskLevel2Choice_
    {
    }
}
