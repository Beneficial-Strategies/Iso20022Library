// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of the source (place) of the price quotation.
    /// </summary>
    [KnownType(typeof(PriceSourceFormatChoice.LocalMarketPlace))]
    [KnownType(typeof(PriceSourceFormatChoice.NonLocalMarketPlace))]
    [KnownType(typeof(PriceSourceFormatChoice.PlaceAsDSS))]
    [JsonDerivedType(typeof(PriceSourceFormatChoice.LocalMarketPlace),nameof(PriceSourceFormatChoice.LocalMarketPlace))]
    [JsonDerivedType(typeof(PriceSourceFormatChoice.NonLocalMarketPlace),nameof(PriceSourceFormatChoice.NonLocalMarketPlace))]
    [JsonDerivedType(typeof(PriceSourceFormatChoice.PlaceAsDSS),nameof(PriceSourceFormatChoice.PlaceAsDSS))]
    [IsoId("_RCDQ49p-Ed-ak6NoX_4Aeg_2134054867")]
    [DisplayName("Price Source Format Choice")]
    public abstract partial record PriceSourceFormatChoice_
    {
    }
}
