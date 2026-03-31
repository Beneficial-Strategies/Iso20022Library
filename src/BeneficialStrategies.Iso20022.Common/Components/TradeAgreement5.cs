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
[IsoId("_S8KUAQEcEeCQm6a_G2yO_w_1878007297")]
[DisplayName("Trade Agreement")]
public record TradeAgreement5
{
    /// <summary>
    /// Date on which the trading parties agree on the trade.
    /// </summary>
    [IsoId("_S8KUAgEcEeCQm6a_G2yO_w_1764168231")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; }

    /// <summary>
    /// Reference to the identification of the notification for which the status is given, as assigned by the participant that submitted the foreign exchange trade.
    /// </summary>
    [IsoId("_S8KUAwEcEeCQm6a_G2yO_w_880934944")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text NotificationIdentification { get; init; }

    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    [IsoId("_S8UE8AEcEeCQm6a_G2yO_w_767095878")]
    [DisplayName("Common Reference")]
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommonReference { get; init; }

    /// <summary>
    /// Specifies the reason for the cancellation or the amendment.
    /// </summary>
    [IsoId("_S8UE8QEcEeCQm6a_G2yO_w_-229976475")]
    [DisplayName("Amend Or Cancel Reason")]
    [IsoXmlTag("AmdOrCclRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AmendOrCancelReason { get; init; }

    /// <summary>
    /// Reference to the identification of a previous event in the life of a trade which is amended or cancelled.
    /// </summary>
    [IsoId("_S8UE8gEcEeCQm6a_G2yO_w_-1227048828")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RelatedReference { get; init; }

    /// <summary>
    /// Specifies the type of underlying transaction, for example, option.
    /// </summary>
    [IsoId("_S8UE8wEcEeCQm6a_G2yO_w_-2110282115")]
    [DisplayName("Operation Type")]
    [IsoXmlTag("OprTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? OperationType { get; init; }

    /// <summary>
    /// Specifies the business role between the submitter and the trade party, for example, agent (AGNT).
    /// </summary>
    [IsoId("_S8UE9AEcEeCQm6a_G2yO_w_1187612828")]
    [DisplayName("Operation Scope")]
    [IsoXmlTag("OprScp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? OperationScope { get; init; }
}
