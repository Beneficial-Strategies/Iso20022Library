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
[IsoId("_UBFN1Np-Ed-ak6NoX_4Aeg_1281373754")]
[DisplayName("Processing Characteristics")]
public record ProcessingCharacteristics2
{
    /// <summary>
    /// Currency in which a subscription or redemption is accepted.
    /// </summary>
    [IsoId("_UBFN1dp-Ed-ak6NoX_4Aeg_462420073")]
    [DisplayName("Dealing Currency Accepted")]
    [IsoXmlTag("DealgCcyAccptd")]
    public SimpleValueList<string> DealingCurrencyAccepted { get; init; } = [];

    // ID for the above is _UBFN1dp-Ed-ak6NoX_4Aeg_462420073

    /// <summary>
    /// Minimum initial quantity of securities, expressed as an amount that must be purchased at subscription.
    /// </summary>
    [IsoId("_UBFN1tp-Ed-ak6NoX_4Aeg_-1044327809")]
    [DisplayName("Initial Investment")]
    [IsoXmlTag("InitlInvstmt")]
    public required Forms InitialInvestment { get; init; }

    /// <summary>
    /// Minimum quantity of securities, expressed as number of units/shares that must be purchased.
    /// </summary>
    [IsoId("_UBFN19p-Ed-ak6NoX_4Aeg_-1790398090")]
    [DisplayName("Subsequent Investment")]
    [IsoXmlTag("SbsqntInvstmt")]
    public required Forms SubsequentInvestment { get; init; }

    /// <summary>
    /// Indicates whether a subscription or a redemption can be instructed by amount.
    /// </summary>
    [IsoId("_UBFN2Np-Ed-ak6NoX_4Aeg_1459492426")]
    [DisplayName("Amount Indicator")]
    [IsoXmlTag("AmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AmountIndicator { get; init; }

    /// <summary>
    /// Indicates whether subscriptions or redemptions may be placed as a number of units.
    /// </summary>
    [IsoId("_UBFN2dp-Ed-ak6NoX_4Aeg_1345653360")]
    [DisplayName("Units Indicator")]
    [IsoXmlTag("UnitsInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator UnitsIndicator { get; init; }

    /// <summary>
    /// Specifies the location of the main fund order desk.
    /// </summary>
    [IsoId("_UBFN2tp-Ed-ak6NoX_4Aeg_-483429979")]
    [DisplayName("Main Fund Order Desk Location")]
    [IsoXmlTag("MainFndOrdrDskLctn")]
    public required MainFundOrderDeskLocation1 MainFundOrderDeskLocation { get; init; }

    /// <summary>
    /// Last date/time at which an order to subscribe or redeem can be given.
    /// </summary>
    [IsoId("_UBOXwNp-Ed-ak6NoX_4Aeg_-534652280")]
    [DisplayName("Dealing Cut Off Time")]
    [IsoXmlTag("DealgCutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime DealingCutOffTime { get; init; }

    /// <summary>
    /// TimeFrame or period concept that allows definition of a period as number of days before or after a defined activity.
    /// </summary>
    [IsoId("_UBOXwdp-Ed-ak6NoX_4Aeg_-648491346")]
    [DisplayName("Dealing Cut Off Time Frame")]
    [IsoXmlTag("DealgCutOffTmFrame")]
    public required TimeFrame3 DealingCutOffTimeFrame { get; init; }

    /// <summary>
    /// Frequency at which the subscriptions are done.
    /// </summary>
    [IsoId("_UBOXwtp-Ed-ak6NoX_4Aeg_689276219")]
    [DisplayName("Dealing Frequency")]
    [IsoXmlTag("DealgFrqcy")]
    public required EventFrequency5Code DealingFrequency { get; init; }

    /// <summary>
    /// Description of frequency at which the subscription is done.
    /// </summary>
    [IsoId("_UBOXw9p-Ed-ak6NoX_4Aeg_689276281")]
    [DisplayName("Dealing Frequency Description")]
    [IsoXmlTag("DealgFrqcyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text DealingFrequencyDescription { get; init; }

    /// <summary>
    /// Specific period, eg, for some guaranteed funds, during which the units/shares may be redeemed.
    /// </summary>
    [IsoId("_UBOXxNp-Ed-ak6NoX_4Aeg_689276403")]
    [DisplayName("Limited Period")]
    [IsoXmlTag("LtdPrd")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? LimitedPeriod { get; init; }

    /// <summary>
    /// Enter the last business day following the day on which a subscription order is priced (T) by which settlement will be due
    /// for orders placed with the main Fund Order Desk, eg. T+3. Enter &quot;P&quot; (pre-payment) if cleared funds may be required before a
    /// subscription order can be executed.
    /// </summary>
    [IsoId("_UBOXxdp-Ed-ak6NoX_4Aeg_-1709843305")]
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    public required TimeFrame5Choice_ SettlementCycle { get; init; }
}
