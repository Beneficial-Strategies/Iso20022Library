// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason for the reversal.
    /// </summary>
    [KnownType(typeof(CorporateActionReversalReason3Choice.Code))]
    [KnownType(typeof(CorporateActionReversalReason3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionReversalReason3Choice.Code),
        nameof(CorporateActionReversalReason3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionReversalReason3Choice.Proprietary),
        nameof(CorporateActionReversalReason3Choice.Proprietary)
    )]
    [IsoId("_cCQvJ0GKEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Reversal Reason 3 Choice")]
    public abstract record CorporateActionReversalReason3Choice_ { }
}
