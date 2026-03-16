// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus1FormatChoice.Code))]
    [KnownType(typeof(ProcessingStatus1FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessingStatus1FormatChoice.Code),
        nameof(ProcessingStatus1FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus1FormatChoice.Proprietary),
        nameof(ProcessingStatus1FormatChoice.Proprietary)
    )]
    [IsoId("_Rnv-89p-Ed-ak6NoX_4Aeg_-1083184127")]
    [DisplayName("Processing Status 1 Format Choice")]
    public abstract record ProcessingStatus1FormatChoice_ { }
}
