// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason18Choice.Code))]
    [KnownType(typeof(AcknowledgementReason18Choice.Proprietary))]
    [JsonDerivedType(typeof(AcknowledgementReason18Choice.Code),nameof(AcknowledgementReason18Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason18Choice.Proprietary),nameof(AcknowledgementReason18Choice.Proprietary))]
    [IsoId("_6BLh4ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Acknowledgement Reason 18 Choice")]
    public abstract partial record AcknowledgementReason18Choice_
    {
    }
}
