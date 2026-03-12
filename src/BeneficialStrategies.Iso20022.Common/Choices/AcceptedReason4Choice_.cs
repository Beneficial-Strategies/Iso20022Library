// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason4Choice.Code))]
    [KnownType(typeof(AcceptedReason4Choice.Proprietary))]
    [JsonDerivedType(typeof(AcceptedReason4Choice.Code),nameof(AcceptedReason4Choice.Code))]
    [JsonDerivedType(typeof(AcceptedReason4Choice.Proprietary),nameof(AcceptedReason4Choice.Proprietary))]
    [IsoId("_JG3ZkSz3EeOsiuMH68so7Q")]
    [DisplayName("Accepted Reason 4 Choice")]
    public abstract partial record AcceptedReason4Choice_
    {
    }
}
