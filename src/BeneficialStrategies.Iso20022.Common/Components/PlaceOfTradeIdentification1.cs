// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of market in which a trade transaction has been executed.
/// </summary>
[IsoId("_xU1ak2wsEeWLq_lbZ2Mhyw")]
[DisplayName("Place Of Trade Identification")]
public record PlaceOfTradeIdentification1
{
    /// <summary>
    /// Identification and type of the place of trade.
    /// </summary>
    [IsoId("_xU1alGwsEeWLq_lbZ2Mhyw")]
    [DisplayName("Market Type And Identification")]
    [IsoXmlTag("MktTpAndId")]
    public MarketIdentification84? MarketTypeAndIdentification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a place of trade.
    /// </summary>
    [IsoId("_xU1alWwsEeWLq_lbZ2Mhyw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
