// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason16Choice.Code))]
    [KnownType(typeof(AcknowledgementReason16Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AcknowledgementReason16Choice.Code),
        nameof(AcknowledgementReason16Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AcknowledgementReason16Choice.Proprietary),
        nameof(AcknowledgementReason16Choice.Proprietary)
    )]
    [IsoId("_5SFnq5NLEeWGlc8L7oPDIg")]
    [DisplayName("Acknowledgement Reason 16 Choice")]
    public abstract record AcknowledgementReason16Choice_ { }
}
