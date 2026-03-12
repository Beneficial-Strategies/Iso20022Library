// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason23Choice.Code))]
    [KnownType(typeof(RejectedReason23Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason23Choice.Code),nameof(RejectedReason23Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason23Choice.Proprietary),nameof(RejectedReason23Choice.Proprietary))]
    [IsoId("_kov6b5wsEeazcsnODTksnQ")]
    [DisplayName("Rejected Reason 23 Choice")]
    public abstract partial record RejectedReason23Choice_
    {
    }
}
