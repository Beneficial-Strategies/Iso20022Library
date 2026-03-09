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
[IsoId("_UedfLeH7Eeqbls7Gk4-ckA")]
[DisplayName("Creditor Enrolment Cancellation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditorEnrolmentCancellation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditorEnrolmentCancellation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditorEnrolmentCancellation2( OriginalEnrolment2Choice_ reqOriginalEnrolment )
    {
        OriginalEnrolment = reqOriginalEnrolment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    [IsoId("_Ufpx8eH7Eeqbls7Gk4-ckA")]
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
    [IsoId("_Ufpx8-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditorEnrolmentCancellationReason2? CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditorEnrolmentCancellationReason2? CancellationReason { get; init; } 
    #else
    public CreditorEnrolmentCancellationReason2? CancellationReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the original creditor enrolment data.
    /// </summary>
    [IsoId("_Ufpx9eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Enrolment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlEnrlmnt")]
    #endif
    [IsoXmlTag("OrgnlEnrlmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalEnrolment2Choice_ OriginalEnrolment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalEnrolment2Choice_ OriginalEnrolment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalEnrolment2Choice_ OriginalEnrolment { get; init; } 
    #else
    public OriginalEnrolment2Choice_ OriginalEnrolment { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Ufpx9-H7Eeqbls7Gk4-ckA")]
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
