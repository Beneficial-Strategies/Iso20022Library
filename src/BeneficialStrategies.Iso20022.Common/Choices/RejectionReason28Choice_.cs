// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason28Choice.Code))]
    [KnownType(typeof(RejectionReason28Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason28Choice.Code),nameof(RejectionReason28Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason28Choice.Proprietary),nameof(RejectionReason28Choice.Proprietary))]
    [IsoId("_6BGCXZNLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Reason 28 Choice")]
    public abstract partial record RejectionReason28Choice_
    {
    }
}
