// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the conditions that apply to the offer.
    /// </summary>
    [KnownType(typeof(OfferType1FormatChoice.Code))]
    [KnownType(typeof(OfferType1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(OfferType1FormatChoice.Code), nameof(OfferType1FormatChoice.Code))]
    [JsonDerivedType(
        typeof(OfferType1FormatChoice.Proprietary),
        nameof(OfferType1FormatChoice.Proprietary)
    )]
    [IsoId("_Rm2nEtp-Ed-ak6NoX_4Aeg_-1842379446")]
    [DisplayName("Offer Type 1 Format Choice")]
    public abstract record OfferType1FormatChoice_ { }
}
