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
/// Provides details of many status advice reports where many received reports are reported at once.
/// </summary>
[IsoId("_CLY7kdGdEeaQk737TH1Fzw")]
[DisplayName("Message Report Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageReportHeader4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provide detail on previously received message reports that are being reported as part of this status advice.
    /// Usage:
    /// When required, this field will be populated with the BAH Business Message Identifier field. Where only a single message report header is used, this field is not used and relies solely on the BAH Business Message Identifier field.
    /// </summary>
    [IsoId("_iChZYOvBEealxoQGKU9EVQ")]
    [DisplayName("Message Report Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRptIdr")]
    #endif
    [IsoXmlTag("MsgRptIdr")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? MessageReportIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageReportIdentifier { get; init; } 
    #else
    public System.String? MessageReportIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Details the status of the whole message that has been received.
    /// </summary>
    [IsoId("_CUoXI9GdEeaQk737TH1Fzw")]
    [DisplayName("Message Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgSts")]
    #endif
    [IsoXmlTag("MsgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusAdviceReport3? MessageStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusAdviceReport3? MessageStatus { get; init; } 
    #else
    public StatusAdviceReport3? MessageStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides per record status on the report that has been received.
    /// </summary>
    [IsoId("_CUoXJdGdEeaQk737TH1Fzw")]
    [DisplayName("Record Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdSts")]
    #endif
    [IsoXmlTag("RcrdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReportRecord3? RecordStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReportRecord3? RecordStatus { get; init; } 
    #else
    public StatusReportRecord3? RecordStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_CUoXJ9GdEeaQk737TH1Fzw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
