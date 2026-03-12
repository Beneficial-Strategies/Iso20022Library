// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason24Choice.Code))]
    [KnownType(typeof(AcknowledgementReason24Choice.Proprietary))]
    [JsonDerivedType(typeof(AcknowledgementReason24Choice.Code),nameof(AcknowledgementReason24Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason24Choice.Proprietary),nameof(AcknowledgementReason24Choice.Proprietary))]
    [IsoId("_H2g1cZwZEeqtp-LOti013g")]
    [DisplayName("Acknowledgement Reason 24 Choice")]
    public abstract partial record AcknowledgementReason24Choice_
    {
    }
}
