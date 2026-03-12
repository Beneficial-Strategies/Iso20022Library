// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason22Choice.Code))]
    [KnownType(typeof(AcknowledgementReason22Choice.Proprietary))]
    [JsonDerivedType(typeof(AcknowledgementReason22Choice.Code),nameof(AcknowledgementReason22Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason22Choice.Proprietary),nameof(AcknowledgementReason22Choice.Proprietary))]
    [IsoId("_6QE5iZNLEeWGlc8L7oPDIg")]
    [DisplayName("Acknowledgement Reason 22 Choice")]
    public abstract partial record AcknowledgementReason22Choice_
    {
    }
}
