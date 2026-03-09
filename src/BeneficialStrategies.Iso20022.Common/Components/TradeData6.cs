// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status of a trade.
/// </summary>
[IsoId("_SvDFAAEcEeCQm6a_G2yO_w_-1493991605")]
[DisplayName("Trade Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeData6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeData6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeData6( System.String reqNotificationIdentification,System.String reqMatchingSystemUniqueReference,Status6Choice_ reqCurrentStatus )
    {
        NotificationIdentification = reqNotificationIdentification;
        MatchingSystemUniqueReference = reqMatchingSystemUniqueReference;
        CurrentStatus = reqCurrentStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the identification of the notification for which the status is given, as assigned by the participant that submitted the foreign exchange or derivative trade.
    /// </summary>
    [IsoId("_SvDFAQEcEeCQm6a_G2yO_w_-1607830671")]
    [DisplayName("Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnId")]
    #endif
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text NotificationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NotificationIdentification { get; init; } 
    #else
    public System.String NotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the unique system identification assigned to the trade by the central matching system.
    /// </summary>
    [IsoId("_SvDFAgEcEeCQm6a_G2yO_w_1803903338")]
    [DisplayName("Matching System Unique Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSysUnqRef")]
    #endif
    [IsoXmlTag("MtchgSysUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MatchingSystemUniqueReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MatchingSystemUniqueReference { get; init; } 
    #else
    public System.String MatchingSystemUniqueReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the unique matching identification assigned to the trade and to the matching trade from the counterparty by the central matching system.
    /// </summary>
    [IsoId("_SvDFAwEcEeCQm6a_G2yO_w_9925212")]
    [DisplayName("Matching System Matching Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSysMtchgRef")]
    #endif
    [IsoXmlTag("MtchgSysMtchgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MatchingSystemMatchingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MatchingSystemMatchingReference { get; init; } 
    #else
    public System.String? MatchingSystemMatchingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party that assigned the status to the foreign exchange or derivative trade.
    /// </summary>
    [IsoId("_SvDFBAEcEeCQm6a_G2yO_w_1690064272")]
    [DisplayName("Status Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsOrgtr")]
    #endif
    [IsoXmlTag("StsOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? StatusOriginator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StatusOriginator { get; init; } 
    #else
    public System.String? StatusOriginator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the new status of a trade.
    /// </summary>
    [IsoId("_SvDFBQEcEeCQm6a_G2yO_w_-994474903")]
    [DisplayName("Current Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurSts")]
    #endif
    [IsoXmlTag("CurSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status6Choice_ CurrentStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status6Choice_ CurrentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status6Choice_ CurrentStatus { get; init; } 
    #else
    public Status6Choice_ CurrentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on the current status of a trade in a central system.
    /// </summary>
    [IsoId("_SvDFBgEcEeCQm6a_G2yO_w_-1991547256")]
    [DisplayName("Current Status Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurStsSubTp")]
    #endif
    [IsoXmlTag("CurStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CurrentStatusSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CurrentStatusSubType { get; init; } 
    #else
    public System.String? CurrentStatusSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date and time at which the current status was assigned.
    /// </summary>
    [IsoId("_SvDFBwEcEeCQm6a_G2yO_w_1306347687")]
    [DisplayName("Current Status Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurStsDtTm")]
    #endif
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? CurrentStatusDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? CurrentStatusDateTime { get; init; } 
    #else
    public System.DateTime? CurrentStatusDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the previous status of a trade.
    /// </summary>
    [IsoId("_SvDFCAEcEeCQm6a_G2yO_w_309275334")]
    [DisplayName("Previous Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsSts")]
    #endif
    [IsoXmlTag("PrvsSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Status6Choice_? PreviousStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status6Choice_? PreviousStatus { get; init; } 
    #else
    public Status6Choice_? PreviousStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_SvDFCQEcEeCQm6a_G2yO_w_-1684869372")]
    [DisplayName("Previous Status Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsStsSubTp")]
    #endif
    [IsoXmlTag("PrvsStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? PreviousStatusSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreviousStatusSubType { get; init; } 
    #else
    public System.String? PreviousStatusSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date and time at which the previous status was assigned.
    /// </summary>
    [IsoId("_SvDFCgEcEeCQm6a_G2yO_w_1613025571")]
    [DisplayName("Previous Status Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsStsDtTm")]
    #endif
    [IsoXmlTag("PrvsStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? PreviousStatusDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? PreviousStatusDateTime { get; init; } 
    #else
    public System.DateTime? PreviousStatusDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported.
    /// </summary>
    [IsoId("_SvDFCwEcEeCQm6a_G2yO_w_615953218")]
    [DisplayName("Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctTp")]
    #endif
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductType { get; init; } 
    #else
    public System.String? ProductType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
