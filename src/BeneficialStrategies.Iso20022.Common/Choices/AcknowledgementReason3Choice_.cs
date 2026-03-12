// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason3Choice.Code))]
    [KnownType(typeof(AcknowledgementReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(AcknowledgementReason3Choice.Code),nameof(AcknowledgementReason3Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason3Choice.Proprietary),nameof(AcknowledgementReason3Choice.Proprietary))]
    [IsoId("_UXb4UNp-Ed-ak6NoX_4Aeg_-1471943944")]
    [DisplayName("Acknowledgement Reason 3 Choice")]
    public abstract partial record AcknowledgementReason3Choice_
    {
    }
}
