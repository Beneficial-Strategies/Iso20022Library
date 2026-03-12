// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason9Choice.Code))]
    [KnownType(typeof(AcknowledgementReason9Choice.Proprietary))]
    [JsonDerivedType(typeof(AcknowledgementReason9Choice.Code),nameof(AcknowledgementReason9Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason9Choice.Proprietary),nameof(AcknowledgementReason9Choice.Proprietary))]
    [IsoId("_0jOiAAlIEeGATtfOBToyew_843870273")]
    [DisplayName("Acknowledgement Reason 9 Choice")]
    public abstract partial record AcknowledgementReason9Choice_
    {
    }
}
