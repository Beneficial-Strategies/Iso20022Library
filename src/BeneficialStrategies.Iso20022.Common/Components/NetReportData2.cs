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
/// Specifies the meta data associated with a net report.
/// </summary>
[IsoId("_CWAzsQN1Ee2-vqzwMUAewg")]
[DisplayName("Net Report Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetReportData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NetReportData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetReportData2( System.String reqMessageIdentification,System.DateTime reqCreationDateTime,System.TimeOnly reqNettingCutOffTime,System.DateOnly reqReportDate,System.DateOnly reqValueDate )
    {
        MessageIdentification = reqMessageIdentification;
        CreationDateTime = reqCreationDateTime;
        NettingCutOffTime = reqNettingCutOffTime;
        ReportDate = reqReportDate;
        ValueDate = reqValueDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a message, as assigned by the Sender. This unique identifier can be used for cross-referencing purposes in subsequent messages.
    /// </summary>
    [IsoId("_Cb9qsQN1Ee2-vqzwMUAewg")]
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
    [IsoId("_Cb9qswN1Ee2-vqzwMUAewg")]
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
    /// Provides the cut off time that has been passed, resulting in the generation of the net report.
    /// </summary>
    [IsoId("_Cb9qtQN1Ee2-vqzwMUAewg")]
    [DisplayName("Netting Cut Off Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetgCutOffTm")]
    #endif
    [IsoXmlTag("NetgCutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISOTime NettingCutOffTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.TimeOnly NettingCutOffTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly NettingCutOffTime { get; init; } 
    #else
    public System.TimeOnly NettingCutOffTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the value date on which the net report was generated.
    /// </summary>
    [IsoId("_Cb9qtwN1Ee2-vqzwMUAewg")]
    [DisplayName("Report Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptDt")]
    #endif
    [IsoXmlTag("RptDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ReportDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ReportDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ReportDate { get; init; } 
    #else
    public System.DateOnly ReportDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the value date of the trades used in the generation of the net report.
    /// </summary>
    [IsoId("_Cb9quQN1Ee2-vqzwMUAewg")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValueDate { get; init; } 
    #else
    public System.DateOnly ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of net report, indicating how the obligations have been calculated.
    /// </summary>
    [IsoId("_Cb9quwN1Ee2-vqzwMUAewg")]
    [DisplayName("Report Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptTp")]
    #endif
    [IsoXmlTag("RptTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReportType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportType { get; init; } 
    #else
    public System.String? ReportType { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the central system responsible for generating the net report.
    /// </summary>
    [IsoId("_Cb9qvQN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Report Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetRptSvcr")]
    #endif
    [IsoXmlTag("NetRptSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification242Choice_? NetReportServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_? NetReportServicer { get; init; } 
    #else
    public PartyIdentification242Choice_? NetReportServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the type of netting service supporting the net report.
    /// </summary>
    [IsoId("_Cb9qvwN1Ee2-vqzwMUAewg")]
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
    /// Page number of the message (within the net report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_Cb9qwQN1Ee2-vqzwMUAewg")]
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
