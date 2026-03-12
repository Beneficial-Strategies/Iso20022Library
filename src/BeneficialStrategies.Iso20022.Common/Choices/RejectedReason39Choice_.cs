// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason39Choice.Code))]
    [KnownType(typeof(RejectedReason39Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason39Choice.Code),nameof(RejectedReason39Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason39Choice.Proprietary),nameof(RejectedReason39Choice.Proprietary))]
    [IsoId("_pUIcRR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Rejected Reason 39 Choice")]
    public abstract partial record RejectedReason39Choice_
    {
    }
}
