// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statistical data related to the price change of a security.
/// </summary>
[IsoId("44b34bb0-c4ab-42c4-b48e-a74ae1818957")]
[DisplayName("Statistics By User Defined Time Period3")]
public record StatisticsByUserDefinedTimePeriod3
{
    [IsoId("3cc5efe9-fd6d-4028-b906-da7e9073b9a8")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public required DateOrDateTimePeriod4Choice Period { get; init; }

    [IsoId("f43e8e3e-23cc-4d38-9ced-2bf8404df528")]
    [DisplayName("Highest Price Value")]
    [IsoXmlTag("HghstPricVal")]
    public PriceValue5? HighestPriceValue { get; init; }

    [IsoId("eb8655cc-3836-424e-9858-69e21356ab01")]
    [DisplayName("Lowest Price Value")]
    [IsoXmlTag("LwstPricVal")]
    public PriceValue5? LowestPriceValue { get; init; }

    [IsoId("394136b8-7999-4628-a534-10d003483550")]
    [DisplayName("Price Change")]
    [IsoXmlTag("PricChng")]
    public PriceValueChange1? PriceChange { get; init; }

    [IsoId("827722bb-eb5d-48b0-afa1-bfc242dab654")]
    [DisplayName("Yield")]
    [IsoXmlTag("Yld")]
    public IsoPercentageRate? Yield { get; init; }
}
