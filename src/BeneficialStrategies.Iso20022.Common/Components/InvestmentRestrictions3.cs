// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investment restrictions linked to the trading of an investment fund, or an alternative/hedge fund.
/// </summary>
[IsoId("_Sp4ScV88Eeicg40_9gK9vQ")]
[DisplayName("Investment Restrictions")]
public record InvestmentRestrictions3
{
    /// <summary>
    /// Minimum initial quantity of securities, expressed as an amount, that must be purchased at subscription.
    /// </summary>
    [IsoId("_S5y9w188Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Initial Subscription Amount")]
    [IsoXmlTag("MinInitlSbcptAmt")]
    public ActiveCurrencyAndAmount? MinimumInitialSubscriptionAmount { get; init; }

    /// <summary>
    /// Minimum initial number of units/shares that must be purchased.
    /// </summary>
    [IsoId("_S5y9xV88Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Initial Subscription Units")]
    [IsoXmlTag("MinInitlSbcptUnits")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MinimumInitialSubscriptionUnits { get; init; }

    /// <summary>
    /// Minimum quantity of securities, expressed as an amount, that must be purchased.
    /// </summary>
    [IsoId("_S5y9x188Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Subsequent Subscription Amount")]
    [IsoXmlTag("MinSbsqntSbcptAmt")]
    public ActiveCurrencyAndAmount? MinimumSubsequentSubscriptionAmount { get; init; }

    /// <summary>
    /// Minimum quantity of securities, expressed as number of units/shares that must be purchased.
    /// </summary>
    [IsoId("_S5y9yV88Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Subsequent Subscription Units")]
    [IsoXmlTag("MinSbsqntSbcptUnits")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MinimumSubsequentSubscriptionUnits { get; init; }

    /// <summary>
    /// Maximum quantity of securities, expressed as an amount, that can be sold.
    /// </summary>
    [IsoId("_S5y9y188Eeicg40_9gK9vQ")]
    [DisplayName("Maximum Redemption Amount")]
    [IsoXmlTag("MaxRedAmt")]
    public ActiveCurrencyAndAmount? MaximumRedemptionAmount { get; init; }

    /// <summary>
    /// Maximum number of shares/units that may be redeemed on a single dealing day.
    /// </summary>
    [IsoId("_S5y9zV88Eeicg40_9gK9vQ")]
    [DisplayName("Maximum Redemption Units")]
    [IsoXmlTag("MaxRedUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? MaximumRedemptionUnits { get; init; }

    /// <summary>
    /// Minimum percentage of holding that may be redeemed.
    /// </summary>
    [IsoId("_0VZA0N6eEei9RJrL5H7TLQ")]
    [DisplayName("Minimum Redemption Percentage")]
    [IsoXmlTag("MinRedPctg")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? MinimumRedemptionPercentage { get; init; }

    /// <summary>
    /// Specifies any other restrictions that may limit an investor&apos;s ability to redeem.
    /// </summary>
    [IsoId("_S5y9z188Eeicg40_9gK9vQ")]
    [DisplayName("Other Redemption Restrictions")]
    [IsoXmlTag("OthrRedRstrctns")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? OtherRedemptionRestrictions { get; init; }

    /// <summary>
    /// Minimum quantity of securities, expressed as an amount, that must be purchased.
    /// </summary>
    [IsoId("_zKI5MN6fEei9RJrL5H7TLQ")]
    [DisplayName("Minimum Switch Subscription Amount")]
    [IsoXmlTag("MinSwtchSbcptAmt")]
    public ActiveCurrencyAndAmount? MinimumSwitchSubscriptionAmount { get; init; }

    /// <summary>
    /// Minimum quantity of securities, expressed as number of units/shares that must be purchased.
    /// </summary>
    [IsoId("_8WiXUN6fEei9RJrL5H7TLQ")]
    [DisplayName("Minimum Switch Subscription Units")]
    [IsoXmlTag("MinSwtchSbcptUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? MinimumSwitchSubscriptionUnits { get; init; }

    /// <summary>
    /// Maximum quantity of securities, expressed as an amount, that can be sold.
    /// </summary>
    [IsoId("_kS7MwF88Eeicg40_9gK9vQ")]
    [DisplayName("Maximum Switch Redemption Amount")]
    [IsoXmlTag("MaxSwtchRedAmt")]
    public ActiveCurrencyAndAmount? MaximumSwitchRedemptionAmount { get; init; }

    /// <summary>
    /// Maximum number of shares/units that may be redeemed on a single dealing day.
    /// </summary>
    [IsoId("_CNJlYN6gEei9RJrL5H7TLQ")]
    [DisplayName("Maximum Switch Redemption Units")]
    [IsoXmlTag("MaxSwtchRedUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? MaximumSwitchRedemptionUnits { get; init; }

    /// <summary>
    /// Specifies any other restrictions that may limit an investor&apos;s ability to switch.
    /// </summary>
    [IsoId("_1coDMF89Eeicg40_9gK9vQ")]
    [DisplayName("Other Switch Restrictions")]
    [IsoXmlTag("OthrSwtchRstrctns")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? OtherSwitchRestrictions { get; init; }

    /// <summary>
    /// Minimum value of units that must be maintained to avoid automatic redemption.
    /// </summary>
    [IsoId("_S5y90V88Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Holding Amount")]
    [IsoXmlTag("MinHldgAmt")]
    public ActiveCurrencyAndAmount? MinimumHoldingAmount { get; init; }

    /// <summary>
    /// Minimum number of units that must be maintained to avoid automatic redemption.
    /// </summary>
    [IsoId("_S5y90188Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Holding Units")]
    [IsoXmlTag("MinHldgUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? MinimumHoldingUnits { get; init; }

    /// <summary>
    /// Description of the period, that may be a number of days or weeks or another way of describing the period, during which the units/shares must be held following their issue before redemption will be permitted.
    /// </summary>
    [IsoId("_S5y91V88Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Holding Period")]
    [IsoXmlTag("MinHldgPrd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? MinimumHoldingPeriod { get; init; }

    /// <summary>
    /// Specifies how registered investors are able to transfer some or all of their holdings to third parties.
    /// </summary>
    [IsoId("_S5y91188Eeicg40_9gK9vQ")]
    [DisplayName("Holding Transferable")]
    [IsoXmlTag("HldgTrfbl")]
    public HoldingTransferable1Code? HoldingTransferable { get; init; }

    /// <summary>
    /// Additional information about the investment restrictions.
    /// </summary>
    [IsoId("_Val68WAKEeiNMJ262H2pWg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
