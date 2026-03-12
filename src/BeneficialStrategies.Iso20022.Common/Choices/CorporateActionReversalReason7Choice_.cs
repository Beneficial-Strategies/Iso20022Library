// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason for the reversal.
    /// </summary>
    [KnownType(typeof(CorporateActionReversalReason7Choice.Code))]
    [KnownType(typeof(CorporateActionReversalReason7Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionReversalReason7Choice.Code),nameof(CorporateActionReversalReason7Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionReversalReason7Choice.Proprietary),nameof(CorporateActionReversalReason7Choice.Proprietary))]
    [IsoId("_WfigTl99Ee262vCSVgjImg")]
    [DisplayName("Corporate Action Reversal Reason 7 Choice")]
    public abstract partial record CorporateActionReversalReason7Choice_
    {
    }
}
