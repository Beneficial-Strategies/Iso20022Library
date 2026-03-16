// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason14Choice.Code))]
    [KnownType(typeof(AcknowledgementReason14Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AcknowledgementReason14Choice.Code),
        nameof(AcknowledgementReason14Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AcknowledgementReason14Choice.Proprietary),
        nameof(AcknowledgementReason14Choice.Proprietary)
    )]
    [IsoId("_YhcWizq1EeWyoP0PbocV1Q")]
    [DisplayName("Acknowledgement Reason 14 Choice")]
    public abstract record AcknowledgementReason14Choice_ { }
}
