// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the processing status of the standing instruction cancellation request.
    /// </summary>
    [KnownType(typeof(ProcessedStatus4FormatChoice.Code))]
    [KnownType(typeof(ProcessedStatus4FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessedStatus4FormatChoice.Code),
        nameof(ProcessedStatus4FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(ProcessedStatus4FormatChoice.Proprietary),
        nameof(ProcessedStatus4FormatChoice.Proprietary)
    )]
    [IsoId("_RnTTB9p-Ed-ak6NoX_4Aeg_-1763256245")]
    [DisplayName("Processed Status 4 Format Choice")]
    public abstract record ProcessedStatus4FormatChoice_ { }
}
