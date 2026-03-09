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
[IsoId("_RAOosR3bEeKXIbeXfdPzuw")]
[DisplayName("Trade Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeData8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeData8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeData8( System.String reqMatchingSystemUniqueReference )
    {
        MatchingSystemUniqueReference = reqMatchingSystemUniqueReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Represents the original reference of the instruction for which the status is given, as assigned by the participant that submitted the foreign exchange trade.
    /// </summary>
    [IsoId("_Mhu9BzqLEeKXK8qRvydwAw")]
    [DisplayName("Originator Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgtrRef")]
    #endif
    [IsoXmlTag("OrgtrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginatorReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginatorReference { get; init; } 
    #else
    public System.String? OriginatorReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the unique system identification assigned to the trade by the central matching system.
    /// </summary>
    [IsoId("_RL6URR3bEeKXIbeXfdPzuw")]
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
    [IsoId("_RL6UTR3bEeKXIbeXfdPzuw")]
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
    /// Unique reference from the central settlement system that allows the removal of alleged trades once the matched status notification for the matching side has been received.
    /// </summary>
    [IsoId("_YnsFlZUJEeKShbaq9ixROw")]
    [DisplayName("Matching System Matched Side Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSysMtchdSdRef")]
    #endif
    [IsoXmlTag("MtchgSysMtchdSdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MatchingSystemMatchedSideReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MatchingSystemMatchedSideReference { get; init; } 
    #else
    public System.String? MatchingSystemMatchedSideReference { get; set; } 
    #endif
    
    /// <summary>
    /// The current settlement date of the notification.
    /// </summary>
    [IsoId("_KY3DE4D3EeKQ1_PWJcX5xQ")]
    [DisplayName("Current Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurSttlmDt")]
    #endif
    [IsoXmlTag("CurSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CurrentSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CurrentSettlementDate { get; init; } 
    #else
    public System.DateOnly? CurrentSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement date has been amended.
    /// </summary>
    [IsoId("_Q3n4cB9eEeKuoOw3Zviw4g")]
    [DisplayName("New Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewSttlmDt")]
    #endif
    [IsoXmlTag("NewSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? NewSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? NewSettlementDate { get; init; } 
    #else
    public System.DateOnly? NewSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date and time at which the current status was assigned to the individual trade.
    /// </summary>
    [IsoId("_RL6UUR3bEeKXIbeXfdPzuw")]
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
    /// Product type of the individual trade.
    /// </summary>
    [IsoId("_RL6UVR3bEeKXIbeXfdPzuw")]
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
    /// To indicate the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_HiXAGx3bEeKXIbeXfdPzuw")]
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
    /// Information that is to be provided to trade repositories in the context of the regulatory standards around OTC derivatives, central counterparties and trade repositories.
    /// </summary>
    [IsoId("_0OWvlSjtEeK1Sbo8NpBROA")]
    [DisplayName("Regulatory Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryRptg")]
    #endif
    [IsoXmlTag("RgltryRptg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegulatoryReporting1? RegulatoryReporting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegulatoryReporting1? RegulatoryReporting { get; init; } 
    #else
    public RegulatoryReporting1? RegulatoryReporting { get; set; } 
    #endif
    
    
    #nullable disable
    
}
