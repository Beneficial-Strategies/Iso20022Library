// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason21Choice.Code))]
    [KnownType(typeof(AcknowledgementReason21Choice.Proprietary))]
    [JsonDerivedType(typeof(AcknowledgementReason21Choice.Code),nameof(AcknowledgementReason21Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason21Choice.Proprietary),nameof(AcknowledgementReason21Choice.Proprietary))]
    [IsoId("_6QCde5NLEeWGlc8L7oPDIg")]
    [DisplayName("Acknowledgement Reason 21 Choice")]
    public abstract partial record AcknowledgementReason21Choice_
    {
    }
}
