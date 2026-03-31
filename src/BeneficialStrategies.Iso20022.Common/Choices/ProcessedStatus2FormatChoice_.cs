// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the processing status of a cancellation request.
    /// </summary>
    [KnownType(typeof(ProcessedStatus2FormatChoice.Code))]
    [KnownType(typeof(ProcessedStatus2FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessedStatus2FormatChoice.Code),
        nameof(ProcessedStatus2FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(ProcessedStatus2FormatChoice.Proprietary),
        nameof(ProcessedStatus2FormatChoice.Proprietary)
    )]
    [IsoId("_RnJiBtp-Ed-ak6NoX_4Aeg_-302074425")]
    [DisplayName("Processed Status 2 Format Choice")]
    public abstract record ProcessedStatus2FormatChoice_ { }
}
