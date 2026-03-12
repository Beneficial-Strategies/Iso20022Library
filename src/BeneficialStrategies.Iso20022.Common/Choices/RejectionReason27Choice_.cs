// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason27Choice.Code))]
    [KnownType(typeof(RejectionReason27Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason27Choice.Code),nameof(RejectionReason27Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason27Choice.Proprietary),nameof(RejectionReason27Choice.Proprietary))]
    [IsoId("_dXQZST0CEeWjqIDN7tjEjQ")]
    [DisplayName("Rejection Reason 27 Choice")]
    public abstract partial record RejectionReason27Choice_
    {
    }
}
