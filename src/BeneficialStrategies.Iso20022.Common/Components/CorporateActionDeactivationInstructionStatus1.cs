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
/// Provides status of the deactivation instruction.
/// </summary>
[IsoId("_RjRuptp-Ed-ak6NoX_4Aeg_491823442")]
[DisplayName("Corporate Action Deactivation Instruction Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDeactivationInstructionStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionDeactivationInstructionStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionDeactivationInstructionStatus1( CorporateActionDeactivationInstructionProcessingStatus1 reqProcessedStatus,CorporateActionDeactivationInstructionRejectionStatus1 reqRejectedStatus )
    {
        ProcessedStatus = reqProcessedStatus;
        RejectedStatus = reqRejectedStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_RjRup9p-Ed-ak6NoX_4Aeg_-5830420")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption1FormatChoice_? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption1FormatChoice_? OptionType { get; init; } 
    #else
    public CorporateActionOption1FormatChoice_? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_RjbfoNp-Ed-ak6NoX_4Aeg_-5830390")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OptionNumber { get; init; } 
    #else
    public System.String? OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the processing status of the instruction.
    /// </summary>
    [IsoId("_Rjbfodp-Ed-ak6NoX_4Aeg_1462046019")]
    [DisplayName("Processed Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcdSts")]
    #endif
    [IsoXmlTag("PrcdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionDeactivationInstructionProcessingStatus1 ProcessedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionDeactivationInstructionProcessingStatus1 ProcessedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDeactivationInstructionProcessingStatus1 ProcessedStatus { get; init; } 
    #else
    public CorporateActionDeactivationInstructionProcessingStatus1 ProcessedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_Rjbfotp-Ed-ak6NoX_4Aeg_1560861725")]
    [DisplayName("Rejected Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctdSts")]
    #endif
    [IsoXmlTag("RjctdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionDeactivationInstructionRejectionStatus1 RejectedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionDeactivationInstructionRejectionStatus1 RejectedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDeactivationInstructionRejectionStatus1 RejectedStatus { get; init; } 
    #else
    public CorporateActionDeactivationInstructionRejectionStatus1 RejectedStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
