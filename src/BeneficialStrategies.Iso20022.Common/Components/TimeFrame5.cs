// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Time frame elements that define a period as number of days before or after a activity.
/// </summary>
[IsoId("_eJEWwV81Eeicg40_9gK9vQ")]
[DisplayName("Time Frame")]
public partial record TimeFrame5
{
    #nullable enable
    
    /// <summary>
    /// Description of the timeframe.
    /// </summary>
    [IsoId("_eY14JV81Eeicg40_9gK9vQ")]
    [DisplayName("Other Time Frame Description")]
    [IsoXmlTag("OthrTmFrameDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? OtherTimeFrameDescription { get; init; } 
    
    /// <summary>
    /// Number of days after the trade date (T) used for the standard timeframe for the issue of a deal confirmation.
    /// </summary>
    [IsoId("_eY14J181Eeicg40_9gK9vQ")]
    [DisplayName("Trade Plus")]
    [IsoXmlTag("TPlus")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TradePlus { get; init; } 
    
    /// <summary>
    /// Convention used for adjusting a date when it is not a business day.
    /// </summary>
    [IsoId("_eY14KV81Eeicg40_9gK9vQ")]
    [DisplayName("Non Working Day Adjustment")]
    [IsoXmlTag("NonWorkgDayAdjstmnt")]
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; init; } 
    
    /// <summary>
    /// For the time of the issuance of the deal confirmation, the order desk must be contacted.
    /// </summary>
    [IsoId("_eY14K181Eeicg40_9gK9vQ")]
    [DisplayName("Refer To Order Desk")]
    [IsoXmlTag("RefrToOrdrDsk")]
    public ReferToFundOrderDesk1Code? ReferToOrderDesk { get; init; } 
    
    
    #nullable disable
    
}
