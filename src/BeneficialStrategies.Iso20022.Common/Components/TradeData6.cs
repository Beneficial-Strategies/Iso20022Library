// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status of a trade.
/// </summary>
[IsoId("_SvDFAAEcEeCQm6a_G2yO_w_-1493991605")]
[DisplayName("Trade Data")]
public partial record TradeData6
{
    #nullable enable
    
    /// <summary>
    /// Reference to the identification of the notification for which the status is given, as assigned by the participant that submitted the foreign exchange or derivative trade.
    /// </summary>
    [IsoId("_SvDFAQEcEeCQm6a_G2yO_w_-1607830671")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text NotificationIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the unique system identification assigned to the trade by the central matching system.
    /// </summary>
    [IsoId("_SvDFAgEcEeCQm6a_G2yO_w_1803903338")]
    [DisplayName("Matching System Unique Reference")]
    [IsoXmlTag("MtchgSysUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; } 
    
    /// <summary>
    /// Reference to the unique matching identification assigned to the trade and to the matching trade from the counterparty by the central matching system.
    /// </summary>
    [IsoId("_SvDFAwEcEeCQm6a_G2yO_w_9925212")]
    [DisplayName("Matching System Matching Reference")]
    [IsoXmlTag("MtchgSysMtchgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MatchingSystemMatchingReference { get; init; } 
    
    /// <summary>
    /// Party that assigned the status to the foreign exchange or derivative trade.
    /// </summary>
    [IsoId("_SvDFBAEcEeCQm6a_G2yO_w_1690064272")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? StatusOriginator { get; init; } 
    
    /// <summary>
    /// Specifies the new status of a trade.
    /// </summary>
    [IsoId("_SvDFBQEcEeCQm6a_G2yO_w_-994474903")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required Status6Choice_ CurrentStatus { get; init; } 
    
    /// <summary>
    /// Additional information on the current status of a trade in a central system.
    /// </summary>
    [IsoId("_SvDFBgEcEeCQm6a_G2yO_w_-1991547256")]
    [DisplayName("Current Status Sub Type")]
    [IsoXmlTag("CurStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? CurrentStatusSubType { get; init; } 
    
    /// <summary>
    /// Specifies the date and time at which the current status was assigned.
    /// </summary>
    [IsoId("_SvDFBwEcEeCQm6a_G2yO_w_1306347687")]
    [DisplayName("Current Status Date Time")]
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CurrentStatusDateTime { get; init; } 
    
    /// <summary>
    /// Specifies the previous status of a trade.
    /// </summary>
    [IsoId("_SvDFCAEcEeCQm6a_G2yO_w_309275334")]
    [DisplayName("Previous Status")]
    [IsoXmlTag("PrvsSts")]
    public Status6Choice_? PreviousStatus { get; init; } 
    
    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_SvDFCQEcEeCQm6a_G2yO_w_-1684869372")]
    [DisplayName("Previous Status Sub Type")]
    [IsoXmlTag("PrvsStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? PreviousStatusSubType { get; init; } 
    
    /// <summary>
    /// Specifies the date and time at which the previous status was assigned.
    /// </summary>
    [IsoId("_SvDFCgEcEeCQm6a_G2yO_w_1613025571")]
    [DisplayName("Previous Status Date Time")]
    [IsoXmlTag("PrvsStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? PreviousStatusDateTime { get; init; } 
    
    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported.
    /// </summary>
    [IsoId("_SvDFCwEcEeCQm6a_G2yO_w_615953218")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProductType { get; init; } 
    
    
    #nullable disable
    
}
