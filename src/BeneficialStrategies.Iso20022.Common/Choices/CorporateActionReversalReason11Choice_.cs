// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Reversal Reason11Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionReversalReason11Choice.Code))]
    [KnownType(typeof(CorporateActionReversalReason11Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionReversalReason11Choice.Code),nameof(CorporateActionReversalReason11Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionReversalReason11Choice.Proprietary),nameof(CorporateActionReversalReason11Choice.Proprietary))]
    [IsoId("_l6NNk5t3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Reversal Reason11Choice")]
    public abstract partial record CorporateActionReversalReason11Choice_
    {
    }
}
