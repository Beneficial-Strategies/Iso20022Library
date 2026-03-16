// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Processing characteristics linked to a redemption from an investment fund or alternative/hedge fund.
/// </summary>
[IsoId("_WX6D4ZjvEemFu85t1CYjSw")]
[DisplayName("Processing Characteristics")]
public record ProcessingCharacteristics7
{
    /// <summary>
    /// Currency in which a redemption is accepted.
    /// </summary>
    [IsoId("_Wvak9ZjvEemFu85t1CYjSw")]
    [DisplayName("Dealing Currency Accepted")]
    [IsoXmlTag("DealgCcyAccptd")]
    public ActiveCurrencyCode? DealingCurrencyAccepted { get; init; }

    /// <summary>
    /// Specifies whether an application form is required for a redemption.
    /// </summary>
    [IsoId("_Wvak95jvEemFu85t1CYjSw")]
    [DisplayName("Redemption Authorisation")]
    [IsoXmlTag("RedAuthstn")]
    public Forms1? RedemptionAuthorisation { get; init; }

    /// <summary>
    /// Indicates whether a redemption can be instructed by amount.
    /// </summary>
    [IsoId("_Wvak-ZjvEemFu85t1CYjSw")]
    [DisplayName("Amount Indicator")]
    [IsoXmlTag("AmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AmountIndicator { get; init; }

    /// <summary>
    /// Indicates whether a redemption can be instructed as a number of units.
    /// </summary>
    [IsoId("_Wvak-5jvEemFu85t1CYjSw")]
    [DisplayName("Units Indicator")]
    [IsoXmlTag("UnitsInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? UnitsIndicator { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_Wvak_ZjvEemFu85t1CYjSw")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Indicates whether a redemption can be instructed as a percentage of holding.
    /// </summary>
    [IsoId("_Wvak_5jvEemFu85t1CYjSw")]
    [DisplayName("Percentage Indicator")]
    [IsoXmlTag("PctgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PercentageIndicator { get; init; }

    /// <summary>
    /// Location of the main fund order desk.
    /// </summary>
    [IsoId("_WvalAZjvEemFu85t1CYjSw")]
    [DisplayName("Main Fund Order Desk Location")]
    [IsoXmlTag("MainFndOrdrDskLctn")]
    public MainFundOrderDeskLocation1? MainFundOrderDeskLocation { get; init; }

    /// <summary>
    /// Frequency at which the redemptions are done.
    /// </summary>
    [IsoId("_WvalA5jvEemFu85t1CYjSw")]
    [DisplayName("Dealing Frequency")]
    [IsoXmlTag("DealgFrqcy")]
    public EventFrequency5Code? DealingFrequency { get; init; }

    /// <summary>
    /// Description of frequency at which the redemption is done.
    /// </summary>
    [IsoId("_WvalBZjvEemFu85t1CYjSw")]
    [DisplayName("Dealing Frequency Description")]
    [IsoXmlTag("DealgFrqcyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? DealingFrequencyDescription { get; init; }

    /// <summary>
    /// Latest time at which an order to redeem can be given.
    /// </summary>
    [IsoId("_WvalB5jvEemFu85t1CYjSw")]
    [DisplayName("Dealing Cut Off Time")]
    [IsoXmlTag("DealgCutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? DealingCutOffTime { get; init; }

    /// <summary>
    /// Dealing cut-off timeframe.
    /// </summary>
    [IsoId("_WvalCZjvEemFu85t1CYjSw")]
    [DisplayName("Dealing Cut Off Time Frame")]
    [IsoXmlTag("DealgCutOffTmFrame")]
    public TimeFrame4? DealingCutOffTimeFrame { get; init; }

    /// <summary>
    /// Time at which the deal confirmation is issued.
    /// </summary>
    [IsoId("_WvalC5jvEemFu85t1CYjSw")]
    [DisplayName("Deal Confirmation Time")]
    [IsoXmlTag("DealConfTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? DealConfirmationTime { get; init; }

    /// <summary>
    /// Time frame within which the deal confirmation is issued.
    /// </summary>
    [IsoId("_WvalDZjvEemFu85t1CYjSw")]
    [DisplayName("Deal Confirmation Time Frame")]
    [IsoXmlTag("DealConfTmFrame")]
    public TimeFrame6? DealConfirmationTimeFrame { get; init; }

    /// <summary>
    /// Specific period, for example, for some guaranteed funds, during which the units/shares may be redeemed.
    /// </summary>
    [IsoId("_WvalD5jvEemFu85t1CYjSw")]
    [DisplayName("Limited Period")]
    [IsoXmlTag("LtdPrd")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? LimitedPeriod { get; init; }

    /// <summary>
    /// Settlement timing.
    /// </summary>
    [IsoId("_WvalEZjvEemFu85t1CYjSw")]
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    public TimeFrame8Choice_? SettlementCycle { get; init; }

    /// <summary>
    /// Additional information about the redemption processing characteristics.
    /// </summary>
    [IsoId("_WvalE5jvEemFu85t1CYjSw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
