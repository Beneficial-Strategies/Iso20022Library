// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason4Choice.Code))]
    [KnownType(typeof(AcknowledgementReason4Choice.Proprietary))]
    [JsonDerivedType(typeof(AcknowledgementReason4Choice.Code),nameof(AcknowledgementReason4Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason4Choice.Proprietary),nameof(AcknowledgementReason4Choice.Proprietary))]
    [IsoId("_UZEQBtp-Ed-ak6NoX_4Aeg_-1118171276")]
    [DisplayName("Acknowledgement Reason 4 Choice")]
    public abstract partial record AcknowledgementReason4Choice_
    {
    }
}
