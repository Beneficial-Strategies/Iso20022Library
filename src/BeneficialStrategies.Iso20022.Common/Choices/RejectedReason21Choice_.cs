// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for a rejected reason.
    /// </summary>
    [KnownType(typeof(RejectedReason21Choice.Code))]
    [KnownType(typeof(RejectedReason21Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason21Choice.Code), nameof(RejectedReason21Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason21Choice.Proprietary),
        nameof(RejectedReason21Choice.Proprietary)
    )]
    [IsoId("_QKAfsUguEeazC43Xuh-e6w")]
    [DisplayName("Rejected Reason 21 Choice")]
    public abstract record RejectedReason21Choice_ { }
}
