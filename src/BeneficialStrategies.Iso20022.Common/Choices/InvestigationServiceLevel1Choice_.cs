// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Investigation Service Level1Choice.
    /// </summary>
    [KnownType(typeof(InvestigationServiceLevel1Choice.Code))]
    [KnownType(typeof(InvestigationServiceLevel1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InvestigationServiceLevel1Choice.Code),
        nameof(InvestigationServiceLevel1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InvestigationServiceLevel1Choice.Proprietary),
        nameof(InvestigationServiceLevel1Choice.Proprietary)
    )]
    [IsoId("_CXmpWFRtEe23M4WgERMsYw")]
    [DisplayName("Investigation Service Level1Choice")]
    public abstract record InvestigationServiceLevel1Choice_ { }
}
