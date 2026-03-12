// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason29Choice.Code))]
    [KnownType(typeof(RejectionReason29Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason29Choice.Code),nameof(RejectionReason29Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason29Choice.Proprietary),nameof(RejectionReason29Choice.Proprietary))]
    [IsoId("_6HWbQ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Reason 29 Choice")]
    public abstract partial record RejectionReason29Choice_
    {
    }
}
