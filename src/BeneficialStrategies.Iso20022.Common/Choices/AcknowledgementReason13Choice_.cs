// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason13Choice.Code))]
    [KnownType(typeof(AcknowledgementReason13Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AcknowledgementReason13Choice.Code),
        nameof(AcknowledgementReason13Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AcknowledgementReason13Choice.Proprietary),
        nameof(AcknowledgementReason13Choice.Proprietary)
    )]
    [IsoId("_TBij0TqrEeWyoP0PbocV1Q")]
    [DisplayName("Acknowledgement Reason 13 Choice")]
    public abstract record AcknowledgementReason13Choice_ { }
}
