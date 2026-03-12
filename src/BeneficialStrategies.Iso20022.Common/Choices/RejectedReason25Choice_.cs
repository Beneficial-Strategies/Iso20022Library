// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason25Choice.Code))]
    [KnownType(typeof(RejectedReason25Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason25Choice.Code),nameof(RejectedReason25Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason25Choice.Proprietary),nameof(RejectedReason25Choice.Proprietary))]
    [IsoId("_ViI-Kby0EeilsanBGAzy4A")]
    [DisplayName("Rejected Reason 25 Choice")]
    public abstract partial record RejectedReason25Choice_
    {
    }
}
