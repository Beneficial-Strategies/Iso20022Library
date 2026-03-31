// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason12Choice.Code))]
    [KnownType(typeof(AcknowledgementReason12Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AcknowledgementReason12Choice.Code),
        nameof(AcknowledgementReason12Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AcknowledgementReason12Choice.Proprietary),
        nameof(AcknowledgementReason12Choice.Proprietary)
    )]
    [IsoId("_hyO3cTnvEeWfSKvvZlhRKg")]
    [DisplayName("Acknowledgement Reason 12 Choice")]
    public abstract record AcknowledgementReason12Choice_ { }
}
