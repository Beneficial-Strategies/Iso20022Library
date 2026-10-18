// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Data45.
/// </summary>
[IsoId("_j-xs4UjtEe-KhcStGV4xTg")]
[DisplayName("Trade Data45")]
public record TradeData45
{
    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required Max35Text MessageIdentification { get; init; }

    /// <summary>
    /// Status Originator.
    /// </summary>
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    public Max35Text? StatusOriginator { get; init; }

    /// <summary>
    /// Current Status.
    /// </summary>
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required StatusAndSubStatus2 CurrentStatus { get; init; }

    /// <summary>
    /// Current Status Sub Type.
    /// </summary>
    [DisplayName("Current Status Sub Type")]
    [IsoXmlTag("CurStsSubTp")]
    public StatusSubType2Code? CurrentStatusSubType { get; init; }

    /// <summary>
    /// Current Status Date Time.
    /// </summary>
    [DisplayName("Current Status Date Time")]
    [IsoXmlTag("CurStsDtTm")]
    public required ISODateTime CurrentStatusDateTime { get; init; }

    /// <summary>
    /// Previous Status.
    /// </summary>
    [DisplayName("Previous Status")]
    [IsoXmlTag("PrvsSts")]
    public Status28Choice_? PreviousStatus { get; init; }

    /// <summary>
    /// Previous Status Sub Type.
    /// </summary>
    [DisplayName("Previous Status Sub Type")]
    [IsoXmlTag("PrvsStsSubTp")]
    public StatusSubType2Code? PreviousStatusSubType { get; init; }

    /// <summary>
    /// Product Type.
    /// </summary>
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    public Max35Text? ProductType { get; init; }

    /// <summary>
    /// Settlement Session Identifier.
    /// </summary>
    [DisplayName("Settlement Session Identifier")]
    [IsoXmlTag("SttlmSsnIdr")]
    public Exact4AlphaNumericText? SettlementSessionIdentifier { get; init; }
}
