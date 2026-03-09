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
[IsoId("_7KIJAZR3Eeak6e8_Fc5fQg")]
[DisplayName("Trade Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeData12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeData12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeData12( System.String reqMessageIdentification,StatusAndSubStatus2 reqCurrentStatus,System.DateTime reqCurrentStatusDateTime )
    {
        MessageIdentification = reqMessageIdentification;
        CurrentStatus = reqCurrentStatus;
        CurrentStatusDateTime = reqCurrentStatusDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the present message assigned by the party issuing the message. This identification must be unique amongst all messages of same type sent by the same party.
    /// </summary>
    [IsoId("_7WM2I5R3Eeak6e8_Fc5fQg")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageIdentification { get; init; } 
    #else
    public System.String MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that assigned the status to the foreign exchange trade.
    /// </summary>
    [IsoId("_7WM2JZR3Eeak6e8_Fc5fQg")]
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
    /// Specifies the new status of the trade.
    /// </summary>
    [IsoId("_7WM2J5R3Eeak6e8_Fc5fQg")]
    [DisplayName("Current Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurSts")]
    #endif
    [IsoXmlTag("CurSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatusAndSubStatus2 CurrentStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatusAndSubStatus2 CurrentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusAndSubStatus2 CurrentStatus { get; init; } 
    #else
    public StatusAndSubStatus2 CurrentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the current status of the trade.
    /// </summary>
    [IsoId("_7WM2KZR3Eeak6e8_Fc5fQg")]
    [DisplayName("Current Status Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurStsSubTp")]
    #endif
    [IsoXmlTag("CurStsSubTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusSubType2Code? CurrentStatusSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusSubType2Code? CurrentStatusSubType { get; init; } 
    #else
    public StatusSubType2Code? CurrentStatusSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date and time at which the current status was assigned to all the trades, unless overwritten by a date and time assigned to an individual trade.
    /// </summary>
    [IsoId("_7WM2K5R3Eeak6e8_Fc5fQg")]
    [DisplayName("Current Status Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurStsDtTm")]
    #endif
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CurrentStatusDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CurrentStatusDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CurrentStatusDateTime { get; init; } 
    #else
    public System.DateTime CurrentStatusDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the previous status of a trade.
    /// </summary>
    [IsoId("_7WM2LZR3Eeak6e8_Fc5fQg")]
    [DisplayName("Previous Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsSts")]
    #endif
    [IsoXmlTag("PrvsSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Status28Choice_? PreviousStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status28Choice_? PreviousStatus { get; init; } 
    #else
    public Status28Choice_? PreviousStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_7WM2L5R3Eeak6e8_Fc5fQg")]
    [DisplayName("Previous Status Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsStsSubTp")]
    #endif
    [IsoXmlTag("PrvsStsSubTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusSubType2Code? PreviousStatusSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusSubType2Code? PreviousStatusSubType { get; init; } 
    #else
    public StatusSubType2Code? PreviousStatusSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported, unless overwritten by a product type assigned to an individual trade.
    /// </summary>
    [IsoId("_7WM2MZR3Eeak6e8_Fc5fQg")]
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
    
    /// <summary>
    /// To indicate the requested CLS settlement session that the related trade is part of.
    /// </summary>
    [IsoId("_HDIpMZU6EeaYkf5FCqYMeA")]
    [DisplayName("Settlement Session Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSsnIdr")]
    #endif
    [IsoXmlTag("SttlmSsnIdr")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementSessionIdentifier { get; init; } 
    #else
    public System.String? SettlementSessionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// The identification that links the quoted trades with a submitted Report issued by a central system.
    /// </summary>
    [IsoId("_V88rQJR4Eeak6e8_Fc5fQg")]
    [DisplayName("Linked Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdRptId")]
    #endif
    [IsoXmlTag("LkdRptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LinkedReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LinkedReportIdentification { get; init; } 
    #else
    public System.String? LinkedReportIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
