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
/// Specifies the meta data associated with a netting cut off report.
/// </summary>
[IsoId("_BuNM0QN1Ee2-vqzwMUAewg")]
[DisplayName("Netting Cut Off Report Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NettingCutOffReportData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NettingCutOffReportData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NettingCutOffReportData2( System.String reqMessageIdentification,System.DateTime reqCreationDateTime,System.String reqReportType,System.DateOnly reqActivationDate )
    {
        MessageIdentification = reqMessageIdentification;
        CreationDateTime = reqCreationDateTime;
        ReportType = reqReportType;
        ActivationDate = reqActivationDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a message, as assigned by the Sender. This unique identifier can be used for cross-referencing purposes in subsequent messages.
    /// </summary>
    [IsoId("_Bzi_0QN1Ee2-vqzwMUAewg")]
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
    /// Date and time at which the net report was generated.
    /// </summary>
    [IsoId("_Bzi_0wN1Ee2-vqzwMUAewg")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the type of net report, indicating how the obligations have been calculated.
    /// </summary>
    [IsoId("_Bzi_1QN1Ee2-vqzwMUAewg")]
    [DisplayName("Report Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptTp")]
    #endif
    [IsoXmlTag("RptTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4Text ReportType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReportType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReportType { get; init; } 
    #else
    public System.String ReportType { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the proposed netting cut off will become active.
    /// </summary>
    [IsoId("_Bzi_1wN1Ee2-vqzwMUAewg")]
    [DisplayName("Activation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvtnDt")]
    #endif
    [IsoXmlTag("ActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ActivationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ActivationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ActivationDate { get; init; } 
    #else
    public System.DateOnly ActivationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the participant receiving the net report.
    /// </summary>
    [IsoId("_Bzi_2QN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Service Participant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetSvcPtcptId")]
    #endif
    [IsoXmlTag("NetSvcPtcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification242Choice_? NetServiceParticipantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_? NetServiceParticipantIdentification { get; init; } 
    #else
    public PartyIdentification242Choice_? NetServiceParticipantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the central system responsible for generating the net report.
    /// </summary>
    [IsoId("_Bzi_2wN1Ee2-vqzwMUAewg")]
    [DisplayName("Report Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSvcr")]
    #endif
    [IsoXmlTag("RptSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification242Choice_? ReportServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_? ReportServicer { get; init; } 
    #else
    public PartyIdentification242Choice_? ReportServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the type of netting service supporting the net report.
    /// </summary>
    [IsoId("_Bzi_3QN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Service Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetSvcTp")]
    #endif
    [IsoXmlTag("NetSvcTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NetServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NetServiceType { get; init; } 
    #else
    public System.String? NetServiceType { get; set; } 
    #endif
    
    /// <summary>
    /// Page number of the message (within the net cut off report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_Bzi_3wN1Ee2-vqzwMUAewg")]
    [DisplayName("Message Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgPgntn")]
    #endif
    [IsoXmlTag("MsgPgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination1? MessagePagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1? MessagePagination { get; init; } 
    #else
    public Pagination1? MessagePagination { get; set; } 
    #endif
    
    
    #nullable disable
    
}
