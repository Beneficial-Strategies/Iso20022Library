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
/// Provides further details on the settlement of the instruction.
/// </summary>
[IsoId("_tgKBxFkyEeGeoaLUQk__nA_-1371775540")]
[DisplayName("Settlement Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInstruction3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Agent through which the instructing agent will reimburse the instructed agent.|Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_tgTywFkyEeGeoaLUQk__nA_1623062888")]
    [DisplayName("Instructing Reimbursement Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgRmbrsmntAgt")]
    #endif
    [IsoXmlTag("InstgRmbrsmntAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? InstructingReimbursementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? InstructingReimbursementAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? InstructingReimbursementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the instructing reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_tgTywVkyEeGeoaLUQk__nA_-977685388")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgRmbrsmntAgtAcct")]
    #endif
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? InstructingReimbursementAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? InstructingReimbursementAgentAccount { get; init; } 
    #else
    public CashAccount24? InstructingReimbursementAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If InstructedReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.|Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_tgTywlkyEeGeoaLUQk__nA_-652567881")]
    [DisplayName("Instructed Reimbursement Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdRmbrsmntAgt")]
    #endif
    [IsoXmlTag("InstdRmbrsmntAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? InstructedReimbursementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? InstructedReimbursementAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? InstructedReimbursementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the instructed reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_tgTyw1kyEeGeoaLUQk__nA_-1508202374")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdRmbrsmntAgtAcct")]
    #endif
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? InstructedReimbursementAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? InstructedReimbursementAgentAccount { get; init; } 
    #else
    public CashAccount24? InstructedReimbursementAgentAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
