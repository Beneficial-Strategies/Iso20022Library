// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition2FormatChoice.Code))]
    [KnownType(typeof(ProcessingPosition2FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingPosition2FormatChoice.Code),nameof(ProcessingPosition2FormatChoice.Code))]
    [JsonDerivedType(typeof(ProcessingPosition2FormatChoice.Proprietary),nameof(ProcessingPosition2FormatChoice.Proprietary))]
    [IsoId("_Rnv-8Np-Ed-ak6NoX_4Aeg_306788682")]
    [DisplayName("Processing Position 2 Format Choice")]
    public abstract partial record ProcessingPosition2FormatChoice_
    {
    }
}
