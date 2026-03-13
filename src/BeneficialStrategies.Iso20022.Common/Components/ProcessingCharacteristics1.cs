// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Processing characteristics linked to the instrument, ie, not to the market.
/// </summary>
[IsoId("_UBrDs9p-Ed-ak6NoX_4Aeg_651074944")]
[DisplayName("Processing Characteristics")]
public partial record ProcessingCharacteristics1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether a subscription or a redemption can be instructed by amount.
    /// </summary>
    [IsoId("_UBrDtNp-Ed-ak6NoX_4Aeg_1742686060")]
    [DisplayName("Amount Indicator")]
    [IsoXmlTag("AmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AmountIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether subscriptions or redemptions may be placed as a number of units.
    /// </summary>
    [IsoId("_UBrDtdp-Ed-ak6NoX_4Aeg_1448711749")]
    [DisplayName("Units Indicator")]
    [IsoXmlTag("UnitsInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator UnitsIndicator { get; init; } 
    
    /// <summary>
    /// Currency in which a subscription or redemption is accepted.
    /// </summary>
    [IsoId("_UBrDttp-Ed-ak6NoX_4Aeg_1655381109")]
    [DisplayName("Dealing Currency Accepted")]
    [IsoXmlTag("DealgCcyAccptd")]
    public SimpleValueList<string> DealingCurrencyAccepted { get; init; } = [];
    // ID for the above is _UBrDttp-Ed-ak6NoX_4Aeg_1655381109
    
    /// <summary>
    /// Last date/time at which an order to subscribe or redeem can be given.
    /// </summary>
    [IsoId("_UBrDt9p-Ed-ak6NoX_4Aeg_1609988215")]
    [DisplayName("Dealing Cut Off Time")]
    [IsoXmlTag("DealgCutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime DealingCutOffTime { get; init; } 
    
    /// <summary>
    /// TimeFrame or period concept that allows definition of a period as number of days before or after a defined activity.
    /// </summary>
    [IsoId("_UBrDuNp-Ed-ak6NoX_4Aeg_-189448505")]
    [DisplayName("Dealing Cut Off Time Frame")]
    [IsoXmlTag("DealgCutOffTmFrame")]
    public required TimeFrame3Choice_ DealingCutOffTimeFrame { get; init; } 
    
    /// <summary>
    /// An agreed number of days after the Trade date (T) used to define standard timeframes e.g T+3 settlement period ||Where T = the date the price is applied to a transaction.
    /// </summary>
    [IsoId("_UB00sNp-Ed-ak6NoX_4Aeg_-1103139328")]
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    public required Timeframe2Choice_ SettlementCycle { get; init; } 
    
    
    #nullable disable
    
}
