// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the value of a price.
    /// </summary>
    [KnownType(typeof(PriceValueType6FormatChoice.Code))]
    [KnownType(typeof(PriceValueType6FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(PriceValueType6FormatChoice.Code),
        nameof(PriceValueType6FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(PriceValueType6FormatChoice.Proprietary),
        nameof(PriceValueType6FormatChoice.Proprietary)
    )]
    [IsoId("_RnJiANp-Ed-ak6NoX_4Aeg_-164588960")]
    [DisplayName("Price Value Type 6 Format Choice")]
    public abstract record PriceValueType6FormatChoice_ { }
}
