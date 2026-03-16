// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards central counterparty.
/// </summary>
[IsoId("_-eWgAKMOEeCojJW5vEuTEQ_-52349864")]
[DisplayName("Variation Margin")]
public record VariationMargin3
{
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_-eWgAaMOEeCojJW5vEuTEQ_-317540862")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards the central counterparty.
    /// </summary>
    [IsoId("_-eWgAqMOEeCojJW5vEuTEQ_-166188930")]
    [DisplayName("Total Variation Margin")]
    [IsoXmlTag("TtlVartnMrgn")]
    public ValueList<TotalVariationMargin1> TotalVariationMargin { get; init; } = [];

    // ID for the above is _-eWgAqMOEeCojJW5vEuTEQ_-166188930

    /// <summary>
    /// Net unrealised profit or loss on the value of the netted, gross and failing positions.
    /// </summary>
    [IsoId("_-eWgA6MOEeCojJW5vEuTEQ_-1163261283")]
    [DisplayName("Total Mark To Market")]
    [IsoXmlTag("TtlMrkToMkt")]
    public required Amount2 TotalMarkToMarket { get; init; }

    /// <summary>
    /// Unrealised net loss calculated at the participant portfolio level.
    /// </summary>
    [IsoId("_-eWgBKMOEeCojJW5vEuTEQ_2134633660")]
    [DisplayName("Mark To Market Netted")]
    [IsoXmlTag("MrkToMktNetd")]
    public Amount2? MarkToMarketNetted { get; init; }

    /// <summary>
    /// Unrealised net loss calculated in that market/boundary.
    /// </summary>
    [IsoId("_-eWgBaMOEeCojJW5vEuTEQ_1137561307")]
    [DisplayName("Mark To Market Gross")]
    [IsoXmlTag("MrkToMktGrss")]
    public Amount2? MarkToMarketGross { get; init; }

    /// <summary>
    /// Sum of the unrealised loss without taking profit into consideration.
    /// </summary>
    [IsoId("_-eWgBqMOEeCojJW5vEuTEQ_1906471397")]
    [DisplayName("Mark To Market Fails")]
    [IsoXmlTag("MrkToMktFls")]
    public Amount2? MarkToMarketFails { get; init; }

    /// <summary>
    /// Haircut applied to the absolute value of the participants net positions. Calculation depends on a participants credit rating.
    /// </summary>
    [IsoId("_-eWgB6MOEeCojJW5vEuTEQ_909399044")]
    [DisplayName("Fails Haircut")]
    [IsoXmlTag("FlsHrcut")]
    public Amount2? FailsHaircut { get; init; }
}
