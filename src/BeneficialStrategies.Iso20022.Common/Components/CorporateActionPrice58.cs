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
[IsoId("_cxMWUUEJEeWVgfuHGaKtRQ")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice58
{
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_c9r6M0EJEeWVgfuHGaKtRQ")]
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    [IsoId("_c9r6O0EJEeWVgfuHGaKtRQ")]
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat45Choice_? OverSubscriptionDepositPrice { get; init; }
}
