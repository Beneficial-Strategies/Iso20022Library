// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason for the reversal.
    /// </summary>
    [KnownType(typeof(CorporateActionReversalReason4Choice.Code))]
    [KnownType(typeof(CorporateActionReversalReason4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionReversalReason4Choice.Code),
        nameof(CorporateActionReversalReason4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionReversalReason4Choice.Proprietary),
        nameof(CorporateActionReversalReason4Choice.Proprietary)
    )]
    [IsoId("_ctOKM5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Reversal Reason 4 Choice")]
    public abstract record CorporateActionReversalReason4Choice_ { }
}
