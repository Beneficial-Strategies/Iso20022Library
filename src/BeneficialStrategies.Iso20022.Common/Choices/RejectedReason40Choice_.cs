// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason40Choice.Code))]
    [KnownType(typeof(RejectedReason40Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason40Choice.Code),nameof(RejectedReason40Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason40Choice.Proprietary),nameof(RejectedReason40Choice.Proprietary))]
    [IsoId("_9FBMuR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Rejected Reason 40 Choice")]
    public abstract partial record RejectedReason40Choice_
    {
    }
}
