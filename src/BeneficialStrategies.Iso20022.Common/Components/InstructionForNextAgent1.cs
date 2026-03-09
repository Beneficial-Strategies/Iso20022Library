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
/// Further information related to the processing of the payment instruction that may need to be acted upon by an other agent. The instruction may relate to a level of service, or may be an instruction that has to be executed by the creditor&apos;s agent, or may be information required by the other agent.
/// </summary>
[IsoId("_TOHf0dp-Ed-ak6NoX_4Aeg_1118639475")]
[DisplayName("Instruction For Next Agent")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructionForNextAgent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Coded information related to the processing of the payment instruction, provided by the initiating party, and intended for the next agent in the payment chain.
    /// </summary>
    [IsoId("_TOHf0tp-Ed-ak6NoX_4Aeg_-1086263072")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Instruction4Code? Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Instruction4Code? Code { get; init; } 
    #else
    public Instruction4Code? Code { get; set; } 
    #endif
    
    /// <summary>
    /// Further information complementing the coded instruction or instruction to the next agent that is bilaterally agreed or specific to a user community.
    /// </summary>
    [IsoId("_TOHf09p-Ed-ak6NoX_4Aeg_-1086262686")]
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
