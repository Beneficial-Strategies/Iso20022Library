// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason24Choice.Code))]
    [KnownType(typeof(RejectedReason24Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason24Choice.Code),nameof(RejectedReason24Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason24Choice.Proprietary),nameof(RejectedReason24Choice.Proprietary))]
    [IsoId("_p7t_kbXTEeiTob_PrFFUxA")]
    [DisplayName("Rejected Reason 24 Choice")]
    public abstract partial record RejectedReason24Choice_
    {
    }
}
