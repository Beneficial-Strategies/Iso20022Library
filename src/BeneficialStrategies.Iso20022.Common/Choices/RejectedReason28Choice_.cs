// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason28Choice.Code))]
    [KnownType(typeof(RejectedReason28Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason28Choice.Code),nameof(RejectedReason28Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason28Choice.Proprietary),nameof(RejectedReason28Choice.Proprietary))]
    [IsoId("_jCSj-bKaEemux5trsZcCpw")]
    [DisplayName("Rejected Reason 28 Choice")]
    public abstract partial record RejectedReason28Choice_
    {
    }
}
