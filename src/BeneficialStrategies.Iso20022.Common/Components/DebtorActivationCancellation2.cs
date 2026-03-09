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
/// Identifies the creditor enrolment to be cancelled.
/// </summary>
[IsoId("_UVRG6-H7Eeqbls7Gk4-ckA")]
[DisplayName("Debtor Activation Cancellation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DebtorActivationCancellation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DebtorActivationCancellation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DebtorActivationCancellation2( OriginalActivation2Choice_ reqOriginalActivation )
    {
        OriginalActivation = reqOriginalActivation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    [IsoId("_UWtRUeH7Eeqbls7Gk4-ckA")]
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
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_UWtRU-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DebtorActivationCancellationReason2? CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtorActivationCancellationReason2? CancellationReason { get; init; } 
    #else
    public DebtorActivationCancellationReason2? CancellationReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the original activation data.
    /// </summary>
    [IsoId("_UWtRVeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Activation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlActvtn")]
    #endif
    [IsoXmlTag("OrgnlActvtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalActivation2Choice_ OriginalActivation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalActivation2Choice_ OriginalActivation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalActivation2Choice_ OriginalActivation { get; init; } 
    #else
    public OriginalActivation2Choice_ OriginalActivation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_UWtRV-H7Eeqbls7Gk4-ckA")]
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
