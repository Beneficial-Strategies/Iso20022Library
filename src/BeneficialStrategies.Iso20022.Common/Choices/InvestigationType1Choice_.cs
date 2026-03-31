// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Investigation Type1Choice.
    /// </summary>
    [KnownType(typeof(InvestigationType1Choice.Code))]
    [KnownType(typeof(InvestigationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestigationType1Choice.Code), nameof(InvestigationType1Choice.Code))]
    [JsonDerivedType(
        typeof(InvestigationType1Choice.Proprietary),
        nameof(InvestigationType1Choice.Proprietary)
    )]
    [IsoId("_CXmCoFRtEe23M4WgERMsYw")]
    [DisplayName("Investigation Type1Choice")]
    public abstract record InvestigationType1Choice_ { }
}
