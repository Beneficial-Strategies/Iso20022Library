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
[IsoId("_k9pQ4c3xEee5nJBZsW8MFQ")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice69
{
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_k9pQ5c3xEee5nJBZsW8MFQ")]
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat57Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    [IsoId("_k9pQ7c3xEee5nJBZsW8MFQ")]
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat57Choice_? OverSubscriptionDepositPrice { get; init; }

    /// <summary>
    /// Maximum cash amount that may be instructed.
    /// </summary>
    [IsoId("_k9pQ9c3xEee5nJBZsW8MFQ")]
    [DisplayName("Maximum Cash To Instruct")]
    [IsoXmlTag("MaxCshToInst")]
    public PriceFormat62Choice_? MaximumCashToInstruct { get; init; }

    /// <summary>
    /// Minimum cash amount that may be instructed.
    /// </summary>
    [IsoId("_k9pQ983xEee5nJBZsW8MFQ")]
    [DisplayName("Minimum Cash To Instruct")]
    [IsoXmlTag("MinCshToInst")]
    public PriceFormat62Choice_? MinimumCashToInstruct { get; init; }

    /// <summary>
    /// Minimum multiple of a cash amount that may be instructed.
    /// </summary>
    [IsoId("_k9pQ-c3xEee5nJBZsW8MFQ")]
    [DisplayName("Minimum Multiple Cash To Instruct")]
    [IsoXmlTag("MinMltplCshToInst")]
    public PriceFormat62Choice_? MinimumMultipleCashToInstruct { get; init; }
}
