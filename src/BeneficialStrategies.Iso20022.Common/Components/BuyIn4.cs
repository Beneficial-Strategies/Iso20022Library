// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies elements related to the notification (or warn) sent by the central counterparty to the clearing member in the context of the buy in process.
/// </summary>
[IsoId("_7xh9US9WEeS94oXWDaBauA")]
[DisplayName("Buy In")]
public record BuyIn4
{
    /// <summary>
    /// Indicates whether the message is a warning only or a notification.
    /// </summary>
    [IsoId("_8D9KES9WEeS94oXWDaBauA")]
    [DisplayName("Warning Indicator")]
    [IsoXmlTag("WrngInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WarningIndicator { get; init; }

    /// <summary>
    /// Provides the date at which the buy-in will occur.
    /// </summary>
    [IsoId("_8D9KEy9WEeS94oXWDaBauA")]
    [DisplayName("Expected Buy In Date")]
    [IsoXmlTag("XpctdBuyInDt")]
    public required DateFormat15Choice_ ExpectedBuyInDate { get; init; }

    /// <summary>
    /// Identifies the latest date by which the buy-in operation can be cancelled.
    /// </summary>
    [IsoId("_VXBUUC9YEeS94oXWDaBauA")]
    [DisplayName("Cancellation Limit Date")]
    [IsoXmlTag("CxlLmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CancellationLimitDate { get; init; }

    /// <summary>
    /// Identifies the date by which the buy-in operation is reversed by the CCP.
    /// </summary>
    [IsoId("_T7O2UC9ZEeS94oXWDaBauA")]
    [DisplayName("Buy In Reversion Date")]
    [IsoXmlTag("BuyInRvrsnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BuyInReversionDate { get; init; }
}
