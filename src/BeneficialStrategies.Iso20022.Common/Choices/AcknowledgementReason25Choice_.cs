// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason25Choice.Code))]
    [KnownType(typeof(AcknowledgementReason25Choice.Proprietary))]
    [JsonDerivedType(typeof(AcknowledgementReason25Choice.Code), nameof(AcknowledgementReason25Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason25Choice.Proprietary), nameof(AcknowledgementReason25Choice.Proprietary))]
    [IsoId("_XLTbXo5bEfC_4ZEXsY0Xyg")]
    [DisplayName("AcknowledgementReason25Choice")]
    public abstract record AcknowledgementReason25Choice_ { }
}
