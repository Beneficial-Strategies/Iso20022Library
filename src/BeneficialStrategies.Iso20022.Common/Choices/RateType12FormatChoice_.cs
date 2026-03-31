// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of rate.
    /// </summary>
    [KnownType(typeof(RateType12FormatChoice.Code))]
    [KnownType(typeof(RateType12FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RateType12FormatChoice.Code), nameof(RateType12FormatChoice.Code))]
    [JsonDerivedType(
        typeof(RateType12FormatChoice.Proprietary),
        nameof(RateType12FormatChoice.Proprietary)
    )]
    [IsoId("_RnTTAdp-Ed-ak6NoX_4Aeg_-671557458")]
    [DisplayName("Rate Type 12 Format Choice")]
    public abstract record RateType12FormatChoice_ { }
}
