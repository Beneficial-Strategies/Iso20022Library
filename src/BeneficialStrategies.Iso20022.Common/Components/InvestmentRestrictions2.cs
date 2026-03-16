// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investment restrictions linked to the instrument.
/// </summary>
[IsoId("_ScM6utp-Ed-ak6NoX_4Aeg_841139560")]
[DisplayName("Investment Restrictions")]
public record InvestmentRestrictions2
{
    /// <summary>
    /// Minimum initial quantity of securities, expressed as an amount that must be purchased at subscription.
    /// </summary>
    [IsoId("_ScM6u9p-Ed-ak6NoX_4Aeg_842059571")]
    [DisplayName("Minimum Initial Subscription Amount")]
    [IsoXmlTag("MinInitlSbcptAmt")]
    public ActiveCurrencyAndAmount? MinimumInitialSubscriptionAmount { get; init; }

    /// <summary>
    /// Minimum initial number of units/shares that must be purchased.
    /// </summary>
    [IsoId("_ScWEoNp-Ed-ak6NoX_4Aeg_842059623")]
    [DisplayName("Minimum Initial Subscription Units")]
    [IsoXmlTag("MinInitlSbcptUnits")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MinimumInitialSubscriptionUnits { get; init; }

    /// <summary>
    /// Minimum quantity of securities, expressed as an amount that must be purchased.
    /// </summary>
    [IsoId("_ScWEodp-Ed-ak6NoX_4Aeg_842059715")]
    [DisplayName("Minimum Subsequent Subscription Amount")]
    [IsoXmlTag("MinSbsqntSbcptAmt")]
    public ActiveCurrencyAndAmount? MinimumSubsequentSubscriptionAmount { get; init; }

    /// <summary>
    /// Minimum quantity of securities, expressed as number of units/shares that must be purchased.
    /// </summary>
    [IsoId("_ScWEotp-Ed-ak6NoX_4Aeg_842059654")]
    [DisplayName("Minimum Subsequent Subscription Units")]
    [IsoXmlTag("MinSbsqntSbcptUnits")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MinimumSubsequentSubscriptionUnits { get; init; }

    /// <summary>
    /// Maximum quantity of securities, expressed as an amount that can be sold.
    /// </summary>
    [IsoId("_ScWEo9p-Ed-ak6NoX_4Aeg_842059746")]
    [DisplayName("Maximum Redemption Amount")]
    [IsoXmlTag("MaxRedAmt")]
    public ActiveCurrencyAndAmount? MaximumRedemptionAmount { get; init; }

    /// <summary>
    /// Maximum number of shares/units that may be redeemed on a single dealing day.
    /// </summary>
    [IsoId("_ScWEpNp-Ed-ak6NoX_4Aeg_842059807")]
    [DisplayName("Maximum Redemption Units")]
    [IsoXmlTag("MaxRedUnits")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumRedemptionUnits { get; init; }

    /// <summary>
    /// Specifies any other restrictions that may limit an investor&apos;s ability to redeem.
    /// </summary>
    [IsoId("_ScWEpdp-Ed-ak6NoX_4Aeg_842059838")]
    [DisplayName("Other Redemption Restrictions")]
    [IsoXmlTag("OthrRedRstrctns")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? OtherRedemptionRestrictions { get; init; }

    /// <summary>
    /// Minimum value of units that must be maintained to avoid automatic redemption.
    /// </summary>
    [IsoId("_ScWEptp-Ed-ak6NoX_4Aeg_842059868")]
    [DisplayName("Minimum Holding Amount")]
    [IsoXmlTag("MinHldgAmt")]
    public ActiveCurrencyAndAmount? MinimumHoldingAmount { get; init; }

    /// <summary>
    /// Minimum number of units that must be maintained to avoid automatic redemption.
    /// </summary>
    [IsoId("_ScWEp9p-Ed-ak6NoX_4Aeg_842060116")]
    [DisplayName("Minimum Holding Units")]
    [IsoXmlTag("MinHldgUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? MinimumHoldingUnits { get; init; }

    /// <summary>
    /// Description of a period, that may be a number of days, weeks or descriptive period during which the units/shares must be held following their issue before redemption will be permitted.
    /// </summary>
    [IsoId("_ScWEqNp-Ed-ak6NoX_4Aeg_842060146")]
    [DisplayName("Minimum Holding Period")]
    [IsoXmlTag("MinHldgPrd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? MinimumHoldingPeriod { get; init; }

    /// <summary>
    /// Indicates whether registered investors are able to transfer some or all of their holdings to third parties.
    /// </summary>
    [IsoId("_ScWEqdp-Ed-ak6NoX_4Aeg_842060177")]
    [DisplayName("Holding Transferable")]
    [IsoXmlTag("HldgTrfbl")]
    public required HoldingTransferable1Code HoldingTransferable { get; init; }
}
