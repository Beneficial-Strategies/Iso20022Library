// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a conditionally accepted status.
    /// </summary>
    [KnownType(typeof(ConditionallyAcceptedStatusReason3Choice.Code))]
    [KnownType(typeof(ConditionallyAcceptedStatusReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(ConditionallyAcceptedStatusReason3Choice.Code),nameof(ConditionallyAcceptedStatusReason3Choice.Code))]
    [JsonDerivedType(typeof(ConditionallyAcceptedStatusReason3Choice.Proprietary),nameof(ConditionallyAcceptedStatusReason3Choice.Proprietary))]
    [IsoId("_D0QpIEHaEeamVPoS58KxXA")]
    [DisplayName("Conditionally Accepted Status Reason 3 Choice")]
    public abstract partial record ConditionallyAcceptedStatusReason3Choice_
    {
    }
}
