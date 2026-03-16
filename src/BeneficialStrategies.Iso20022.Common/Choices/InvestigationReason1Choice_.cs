// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Investigation Reason1Choice.
    /// </summary>
    [KnownType(typeof(InvestigationReason1Choice.Code))]
    [KnownType(typeof(InvestigationReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InvestigationReason1Choice.Code),
        nameof(InvestigationReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InvestigationReason1Choice.Proprietary),
        nameof(InvestigationReason1Choice.Proprietary)
    )]
    [IsoId("_CXmCg1RtEe23M4WgERMsYw")]
    [DisplayName("Investigation Reason1Choice")]
    public abstract record InvestigationReason1Choice_ { }
}
