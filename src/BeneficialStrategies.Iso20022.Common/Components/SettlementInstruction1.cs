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
[IsoId("_thgFkFkyEeGeoaLUQk__nA_-1005103671")]
[DisplayName("Settlement Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInstruction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementInstruction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementInstruction1( SettlementMethod1Code reqSettlementMethod )
    {
        SettlementMethod = reqSettlementMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_thgFkVkyEeGeoaLUQk__nA_-2116015090")]
    [DisplayName("Settlement Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmMtd")]
    #endif
    [IsoXmlTag("SttlmMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementMethod1Code SettlementMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementMethod1Code SettlementMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementMethod1Code SettlementMethod { get; init; } 
    #else
    public SettlementMethod1Code SettlementMethod { get; set; } 
    #endif
    
    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_thp2kFkyEeGeoaLUQk__nA_692955488")]
    [DisplayName("Settlement Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAcct")]
    #endif
    [IsoXmlTag("SttlmAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? SettlementAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? SettlementAccount { get; init; } 
    #else
    public CashAccount24? SettlementAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_thp2kVkyEeGeoaLUQk__nA_-1457591385")]
    [DisplayName("Clearing System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSys")]
    #endif
    [IsoXmlTag("ClrSys")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; } 
    #else
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; set; } 
    #endif
    
    /// <summary>
    /// Agent through which the instructing agent will reimburse the instructed agent.||Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_thp2klkyEeGeoaLUQk__nA_-696826232")]
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
    [IsoId("_thp2k1kyEeGeoaLUQk__nA_-1883116034")]
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
    [IsoId("_thp2lFkyEeGeoaLUQk__nA_1577085429")]
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
    [IsoId("_thzAgFkyEeGeoaLUQk__nA_-1303645245")]
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
    
    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If ThirdReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.
    /// </summary>
    [IsoId("_thzAgVkyEeGeoaLUQk__nA_-1341631288")]
    [DisplayName("Third Reimbursement Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrdRmbrsmntAgt")]
    #endif
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? ThirdReimbursementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? ThirdReimbursementAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? ThirdReimbursementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the third reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_thzAglkyEeGeoaLUQk__nA_-2096381162")]
    [DisplayName("Third Reimbursement Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrdRmbrsmntAgtAcct")]
    #endif
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? ThirdReimbursementAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? ThirdReimbursementAgentAccount { get; init; } 
    #else
    public CashAccount24? ThirdReimbursementAgentAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
