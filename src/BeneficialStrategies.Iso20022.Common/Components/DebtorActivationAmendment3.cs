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
/// Specifies the details to identify a creditor enrolment to be amended and the new amended data.
/// </summary>
[IsoId("_UJ2hEeH7Eeqbls7Gk4-ckA")]
[DisplayName("Debtor Activation Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DebtorActivationAmendment3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DebtorActivationAmendment3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DebtorActivationAmendment3( DebtorActivationAmendment4 reqAmendment,OriginalActivation2Choice_ reqOriginalActivation )
    {
        Amendment = reqAmendment;
        OriginalActivation = reqOriginalActivation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    [IsoId("_ULMk4eH7Eeqbls7Gk4-ckA")]
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
    /// Provides detailed information on the amendment reason.
    /// </summary>
    [IsoId("_ULMk4-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Amendment Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntRsn")]
    #endif
    [IsoXmlTag("AmdmntRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DebtorActivationAmendmentReason2? AmendmentReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtorActivationAmendmentReason2? AmendmentReason { get; init; } 
    #else
    public DebtorActivationAmendmentReason2? AmendmentReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the amended enrolment data.
    /// </summary>
    [IsoId("_ULMk5eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Amendment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amdmnt")]
    #endif
    [IsoXmlTag("Amdmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DebtorActivationAmendment4 Amendment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DebtorActivationAmendment4 Amendment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtorActivationAmendment4 Amendment { get; init; } 
    #else
    public DebtorActivationAmendment4 Amendment { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the original activation data.
    /// </summary>
    [IsoId("_ULMk5-H7Eeqbls7Gk4-ckA")]
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
    [IsoId("_ULMk6eH7Eeqbls7Gk4-ckA")]
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
