// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the effect on the holdings of electing a Corporate Action option.
    /// </summary>
    [KnownType(typeof(ElectionMovementType1FormatChoice.Code))]
    [KnownType(typeof(ElectionMovementType1FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(ElectionMovementType1FormatChoice.Code),
        nameof(ElectionMovementType1FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(ElectionMovementType1FormatChoice.Proprietary),
        nameof(ElectionMovementType1FormatChoice.Proprietary)
    )]
    [IsoId("_RmZ7KNp-Ed-ak6NoX_4Aeg_-162374366")]
    [DisplayName("Election Movement Type 1 Format Choice")]
    public abstract record ElectionMovementType1FormatChoice_ { }
}
