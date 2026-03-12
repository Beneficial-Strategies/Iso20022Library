// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason34Choice.Code))]
    [KnownType(typeof(RejectionReason34Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason34Choice.Code),nameof(RejectionReason34Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason34Choice.Proprietary),nameof(RejectionReason34Choice.Proprietary))]
    [IsoId("_8QddH5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Reason 34 Choice")]
    public abstract partial record RejectionReason34Choice_
    {
    }
}
