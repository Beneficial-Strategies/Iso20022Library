// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the risk level.
    /// </summary>
    [KnownType(typeof(RiskLevel1Choice.Code))]
    [KnownType(typeof(RiskLevel1Choice.Proprietary))]
    [JsonDerivedType(typeof(RiskLevel1Choice.Code),nameof(RiskLevel1Choice.Code))]
    [JsonDerivedType(typeof(RiskLevel1Choice.Proprietary),nameof(RiskLevel1Choice.Proprietary))]
    [IsoId("_aZdpExdxEeKYM7Bc71nDlA")]
    [DisplayName("Risk Level 1 Choice")]
    public abstract partial record RiskLevel1Choice_
    {
    }
}
