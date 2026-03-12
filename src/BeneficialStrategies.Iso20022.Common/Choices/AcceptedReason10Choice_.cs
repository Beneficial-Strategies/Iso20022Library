// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason10Choice.Code))]
    [KnownType(typeof(AcceptedReason10Choice.Proprietary))]
    [JsonDerivedType(typeof(AcceptedReason10Choice.Code),nameof(AcceptedReason10Choice.Code))]
    [JsonDerivedType(typeof(AcceptedReason10Choice.Proprietary),nameof(AcceptedReason10Choice.Proprietary))]
    [IsoId("_41TRM0GUEeWqy4niLuXETA")]
    [DisplayName("Accepted Reason 10 Choice")]
    public abstract partial record AcceptedReason10Choice_
    {
    }
}
