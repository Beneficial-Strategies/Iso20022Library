// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices related to a corporate action option.
/// </summary>
[IsoId("_x_J20R9REeuFz_FaCzCLgQ")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice71
{
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_x_J21R9REeuFz_FaCzCLgQ")]
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat57Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    [IsoId("_x_J23R9REeuFz_FaCzCLgQ")]
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat57Choice_? OverSubscriptionDepositPrice { get; init; }

    /// <summary>
    /// Maximum cash amount that may be instructed.
    /// </summary>
    [IsoId("_x_J25R9REeuFz_FaCzCLgQ")]
    [DisplayName("Maximum Cash To Instruct")]
    [IsoXmlTag("MaxCshToInst")]
    public PriceFormat62Choice_? MaximumCashToInstruct { get; init; }

    /// <summary>
    /// Minimum cash amount that may be instructed.
    /// </summary>
    [IsoId("_x_J25x9REeuFz_FaCzCLgQ")]
    [DisplayName("Minimum Cash To Instruct")]
    [IsoXmlTag("MinCshToInst")]
    public PriceFormat62Choice_? MinimumCashToInstruct { get; init; }

    /// <summary>
    /// Minimum multiple of a cash amount that may be instructed.
    /// </summary>
    [IsoId("_x_J26R9REeuFz_FaCzCLgQ")]
    [DisplayName("Minimum Multiple Cash To Instruct")]
    [IsoXmlTag("MinMltplCshToInst")]
    public PriceFormat62Choice_? MinimumMultipleCashToInstruct { get; init; }

    /// <summary>
    /// Maximum or cap price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_x_J26x9REeuFz_FaCzCLgQ")]
    [DisplayName("Maximum Price")]
    [IsoXmlTag("MaxPric")]
    public PriceFormat44Choice_? MaximumPrice { get; init; }

    /// <summary>
    /// Minimum or floor price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_x_J28x9REeuFz_FaCzCLgQ")]
    [DisplayName("Minimum Price")]
    [IsoXmlTag("MinPric")]
    public PriceFormat44Choice_? MinimumPrice { get; init; }
}
