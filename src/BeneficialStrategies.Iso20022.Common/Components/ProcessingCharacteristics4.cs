// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Processing characteristics linked to a subscription to an investment fund or alternative/hedge fund.
/// </summary>
[IsoId("_xBKBcTgBEei6RvewLQWEqw")]
[DisplayName("Processing Characteristics")]
public record ProcessingCharacteristics4
{
    /// <summary>
    /// Currency in which a subscription is accepted.
    /// </summary>
    [IsoId("_xRhYtTgBEei6RvewLQWEqw")]
    [DisplayName("Dealing Currency Accepted")]
    [IsoXmlTag("DealgCcyAccptd")]
    public ActiveCurrencyCode? DealingCurrencyAccepted { get; init; }

    /// <summary>
    /// Specifies whether an application form is required for the initial investment.
    /// </summary>
    [IsoId("_xRhYtzgBEei6RvewLQWEqw")]
    [DisplayName("Initial Investment Application")]
    [IsoXmlTag("InitlInvstmtAppl")]
    public Forms1? InitialInvestmentApplication { get; init; }

    /// <summary>
    /// Specifies whether an application form is required for the subsequent investments.
    /// </summary>
    [IsoId("_xRhYuTgBEei6RvewLQWEqw")]
    [DisplayName("Subsequent Investment Application")]
    [IsoXmlTag("SbsqntInvstmtAppl")]
    public Forms1? SubsequentInvestmentApplication { get; init; }

    /// <summary>
    /// Indicates whether a subscription can be instructed by amount.
    /// </summary>
    [IsoId("_xRhYuzgBEei6RvewLQWEqw")]
    [DisplayName("Amount Indicator")]
    [IsoXmlTag("AmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AmountIndicator { get; init; }

    /// <summary>
    /// Indicates whether a subscription can be instructed as a number of units.
    /// </summary>
    [IsoId("_xRhYvTgBEei6RvewLQWEqw")]
    [DisplayName("Units Indicator")]
    [IsoXmlTag("UnitsInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? UnitsIndicator { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_XsZyUV9WEeicg40_9gK9vQ")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Location of the main fund order desk.
    /// </summary>
    [IsoId("_xRhYvzgBEei6RvewLQWEqw")]
    [DisplayName("Main Fund Order Desk Location")]
    [IsoXmlTag("MainFndOrdrDskLctn")]
    public MainFundOrderDeskLocation1? MainFundOrderDeskLocation { get; init; }

    /// <summary>
    /// Frequency at which the subscriptions are done.
    /// </summary>
    [IsoId("_xRqiozgBEei6RvewLQWEqw")]
    [DisplayName("Dealing Frequency")]
    [IsoXmlTag("DealgFrqcy")]
    public EventFrequency5Code? DealingFrequency { get; init; }

    /// <summary>
    /// Description of frequency at which the subscription is done.
    /// </summary>
    [IsoId("_xRqipTgBEei6RvewLQWEqw")]
    [DisplayName("Dealing Frequency Description")]
    [IsoXmlTag("DealgFrqcyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? DealingFrequencyDescription { get; init; }

    /// <summary>
    /// Latest time at which an order to subscribe can be given.
    /// </summary>
    [IsoId("_xRhYwTgBEei6RvewLQWEqw")]
    [DisplayName("Dealing Cut Off Time")]
    [IsoXmlTag("DealgCutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? DealingCutOffTime { get; init; }

    /// <summary>
    /// Dealing cut-off timeframe.
    /// </summary>
    [IsoId("_xRqioTgBEei6RvewLQWEqw")]
    [DisplayName("Dealing Cut Off Time Frame")]
    [IsoXmlTag("DealgCutOffTmFrame")]
    public TimeFrame4? DealingCutOffTimeFrame { get; init; }

    /// <summary>
    /// Time at which the deal confirmation is issued.
    /// </summary>
    [IsoId("_HWCq4F81Eeicg40_9gK9vQ")]
    [DisplayName("Deal Confirmation Time")]
    [IsoXmlTag("DealConfTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? DealConfirmationTime { get; init; }

    /// <summary>
    /// Time frame within which the deal confirmation is issued.
    /// </summary>
    [IsoId("_VcDjUF81Eeicg40_9gK9vQ")]
    [DisplayName("Deal Confirmation Time Frame")]
    [IsoXmlTag("DealConfTmFrame")]
    public TimeFrame5? DealConfirmationTimeFrame { get; init; }

    /// <summary>
    /// Specific period, for example, for some guaranteed funds, during which the units/shares may be subscribed.
    /// </summary>
    [IsoId("_xRqipzgBEei6RvewLQWEqw")]
    [DisplayName("Limited Period")]
    [IsoXmlTag("LtdPrd")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? LimitedPeriod { get; init; }

    /// <summary>
    /// Settlement timing.
    /// </summary>
    [IsoId("_xRqiqTgBEei6RvewLQWEqw")]
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    public TimeFrame7Choice_? SettlementCycle { get; init; }

    /// <summary>
    /// Additional information about the subscription processing characteristics.
    /// </summary>
    [IsoId("_drVpIWAKEeiNMJ262H2pWg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
