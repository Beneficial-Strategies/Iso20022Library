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
/// Specifies the status of a creditor enrolment.
/// </summary>
[IsoId("_UalrzeH7Eeqbls7Gk4-ckA")]
[DisplayName("Enrolment Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EnrolmentStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EnrolmentStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EnrolmentStatus2( ServiceStatus1Choice_ reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    [IsoId("_Ub7vk-H7Eeqbls7Gk4-ckA")]
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
    /// Provides detailed information on the status for the request.
    /// </summary>
    [IsoId("_Ub7vleH7Eeqbls7Gk4-ckA")]
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
    /// Specifies the reason for the status of the enrolment request.
    /// </summary>
    [IsoId("_Ub7vl-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditorEnrolmentStatusReason2? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditorEnrolmentStatusReason2? StatusReason { get; init; } 
    #else
    public CreditorEnrolmentStatusReason2? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the original creditor enrolment data.
    /// </summary>
    [IsoId("_Ub7vmeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Enrolment Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlEnrlmntRef")]
    #endif
    [IsoXmlTag("OrgnlEnrlmntRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalEnrolment2Choice_? OriginalEnrolmentReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalEnrolment2Choice_? OriginalEnrolmentReference { get; init; } 
    #else
    public OriginalEnrolment2Choice_? OriginalEnrolmentReference { get; set; } 
    #endif
    
    /// <summary>
    /// Actual date when the creditor enrolment was executed.
    /// </summary>
    [IsoId("_Ub7vm-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Effective Enrolment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvEnrlmntDt")]
    #endif
    [IsoXmlTag("FctvEnrlmntDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EffectiveEnrolmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EffectiveEnrolmentDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EffectiveEnrolmentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Ub7vneH7Eeqbls7Gk4-ckA")]
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
