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
/// Specifies the status of a debtor activation.
/// </summary>
[IsoId("_Ug_1x-H7Eeqbls7Gk4-ckA")]
[DisplayName("Activation Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActivationStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ActivationStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActivationStatus2( ServiceStatus1Choice_ reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    [IsoId("_UiH3I-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Business Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlBizInstr")]
    #endif
    [IsoXmlTag("OrgnlBizInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; } 
    #else
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the status of the request.
    /// </summary>
    [IsoId("_UiH3JeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ServiceStatus1Choice_ Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ServiceStatus1Choice_ Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceStatus1Choice_ Status { get; init; } 
    #else
    public ServiceStatus1Choice_ Status { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the status of the debtor activation request.
    /// </summary>
    [IsoId("_UiH3J-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DebtorActivationStatusReason2? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtorActivationStatusReason2? StatusReason { get; init; } 
    #else
    public DebtorActivationStatusReason2? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the reference of the original activation request.
    /// </summary>
    [IsoId("_UiH3KeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Activation Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlActvtnRef")]
    #endif
    [IsoXmlTag("OrgnlActvtnRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalActivation2Choice_? OriginalActivationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalActivation2Choice_? OriginalActivationReference { get; init; } 
    #else
    public OriginalActivation2Choice_? OriginalActivationReference { get; set; } 
    #endif
    
    /// <summary>
    /// Effective date when the debtor has been activated.
    /// </summary>
    [IsoId("_17LFgeIGEeqbls7Gk4-ckA")]
    [DisplayName("Effective Activation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvActvtnDt")]
    #endif
    [IsoXmlTag("FctvActvtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EffectiveActivationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EffectiveActivationDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EffectiveActivationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_UiH3K-H7Eeqbls7Gk4-ckA")]
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
