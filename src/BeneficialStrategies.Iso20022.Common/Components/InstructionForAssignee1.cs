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
/// Further information related to the processing of the investigation that may need to be acted upon by the assignee.
/// </summary>
[IsoId("_cj1mAdA1EeeCAfThR1cp_Q")]
[DisplayName("Instruction For Assignee")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructionForAssignee1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Coded information related to the processing of the investigation instruction, provided by the assigner, and intended for the assignee.
    /// </summary>
    [IsoId("_czjdAdA1EeeCAfThR1cp_Q")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalAgentInstruction1Code? Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalAgentInstruction1Code? Code { get; init; } 
    #else
    public ExternalAgentInstruction1Code? Code { get; set; } 
    #endif
    
    /// <summary>
    /// Further information complementing the coded instruction or instruction to the assignee.
    /// </summary>
    [IsoId("_czjdA9A1EeeCAfThR1cp_Q")]
    [DisplayName("Instruction Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrInf")]
    #endif
    [IsoXmlTag("InstrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? InstructionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionInformation { get; init; } 
    #else
    public System.String? InstructionInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
