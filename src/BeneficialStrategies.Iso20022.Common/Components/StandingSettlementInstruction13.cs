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
/// Details of the standing settlement instruction to be applied.
/// </summary>
[IsoId("_sJHCEY-vEeaEa8S_GI1QNA")]
[DisplayName("Standing Settlement Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StandingSettlementInstruction13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StandingSettlementInstruction13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StandingSettlementInstruction13( SettlementStandingInstructionDatabase4Choice_ reqSettlementStandingInstructionDatabase )
    {
        SettlementStandingInstructionDatabase = reqSettlementStandingInstructionDatabase;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_sYI8lY-vEeaEa8S_GI1QNA")]
    [DisplayName("Settlement Standing Instruction Database")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmStgInstrDB")]
    #endif
    [IsoXmlTag("SttlmStgInstrDB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementStandingInstructionDatabase4Choice_ SettlementStandingInstructionDatabase { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementStandingInstructionDatabase4Choice_ SettlementStandingInstructionDatabase { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementStandingInstructionDatabase4Choice_ SettlementStandingInstructionDatabase { get; init; } 
    #else
    public SettlementStandingInstructionDatabase4Choice_ SettlementStandingInstructionDatabase { get; set; } 
    #endif
    
    /// <summary>
    /// Vendor of the Settlement Standing Instruction database requested to be consulted.
    /// </summary>
    [IsoId("_sYI8nY-vEeaEa8S_GI1QNA")]
    [DisplayName("Vendor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vndr")]
    #endif
    [IsoXmlTag("Vndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification117Choice_? Vendor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification117Choice_? Vendor { get; init; } 
    #else
    public PartyIdentification117Choice_? Vendor { get; set; } 
    #endif
    
    /// <summary>
    /// Delivering parties, other than the seller, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_sYI8pY-vEeaEa8S_GI1QNA")]
    [DisplayName("Other Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDlvrgSttlmPties")]
    #endif
    [IsoXmlTag("OthrDlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties59? OtherDeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties59? OtherDeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties59? OtherDeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Receiving parties, other than the buyer, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_sYI8rY-vEeaEa8S_GI1QNA")]
    [DisplayName("Other Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRcvgSttlmPties")]
    #endif
    [IsoXmlTag("OthrRcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties59? OtherReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties59? OtherReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties59? OtherReceivingSettlementParties { get; set; } 
    #endif
    
    
    #nullable disable
    
}
