// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Processing Characteristics11.
/// </summary>
[IsoId("_S5lHgTdyEe6UObU50fB8Cw")]
[DisplayName("Processing Characteristics11")]
public record ProcessingCharacteristics11
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Amount Indicator.
    /// </summary>
    [DisplayName("Amount Indicator")]
    [IsoXmlTag("AmtInd")]
    public IsoYesNoIndicator? AmountIndicator { get; init; }

    /// <summary>
    /// Deal Confirmation Time.
    /// </summary>
    [DisplayName("Deal Confirmation Time")]
    [IsoXmlTag("DealConfTm")]
    public IsoISOTime? DealConfirmationTime { get; init; }

    /// <summary>
    /// Deal Confirmation Time Frame.
    /// </summary>
    [DisplayName("Deal Confirmation Time Frame")]
    [IsoXmlTag("DealConfTmFrame")]
    public TimeFrame11? DealConfirmationTimeFrame { get; init; }

    /// <summary>
    /// Dealing Currency Accepted.
    /// </summary>
    [DisplayName("Dealing Currency Accepted")]
    [IsoXmlTag("DealgCcyAccptd")]
    public ValueList<ActiveCurrencyCode> DealingCurrencyAccepted { get; init; } = [];

    /// <summary>
    /// Dealing Cut Off Time.
    /// </summary>
    [DisplayName("Dealing Cut Off Time")]
    [IsoXmlTag("DealgCutOffTm")]
    public IsoISOTime? DealingCutOffTime { get; init; }

    /// <summary>
    /// Dealing Cut Off Time Frame.
    /// </summary>
    [DisplayName("Dealing Cut Off Time Frame")]
    [IsoXmlTag("DealgCutOffTmFrame")]
    public TimeFrame9? DealingCutOffTimeFrame { get; init; }

    /// <summary>
    /// Dealing Frequency.
    /// </summary>
    [DisplayName("Dealing Frequency")]
    [IsoXmlTag("DealgFrqcy")]
    public EventFrequency5Code? DealingFrequency { get; init; }

    /// <summary>
    /// Dealing Frequency Description.
    /// </summary>
    [DisplayName("Dealing Frequency Description")]
    [IsoXmlTag("DealgFrqcyDesc")]
    public IsoMax350Text? DealingFrequencyDescription { get; init; }

    /// <summary>
    /// Initial Investment Application.
    /// </summary>
    [DisplayName("Initial Investment Application")]
    [IsoXmlTag("InitlInvstmtAppl")]
    public Forms1? InitialInvestmentApplication { get; init; }

    /// <summary>
    /// Limited Period.
    /// </summary>
    [DisplayName("Limited Period")]
    [IsoXmlTag("LtdPrd")]
    public IsoMax350Text? LimitedPeriod { get; init; }

    /// <summary>
    /// Main Fund Order Desk Location.
    /// </summary>
    [DisplayName("Main Fund Order Desk Location")]
    [IsoXmlTag("MainFndOrdrDskLctn")]
    public MainFundOrderDeskLocation1? MainFundOrderDeskLocation { get; init; }

    /// <summary>
    /// Rounding.
    /// </summary>
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Settlement Cycle.
    /// </summary>
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    public TimeFrame7Choice_? SettlementCycle { get; init; }

    /// <summary>
    /// Subsequent Investment Application.
    /// </summary>
    [DisplayName("Subsequent Investment Application")]
    [IsoXmlTag("SbsqntInvstmtAppl")]
    public Forms1? SubsequentInvestmentApplication { get; init; }

    /// <summary>
    /// Units Indicator.
    /// </summary>
    [DisplayName("Units Indicator")]
    [IsoXmlTag("UnitsInd")]
    public IsoYesNoIndicator? UnitsIndicator { get; init; }
}
