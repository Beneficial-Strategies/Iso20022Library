// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Reversal Reason12Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionReversalReason12Choice.Code))]
    [KnownType(typeof(CorporateActionReversalReason12Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionReversalReason12Choice.Code),
        nameof(CorporateActionReversalReason12Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionReversalReason12Choice.Proprietary),
        nameof(CorporateActionReversalReason12Choice.Proprietary)
    )]
    [IsoId("_m45EE5t3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Reversal Reason12Choice")]
    public abstract record CorporateActionReversalReason12Choice_ { }
}
