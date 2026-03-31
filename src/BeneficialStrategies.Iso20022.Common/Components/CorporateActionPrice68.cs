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
[IsoId("_n-nV0ZbSEee8S7xwGG7Veg")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice68
{
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_oPIeE5bSEee8S7xwGG7Veg")]
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    [IsoId("_oPIeG5bSEee8S7xwGG7Veg")]
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat45Choice_? OverSubscriptionDepositPrice { get; init; }

    /// <summary>
    /// Maximum cash amount that may be instructed.
    /// </summary>
    [IsoId("_Dn3JwJbTEee8S7xwGG7Veg")]
    [DisplayName("Maximum Cash To Instruct")]
    [IsoXmlTag("MaxCshToInst")]
    public PriceFormat61Choice_? MaximumCashToInstruct { get; init; }

    /// <summary>
    /// Minimum cash amount that may be instructed.
    /// </summary>
    [IsoId("_LJvm0JbTEee8S7xwGG7Veg")]
    [DisplayName("Minimum Cash To Instruct")]
    [IsoXmlTag("MinCshToInst")]
    public PriceFormat61Choice_? MinimumCashToInstruct { get; init; }

    /// <summary>
    /// Minimum multiple of a cash amount that may be instructed.
    /// </summary>
    [IsoId("_VWIiUJbTEee8S7xwGG7Veg")]
    [DisplayName("Minimum Multiple Cash To Instruct")]
    [IsoXmlTag("MinMltplCshToInst")]
    public PriceFormat61Choice_? MinimumMultipleCashToInstruct { get; init; }
}
