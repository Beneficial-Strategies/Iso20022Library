// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Processing characteristics linked to a switch order for an investment fund or alternative/hedge fund.
/// </summary>
[IsoId("_jUZEwV84Eeicg40_9gK9vQ")]
[DisplayName("Processing Characteristics")]
public partial record ProcessingCharacteristics6
{
    #nullable enable
    
    /// <summary>
    /// Currency in which a switch is accepted.
    /// </summary>
    [IsoId("_jk5l9V84Eeicg40_9gK9vQ")]
    [DisplayName("Dealing Currency Accepted")]
    [IsoXmlTag("DealgCcyAccptd")]
    public ActiveCurrencyCode? DealingCurrencyAccepted { get; init; } 
    
    /// <summary>
    /// Specifies whether an application form is required for a switch.
    /// </summary>
    [IsoId("_jk5l9184Eeicg40_9gK9vQ")]
    [DisplayName("Switch Authorisation")]
    [IsoXmlTag("SwtchAuthstn")]
    public Forms1? SwitchAuthorisation { get; init; } 
    
    /// <summary>
    /// Indicates whether a switch can be instructed by amount.
    /// </summary>
    [IsoId("_jk5l-V84Eeicg40_9gK9vQ")]
    [DisplayName("Amount Indicator")]
    [IsoXmlTag("AmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AmountIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether a switch can be instructed as a number of units.
    /// </summary>
    [IsoId("_jk5l-184Eeicg40_9gK9vQ")]
    [DisplayName("Units Indicator")]
    [IsoXmlTag("UnitsInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? UnitsIndicator { get; init; } 
    
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_fTxzYV9WEeicg40_9gK9vQ")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; } 
    
    /// <summary>
    /// Location of the main fund order desk.
    /// </summary>
    [IsoId("_jk5l_V84Eeicg40_9gK9vQ")]
    [DisplayName("Main Fund Order Desk Location")]
    [IsoXmlTag("MainFndOrdrDskLctn")]
    public MainFundOrderDeskLocation1? MainFundOrderDeskLocation { get; init; } 
    
    /// <summary>
    /// Frequency at which the switches are done.
    /// </summary>
    [IsoId("_jk5l_184Eeicg40_9gK9vQ")]
    [DisplayName("Dealing Frequency")]
    [IsoXmlTag("DealgFrqcy")]
    public EventFrequency5Code? DealingFrequency { get; init; } 
    
    /// <summary>
    /// Description of frequency at which the switch is done.
    /// </summary>
    [IsoId("_jk5mAV84Eeicg40_9gK9vQ")]
    [DisplayName("Dealing Frequency Description")]
    [IsoXmlTag("DealgFrqcyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? DealingFrequencyDescription { get; init; } 
    
    /// <summary>
    /// Latest time at which an order to switch can be given.
    /// </summary>
    [IsoId("_jk5mA184Eeicg40_9gK9vQ")]
    [DisplayName("Dealing Cut Off Time")]
    [IsoXmlTag("DealgCutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? DealingCutOffTime { get; init; } 
    
    /// <summary>
    /// Dealing cut-off timeframe.
    /// </summary>
    [IsoId("_jk5mBV84Eeicg40_9gK9vQ")]
    [DisplayName("Dealing Cut Off Time Frame")]
    [IsoXmlTag("DealgCutOffTmFrame")]
    public TimeFrame4? DealingCutOffTimeFrame { get; init; } 
    
    /// <summary>
    /// Time at which the deal confirmation is issued.
    /// </summary>
    [IsoId("_jk5mB184Eeicg40_9gK9vQ")]
    [DisplayName("Deal Confirmation Time")]
    [IsoXmlTag("DealConfTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? DealConfirmationTime { get; init; } 
    
    /// <summary>
    /// Time frame within which the deal confirmation is issued.
    /// </summary>
    [IsoId("_jk5mCV84Eeicg40_9gK9vQ")]
    [DisplayName("Deal Confirmation Time Frame")]
    [IsoXmlTag("DealConfTmFrame")]
    public TimeFrame5? DealConfirmationTimeFrame { get; init; } 
    
    /// <summary>
    /// Specific period, for example, for some guaranteed funds, during which the units/shares may be switched.
    /// </summary>
    [IsoId("_jk5mC184Eeicg40_9gK9vQ")]
    [DisplayName("Limited Period")]
    [IsoXmlTag("LtdPrd")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? LimitedPeriod { get; init; } 
    
    /// <summary>
    /// Settlement timing.
    /// </summary>
    [IsoId("_jk5mDV84Eeicg40_9gK9vQ")]
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    public TimeFrame8Choice_? SettlementCycle { get; init; } 
    
    /// <summary>
    /// Additional information about the switch processing characteristics.
    /// </summary>
    [IsoId("_mNfQYWAKEeiNMJ262H2pWg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
