// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Price94.
/// </summary>
[IsoId("_l6UitZt3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Price94")]
public record CorporateActionPrice94
{
    /// <summary>
    /// Cash In Lieu Of Share Price.
    /// </summary>
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat88Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Maximum Cash To Instruct.
    /// </summary>
    [DisplayName("Maximum Cash To Instruct")]
    [IsoXmlTag("MaxCshToInst")]
    public PriceFormat62Choice_? MaximumCashToInstruct { get; init; }

    /// <summary>
    /// Minimum Cash To Instruct.
    /// </summary>
    [DisplayName("Minimum Cash To Instruct")]
    [IsoXmlTag("MinCshToInst")]
    public PriceFormat62Choice_? MinimumCashToInstruct { get; init; }

    /// <summary>
    /// Minimum Multiple Cash To Instruct.
    /// </summary>
    [DisplayName("Minimum Multiple Cash To Instruct")]
    [IsoXmlTag("MinMltplCshToInst")]
    public PriceFormat62Choice_? MinimumMultipleCashToInstruct { get; init; }

    /// <summary>
    /// Over Subscription Deposit Price.
    /// </summary>
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat88Choice_? OverSubscriptionDepositPrice { get; init; }
}
