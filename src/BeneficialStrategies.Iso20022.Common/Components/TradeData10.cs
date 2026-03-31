// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status of a trade.
/// </summary>
[IsoId("_wUKTwR3dEeKXIbeXfdPzuw")]
[DisplayName("Trade Data")]
public record TradeData10
{
    /// <summary>
    /// Identification of the present message assigned by the party issuing the message. This identification must be unique amongst all messages of same type sent by the same party.
    /// </summary>
    [IsoId("_AT_YVzqMEeKXK8qRvydwAw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Party that assigned the status to the foreign exchange trade.
    /// </summary>
    [IsoId("_wir39R3dEeKXIbeXfdPzuw")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusOriginator { get; init; }

    /// <summary>
    /// Specifies the new status of the trade.
    /// </summary>
    [IsoId("_wir3-R3dEeKXIbeXfdPzuw")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required StatusAndSubStatus1 CurrentStatus { get; init; }

    /// <summary>
    /// Additional information about the current status of the trade.
    /// </summary>
    [IsoId("_wir3_R3dEeKXIbeXfdPzuw")]
    [DisplayName("Current Status Sub Type")]
    [IsoXmlTag("CurStsSubTp")]
    public StatusSubType1Code? CurrentStatusSubType { get; init; }

    /// <summary>
    /// Specifies the date and time at which the current status was assigned to all the trades, unless overwritten by a date and time assigned to an individual trade.
    /// </summary>
    [IsoId("_wir4AR3dEeKXIbeXfdPzuw")]
    [DisplayName("Current Status Date Time")]
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CurrentStatusDateTime { get; init; }

    /// <summary>
    /// Specifies the previous status of a trade.
    /// </summary>
    [IsoId("_wir4BR3dEeKXIbeXfdPzuw")]
    [DisplayName("Previous Status")]
    [IsoXmlTag("PrvsSts")]
    public Status5Choice_? PreviousStatus { get; init; }

    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_wir4CR3dEeKXIbeXfdPzuw")]
    [DisplayName("Previous Status Sub Type")]
    [IsoXmlTag("PrvsStsSubTp")]
    public StatusSubType1Code? PreviousStatusSubType { get; init; }

    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported, unless overwritten by a product type assigned to an individual trade.
    /// </summary>
    [IsoId("_wir4DR3dEeKXIbeXfdPzuw")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProductType { get; init; }
}
