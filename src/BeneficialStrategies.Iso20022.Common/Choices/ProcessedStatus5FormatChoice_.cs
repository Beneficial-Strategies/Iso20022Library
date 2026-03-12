// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the processing status of a request.
    /// </summary>
    [KnownType(typeof(ProcessedStatus5FormatChoice.Code))]
    [KnownType(typeof(ProcessedStatus5FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(ProcessedStatus5FormatChoice.Code),nameof(ProcessedStatus5FormatChoice.Code))]
    [JsonDerivedType(typeof(ProcessedStatus5FormatChoice.Proprietary),nameof(ProcessedStatus5FormatChoice.Proprietary))]
    [IsoId("_RnmN8tp-Ed-ak6NoX_4Aeg_-1411191918")]
    [DisplayName("Processed Status 5 Format Choice")]
    public abstract partial record ProcessedStatus5FormatChoice_
    {
    }
}
