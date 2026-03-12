// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason2Choice.Code))]
    [KnownType(typeof(AcknowledgementReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(AcknowledgementReason2Choice.Code),nameof(AcknowledgementReason2Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason2Choice.Proprietary),nameof(AcknowledgementReason2Choice.Proprietary))]
    [IsoId("_UXuzRNp-Ed-ak6NoX_4Aeg_2050241792")]
    [DisplayName("Acknowledgement Reason 2 Choice")]
    public abstract partial record AcknowledgementReason2Choice_
    {
    }
}
