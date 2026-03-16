// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Reversal Reason10Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionReversalReason10Choice.Code))]
    [KnownType(typeof(CorporateActionReversalReason10Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionReversalReason10Choice.Code),nameof(CorporateActionReversalReason10Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionReversalReason10Choice.Proprietary),nameof(CorporateActionReversalReason10Choice.Proprietary))]
    [IsoId("_eFp0cYCzEe-3UrLQHGsjgQ")]
    [DisplayName("Corporate Action Reversal Reason10Choice")]
    public abstract partial record CorporateActionReversalReason10Choice_
    {
    }
}
