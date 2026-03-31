// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason23Choice.Code))]
    [KnownType(typeof(AcknowledgementReason23Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AcknowledgementReason23Choice.Code),
        nameof(AcknowledgementReason23Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AcknowledgementReason23Choice.Proprietary),
        nameof(AcknowledgementReason23Choice.Proprietary)
    )]
    [IsoId("_MNvhAekHEemm4qhb2yFPOw")]
    [DisplayName("Acknowledgement Reason 23 Choice")]
    public abstract record AcknowledgementReason23Choice_ { }
}
