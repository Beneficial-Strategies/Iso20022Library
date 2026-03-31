// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and identification of a trade together with references to previous events in its life.
/// </summary>
[IsoId("_TJ8xhdp-Ed-ak6NoX_4Aeg_-401775147")]
[DisplayName("Trade Agreement")]
public record TradeAgreement2
{
    /// <summary>
    /// Date at which the trading parties have agreed to amend or cancel a treasury trade.
    /// </summary>
    [IsoId("_TJ8xhtp-Ed-ak6NoX_4Aeg_-362065219")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; }

    /// <summary>
    /// Identification of a notification.This identification must be unique amongst all notifications of same type confirmed by the same party.
    /// </summary>
    [IsoId("_TJ8xh9p-Ed-ak6NoX_4Aeg_1654091950")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text NotificationIdentification { get; init; }

    /// <summary>
    /// Reference common to the parties of a trade.
    /// </summary>
    [IsoId("_TJ8xiNp-Ed-ak6NoX_4Aeg_-362065176")]
    [DisplayName("Common Reference")]
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommonReference { get; init; }

    /// <summary>
    /// Describes the reason for the cancellation or the amendment.
    /// </summary>
    [IsoId("_TKF7cNp-Ed-ak6NoX_4Aeg_-1351420444")]
    [DisplayName("Amend Or Cancel Reason")]
    [IsoXmlTag("AmdOrCclRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AmendOrCancelReason { get; init; }

    /// <summary>
    /// Refers to the identification of a previous event in the life of a trade which is amended or cancelled.
    /// </summary>
    [IsoId("_TKF7cdp-Ed-ak6NoX_4Aeg_2091136378")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RelatedReference { get; init; }
}
