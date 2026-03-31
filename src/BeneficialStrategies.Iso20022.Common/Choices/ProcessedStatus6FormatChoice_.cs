// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the processing status of a deactivation instruction.
    /// </summary>
    [KnownType(typeof(ProcessedStatus6FormatChoice.Code))]
    [KnownType(typeof(ProcessedStatus6FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessedStatus6FormatChoice.Code),
        nameof(ProcessedStatus6FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(ProcessedStatus6FormatChoice.Proprietary),
        nameof(ProcessedStatus6FormatChoice.Proprietary)
    )]
    [IsoId("_RnmN9dp-Ed-ak6NoX_4Aeg_-344158716")]
    [DisplayName("Processed Status 6 Format Choice")]
    public abstract record ProcessedStatus6FormatChoice_ { }
}
