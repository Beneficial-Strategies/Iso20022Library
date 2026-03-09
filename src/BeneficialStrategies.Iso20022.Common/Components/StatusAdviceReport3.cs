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
/// Provides the report level status advice.
/// </summary>
[IsoId("_CUoXKdGdEeaQk737TH1Fzw")]
[DisplayName("Status Advice Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusAdviceReport3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusAdviceReport3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusAdviceReport3( ReportingMessageStatus1Code reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the status for the full message.
    /// </summary>
    [IsoId("_CduBsdGdEeaQk737TH1Fzw")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportingMessageStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportingMessageStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingMessageStatus1Code Status { get; init; } 
    #else
    public ReportingMessageStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the rule which could not be validated.
    /// </summary>
    [IsoId("_CduBs9GdEeaQk737TH1Fzw")]
    [DisplayName("Validation Rule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtnRule")]
    #endif
    [IsoXmlTag("VldtnRule")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericValidationRuleIdentification1? ValidationRule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericValidationRuleIdentification1? ValidationRule { get; init; } 
    #else
    public GenericValidationRuleIdentification1? ValidationRule { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the report date with the status advice message is related to.
    /// </summary>
    [IsoId("_CduBtdGdEeaQk737TH1Fzw")]
    [DisplayName("Message Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgDt")]
    #endif
    [IsoXmlTag("MsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MessageDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MessageDate { get; init; } 
    #else
    public System.DateOnly? MessageDate { get; set; } 
    #endif
    
    /// <summary>
    /// Statistical information on the results of the records processing.
    /// </summary>
    [IsoId("_CduBt9GdEeaQk737TH1Fzw")]
    [DisplayName("Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttstcs")]
    #endif
    [IsoXmlTag("Sttstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalReportStatistics3? Statistics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalReportStatistics3? Statistics { get; init; } 
    #else
    public OriginalReportStatistics3? Statistics { get; set; } 
    #endif
    
    
    #nullable disable
    
}
