// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Investigation Reason Sub Type1Choice.
    /// </summary>
    [KnownType(typeof(InvestigationReasonSubType1Choice.Code))]
    [KnownType(typeof(InvestigationReasonSubType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InvestigationReasonSubType1Choice.Code),
        nameof(InvestigationReasonSubType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InvestigationReasonSubType1Choice.Proprietary),
        nameof(InvestigationReasonSubType1Choice.Proprietary)
    )]
    [IsoId("_CXmCj1RtEe23M4WgERMsYw")]
    [DisplayName("Investigation Reason Sub Type1Choice")]
    public abstract record InvestigationReasonSubType1Choice_ { }
}
