// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason for the reversal.
    /// </summary>
    [KnownType(typeof(CorporateActionReversalReason5Choice.Code))]
    [KnownType(typeof(CorporateActionReversalReason5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionReversalReason5Choice.Code),
        nameof(CorporateActionReversalReason5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionReversalReason5Choice.Proprietary),
        nameof(CorporateActionReversalReason5Choice.Proprietary)
    )]
    [IsoId("_ryV6pzQVEe2o-K1dwNg8Gg")]
    [DisplayName("Corporate Action Reversal Reason 5 Choice")]
    public abstract record CorporateActionReversalReason5Choice_ { }
}
