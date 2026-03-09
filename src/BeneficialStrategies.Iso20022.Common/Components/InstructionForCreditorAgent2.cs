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
/// Further information related to the processing of the payment instruction that may need to be acted upon by the creditor&apos;s agent. The instruction may relate to a level of service, or may be an instruction that has to be executed by the creditor&apos;s agent, or may be information required by the creditor&apos;s agent.
/// </summary>
[IsoId("_TOHf1Np-Ed-ak6NoX_4Aeg_1659539851")]
[DisplayName("Instruction For Creditor Agent")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructionForCreditorAgent2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Coded information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor&apos;s agent.
    /// </summary>
    [IsoId("_TOHf1dp-Ed-ak6NoX_4Aeg_1659540378")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Instruction5Code? Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Instruction5Code? Code { get; init; } 
    #else
    public Instruction5Code? Code { get; set; } 
    #endif
    
    /// <summary>
    /// Further information complementing the coded instruction or instruction to the creditor&apos;s agent that is bilaterally agreed or specific to a user community.
    /// </summary>
    [IsoId("_TOHf1tp-Ed-ak6NoX_4Aeg_1659540421")]
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
