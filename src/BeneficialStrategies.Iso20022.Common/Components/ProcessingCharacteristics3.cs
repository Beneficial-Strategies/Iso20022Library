// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Processing characteristics linked to the instrument, ie, not to the market.
/// </summary>
[IsoId("_UAyS7tp-Ed-ak6NoX_4Aeg_-635996021")]
[DisplayName("Processing Characteristics")]
public record ProcessingCharacteristics3
{
    /// <summary>
    /// Currency in which a subscription or redemption is accepted.
    /// </summary>
    [IsoId("_UA7c0Np-Ed-ak6NoX_4Aeg_-749835087")]
    [DisplayName("Dealing Currency Accepted")]
    [IsoXmlTag("DealgCcyAccptd")]
    public SimpleValueList<string> DealingCurrencyAccepted { get; init; } = [];

    // ID for the above is _UA7c0Np-Ed-ak6NoX_4Aeg_-749835087

    /// <summary>
    /// Authorization to claim redemption proceeds.
    /// </summary>
    [IsoId("_UA7c0dp-Ed-ak6NoX_4Aeg_-1746907440")]
    [DisplayName("Redemption Authorisation")]
    [IsoXmlTag("RedAuthstn")]
    public required Forms RedemptionAuthorisation { get; init; }

    /// <summary>
    /// Indicates whether a subscription or a redemption can be instructed by amount.
    /// </summary>
    [IsoId("_UA7c0tp-Ed-ak6NoX_4Aeg_667754216")]
    [DisplayName("Amount Indicator")]
    [IsoXmlTag("AmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AmountIndicator { get; init; }

    /// <summary>
    /// Indicates whether subscriptions or redemptions may be placed as a number of units.
    /// </summary>
    [IsoId("_UA7c09p-Ed-ak6NoX_4Aeg_553915150")]
    [DisplayName("Units Indicator")]
    [IsoXmlTag("UnitsInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator UnitsIndicator { get; init; }

    /// <summary>
    /// Specifies the location of the main fund order desk.
    /// </summary>
    [IsoId("_UA7c1Np-Ed-ak6NoX_4Aeg_-329318137")]
    [DisplayName("Main Fund Order Desk Location")]
    [IsoXmlTag("MainFndOrdrDskLctn")]
    public required MainFundOrderDeskLocation1 MainFundOrderDeskLocation { get; init; }

    /// <summary>
    /// Last date/time at which an order to subscribe or redeem can be given.
    /// </summary>
    [IsoId("_UA7c1dp-Ed-ak6NoX_4Aeg_1315949298")]
    [DisplayName("Dealing Cut Off Time")]
    [IsoXmlTag("DealgCutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime DealingCutOffTime { get; init; }

    /// <summary>
    /// TimeFrame or period concept that allows definition of a period as number of days before or after a defined activity.
    /// </summary>
    [IsoId("_UA7c1tp-Ed-ak6NoX_4Aeg_-1148271818")]
    [DisplayName("Dealing Cut Off Time Frame")]
    [IsoXmlTag("DealgCutOffTmFrame")]
    public required TimeFrame3 DealingCutOffTimeFrame { get; init; }

    /// <summary>
    /// Frequency at which the subscriptions are done.
    /// </summary>
    [IsoId("_UA7c19p-Ed-ak6NoX_4Aeg_-1440229556")]
    [DisplayName("Dealing Frequency")]
    [IsoXmlTag("DealgFrqcy")]
    public required EventFrequency5Code DealingFrequency { get; init; }

    /// <summary>
    /// Description of frequency at which the subscription is done.
    /// </summary>
    [IsoId("_UA7c2Np-Ed-ak6NoX_4Aeg_1971504453")]
    [DisplayName("Dealing Frequency Description")]
    [IsoXmlTag("DealgFrqcyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text DealingFrequencyDescription { get; init; }

    /// <summary>
    /// Specific period, eg, for some guaranteed funds, during which the units/shares may be redeemed.
    /// </summary>
    [IsoId("_UA7c2dp-Ed-ak6NoX_4Aeg_1857665387")]
    [DisplayName("Limited Period")]
    [IsoXmlTag("LtdPrd")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? LimitedPeriod { get; init; }

    /// <summary>
    /// Indicate the last business day following the day on which a redemption order is priced (T) by which settlement will be due
    /// for orders placed with the main Fund Order Desk.&amp;nbsp; Alternatively, if proceeds will be paid following receipt of written
    /// renunciation, indicate the last business day following receipt of the relevant renunciation documentation by the main Fund
    /// Order Desk (R) by which the proceeds will be sent.&amp;nbsp; Examples of the above would be T+3, R+4 etc.
    /// </summary>
    [IsoId("_UBFN0Np-Ed-ak6NoX_4Aeg_1152550772")]
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    public required TimeFrame4Choice_ SettlementCycle { get; init; }
}
