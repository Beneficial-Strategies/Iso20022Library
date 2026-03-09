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
[IsoId("_A2BegtokEeC60axPepSq7g_-895244261")]
[DisplayName("Standing Settlement Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StandingSettlementInstruction9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StandingSettlementInstruction9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StandingSettlementInstruction9( SettlementStandingInstructionDatabase3Choice_ reqSettlementStandingInstructionDatabase )
    {
        SettlementStandingInstructionDatabase = reqSettlementStandingInstructionDatabase;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_A2Beg9okEeC60axPepSq7g_-1009083327")]
    [DisplayName("Settlement Standing Instruction Database")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmStgInstrDB")]
    #endif
    [IsoXmlTag("SttlmStgInstrDB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementStandingInstructionDatabase3Choice_ SettlementStandingInstructionDatabase { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementStandingInstructionDatabase3Choice_ SettlementStandingInstructionDatabase { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementStandingInstructionDatabase3Choice_ SettlementStandingInstructionDatabase { get; init; } 
    #else
    public SettlementStandingInstructionDatabase3Choice_ SettlementStandingInstructionDatabase { get; set; } 
    #endif
    
    /// <summary>
    /// Vendor of the Settlement Standing Instruction database requested to be consulted.
    /// </summary>
    [IsoId("_A2BehNokEeC60axPepSq7g_1113620591")]
    [DisplayName("Vendor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vndr")]
    #endif
    [IsoXmlTag("Vndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32Choice_? Vendor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32Choice_? Vendor { get; init; } 
    #else
    public PartyIdentification32Choice_? Vendor { get; set; } 
    #endif
    
    /// <summary>
    /// Delivering parties, other than the seller, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_A2BehdokEeC60axPepSq7g_408505976")]
    [DisplayName("Other Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDlvrgSttlmPties")]
    #endif
    [IsoXmlTag("OthrDlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties23? OtherDeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties23? OtherDeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties23? OtherDeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Receiving parties, other than the buyer, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_A2BehtokEeC60axPepSq7g_-588566377")]
    [DisplayName("Other Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRcvgSttlmPties")]
    #endif
    [IsoXmlTag("OthrRcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties23? OtherReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties23? OtherReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties23? OtherReceivingSettlementParties { get; set; } 
    #endif
    
    
    #nullable disable
    
}
