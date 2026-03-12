// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the processing status of an advice, a request or a movement.
    /// </summary>
    [KnownType(typeof(ProcessedStatus3FormatChoice.Code))]
    [KnownType(typeof(ProcessedStatus3FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(ProcessedStatus3FormatChoice.Code),nameof(ProcessedStatus3FormatChoice.Code))]
    [JsonDerivedType(typeof(ProcessedStatus3FormatChoice.Proprietary),nameof(ProcessedStatus3FormatChoice.Proprietary))]
    [IsoId("_RnTTBNp-Ed-ak6NoX_4Aeg_1585305057")]
    [DisplayName("Processed Status 3 Format Choice")]
    public abstract partial record ProcessedStatus3FormatChoice_
    {
    }
}
