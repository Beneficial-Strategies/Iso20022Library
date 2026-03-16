// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Time Frame11.
/// </summary>
[IsoId("_8mTdQTdyEe6UObU50fB8Cw")]
[DisplayName("Time Frame11")]
public record TimeFrame11
{
    /// <summary>
    /// Non Working Day Adjustment.
    /// </summary>
    [DisplayName("Non Working Day Adjustment")]
    [IsoXmlTag("NonWorkgDayAdjstmnt")]
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; init; }

    /// <summary>
    /// Other Time Frame Description.
    /// </summary>
    [DisplayName("Other Time Frame Description")]
    [IsoXmlTag("OthrTmFrameDesc")]
    public IsoMax350Text? OtherTimeFrameDescription { get; init; }

    /// <summary>
    /// Refer To Order Desk.
    /// </summary>
    [DisplayName("Refer To Order Desk")]
    [IsoXmlTag("RefrToOrdrDsk")]
    public ReferToFundOrderDesk1Code? ReferToOrderDesk { get; init; }

    /// <summary>
    /// Trade Plus.
    /// </summary>
    [DisplayName("Trade Plus")]
    [IsoXmlTag("TPlus")]
    public IsoNumber? TradePlus { get; init; }
}
