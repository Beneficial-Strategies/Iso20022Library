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
[IsoId("_6vFC0TgCEei6RvewLQWEqw")]
[DisplayName("Time Frame")]
public partial record TimeFrame4
{
    #nullable enable
    
    /// <summary>
    /// Description of the timeframe.
    /// </summary>
    [IsoId("_6-2kNTgCEei6RvewLQWEqw")]
    [DisplayName("Other Time Frame Description")]
    [IsoXmlTag("OthrTmFrameDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? OtherTimeFrameDescription { get; init; } 
    
    /// <summary>
    /// Number of days before the trade date (T) used for the standard timeframe for the dealing cut-off.
    /// </summary>
    [IsoId("_6-2kNzgCEei6RvewLQWEqw")]
    [DisplayName("Trade Minus")]
    [IsoXmlTag("TMns")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TradeMinus { get; init; } 
    
    /// <summary>
    /// Convention used for adjusting a date when it is not a business day.
    /// </summary>
    [IsoId("_6-2kOTgCEei6RvewLQWEqw")]
    [DisplayName("Non Working Day Adjustment")]
    [IsoXmlTag("NonWorkgDayAdjstmnt")]
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; init; } 
    
    /// <summary>
    /// For the dealing cut-off time, the order desk must be contacted.
    /// </summary>
    [IsoId("_6-2kOzgCEei6RvewLQWEqw")]
    [DisplayName("Refer To Order Desk")]
    [IsoXmlTag("RefrToOrdrDsk")]
    public ReferToFundOrderDesk1Code? ReferToOrderDesk { get; init; } 
    
    
    #nullable disable
    
}
