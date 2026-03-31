// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices.
/// </summary>
[IsoId("_QCk_M0GMEeWqy4niLuXETA")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice61
{
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_QPYFBUGMEeWqy4niLuXETA")]
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat50Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    [IsoId("_QPYFDUGMEeWqy4niLuXETA")]
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat50Choice_? OverSubscriptionDepositPrice { get; init; }
}
