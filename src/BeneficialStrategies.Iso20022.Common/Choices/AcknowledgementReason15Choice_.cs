// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason15Choice.Code))]
    [KnownType(typeof(AcknowledgementReason15Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AcknowledgementReason15Choice.Code),
        nameof(AcknowledgementReason15Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AcknowledgementReason15Choice.Proprietary),
        nameof(AcknowledgementReason15Choice.Proprietary)
    )]
    [IsoId("_Pea6ETq5EeWyoP0PbocV1Q")]
    [DisplayName("Acknowledgement Reason 15 Choice")]
    public abstract record AcknowledgementReason15Choice_ { }
}
