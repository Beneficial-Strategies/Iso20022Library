// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason44Choice.Code))]
    [KnownType(typeof(RejectedReason44Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason44Choice.Code),nameof(RejectedReason44Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason44Choice.Proprietary),nameof(RejectedReason44Choice.Proprietary))]
    [IsoId("_iW99IxrpEeyhRdHRjakS2w")]
    [DisplayName("Rejected Reason 44 Choice")]
    public abstract partial record RejectedReason44Choice_
    {
    }
}
