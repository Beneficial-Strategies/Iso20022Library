// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Investigation Action Reason1Choice.
    /// </summary>
    [KnownType(typeof(InvestigationActionReason1Choice.Code))]
    [KnownType(typeof(InvestigationActionReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InvestigationActionReason1Choice.Code),
        nameof(InvestigationActionReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InvestigationActionReason1Choice.Proprietary),
        nameof(InvestigationActionReason1Choice.Proprietary)
    )]
    [IsoId("_ULtJUSVAEe6EvsLBQ6cYtA")]
    [DisplayName("Investigation Action Reason1Choice")]
    public abstract record InvestigationActionReason1Choice_ { }
}
