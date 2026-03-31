// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason for the reversal.
    /// </summary>
    [KnownType(typeof(CorporateActionReversalReason6Choice.Code))]
    [KnownType(typeof(CorporateActionReversalReason6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionReversalReason6Choice.Code),
        nameof(CorporateActionReversalReason6Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionReversalReason6Choice.Proprietary),
        nameof(CorporateActionReversalReason6Choice.Proprietary)
    )]
    [IsoId("_TsubEl99Ee262vCSVgjImg")]
    [DisplayName("Corporate Action Reversal Reason 6 Choice")]
    public abstract record CorporateActionReversalReason6Choice_ { }
}
