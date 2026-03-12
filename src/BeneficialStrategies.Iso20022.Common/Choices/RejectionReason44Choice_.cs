// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason44Choice.Code))]
    [KnownType(typeof(RejectionReason44Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason44Choice.Code),nameof(RejectionReason44Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason44Choice.Proprietary),nameof(RejectionReason44Choice.Proprietary))]
    [IsoId("_iB2NeStXEeyhipY4f42fZQ")]
    [DisplayName("Rejection Reason 44 Choice")]
    public abstract partial record RejectionReason44Choice_
    {
    }
}
