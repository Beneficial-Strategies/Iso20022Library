// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// TimeFrame elements that define a period as number of days before or after a activity.
/// </summary>
[IsoId("_UAoh4Np-Ed-ak6NoX_4Aeg_-1899090252")]
[DisplayName("Time Frame")]
public partial record TimeFrame3
{
    #nullable enable
    
    /// <summary>
    /// Specifies a description of any other TimeFrame that may be used for the DealingCutOffTimeFrame.
    /// </summary>
    [IsoId("_UAoh4dp-Ed-ak6NoX_4Aeg_-1857530882")]
    [DisplayName("Other Time Frame Description")]
    [IsoXmlTag("OthrTmFrameDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? OtherTimeFrameDescription { get; init; } 
    
    /// <summary>
    /// An agreed number of days before the Trade date (T) used to define standard timeframes e.g. T-1 Dealing cut off or T-2 prepayment condition||Where = T is the date that the price is applied to a transaction.
    /// </summary>
    [IsoId("_UAoh4tp-Ed-ak6NoX_4Aeg_-1899090190")]
    [DisplayName("Trade Minus")]
    [IsoXmlTag("TMns")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TradeMinus { get; init; } 
    
    /// <summary>
    /// Convention used for adjusting a date when it is not a business day.
    /// </summary>
    [IsoId("_UAoh49p-Ed-ak6NoX_4Aeg_1418685838")]
    [DisplayName("Non Working Day Adjustment")]
    [IsoXmlTag("NonWorkgDayAdjstmnt")]
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; init; } 
    
    /// <summary>
    /// Refer to Order Desk.
    /// </summary>
    [IsoId("_UAoh5Np-Ed-ak6NoX_4Aeg_-242360634")]
    [DisplayName("Refer To Order Desk")]
    [IsoXmlTag("RefrToOrdrDsk")]
    public ReferToFundOrderDesk1Code? ReferToOrderDesk { get; init; } 
    
    
    #nullable disable
    
}
