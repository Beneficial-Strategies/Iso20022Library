// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the value of a price.
    /// </summary>
    [KnownType(typeof(PriceValueType5FormatChoice.Code))]
    [KnownType(typeof(PriceValueType5FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(PriceValueType5FormatChoice.Code),
        nameof(PriceValueType5FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(PriceValueType5FormatChoice.Proprietary),
        nameof(PriceValueType5FormatChoice.Proprietary)
    )]
    [IsoId("_RnAYFtp-Ed-ak6NoX_4Aeg_-475448184")]
    [DisplayName("Price Value Type 5 Format Choice")]
    public abstract record PriceValueType5FormatChoice_ { }
}
