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
[IsoId("_6sllzffVEeiNZp_PtLohLw")]
[DisplayName("Standing Settlement Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StandingSettlementInstruction17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StandingSettlementInstruction17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StandingSettlementInstruction17( SettlementStandingInstructionDatabase5Choice_ reqSettlementStandingInstructionDatabase,Counterparty14Choice_ reqCounterparty )
    {
        SettlementStandingInstructionDatabase = reqSettlementStandingInstructionDatabase;
        Counterparty = reqCounterparty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_6sll0_fVEeiNZp_PtLohLw")]
    [DisplayName("Settlement Standing Instruction Database")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmStgInstrDB")]
    #endif
    [IsoXmlTag("SttlmStgInstrDB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementStandingInstructionDatabase5Choice_ SettlementStandingInstructionDatabase { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementStandingInstructionDatabase5Choice_ SettlementStandingInstructionDatabase { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementStandingInstructionDatabase5Choice_ SettlementStandingInstructionDatabase { get; init; } 
    #else
    public SettlementStandingInstructionDatabase5Choice_ SettlementStandingInstructionDatabase { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the buyer or seller in a standing settlement instruction enabling to derive the Standing Settlement Instruction.
    /// </summary>
    [IsoId("_6sll2_fVEeiNZp_PtLohLw")]
    [DisplayName("Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPty")]
    #endif
    [IsoXmlTag("CtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Counterparty14Choice_ Counterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Counterparty14Choice_ Counterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Counterparty14Choice_ Counterparty { get; init; } 
    #else
    public Counterparty14Choice_ Counterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Vendor of the settlement standing instruction database that is to be consulted.
    /// </summary>
    [IsoId("_6sll4_fVEeiNZp_PtLohLw")]
    [DisplayName("Vendor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vndr")]
    #endif
    [IsoXmlTag("Vndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification157? Vendor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification157? Vendor { get; init; } 
    #else
    public PartyIdentification157? Vendor { get; set; } 
    #endif
    
    /// <summary>
    /// Delivering parties, other than the seller, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_6sll6_fVEeiNZp_PtLohLw")]
    [DisplayName("Other Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDlvrgSttlmPties")]
    #endif
    [IsoXmlTag("OthrDlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties81? OtherDeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties81? OtherDeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties81? OtherDeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Receiving parties, other than the buyer, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_6sll8_fVEeiNZp_PtLohLw")]
    [DisplayName("Other Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRcvgSttlmPties")]
    #endif
    [IsoXmlTag("OthrRcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties81? OtherReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties81? OtherReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties81? OtherReceivingSettlementParties { get; set; } 
    #endif
    
    
    #nullable disable
    
}
