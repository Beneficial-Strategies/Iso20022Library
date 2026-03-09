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
/// Provides the per record status details.
/// </summary>
[IsoId("_YZkjQdHEEeaokquJJ-K6uA")]
[DisplayName("Status Report Record")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusReportRecord3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusReportRecord3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusReportRecord3( System.String reqOriginalRecordIdentification,ReportingRecordStatus1Code reqStatus )
    {
        OriginalRecordIdentification = reqOriginalRecordIdentification;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous technical identification of the original data for which the status is provided.
    /// </summary>
    [IsoId("_Yiw7gdHEEeaokquJJ-K6uA")]
    [DisplayName("Original Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlRcrdId")]
    #endif
    [IsoXmlTag("OrgnlRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text OriginalRecordIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalRecordIdentification { get; init; } 
    #else
    public System.String OriginalRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Defines status of the reported transaction.
    /// </summary>
    [IsoId("_Yiw7g9HEEeaokquJJ-K6uA")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportingRecordStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportingRecordStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingRecordStatus1Code Status { get; init; } 
    #else
    public ReportingRecordStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the rule which could not be validated.
    /// </summary>
    [IsoId("_Yiw7hdHEEeaokquJJ-K6uA")]
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
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_Yiw7h9HEEeaokquJJ-K6uA")]
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
