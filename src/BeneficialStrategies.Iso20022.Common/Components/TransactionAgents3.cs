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
/// Provides further details on the agents specific to the individual transaction.
/// </summary>
[IsoId("_tXX5MFkyEeGeoaLUQk__nA_-435108298")]
[DisplayName("Transaction Agents")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionAgents3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_tXX5MVkyEeGeoaLUQk__nA_-200070093")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_tXX5MlkyEeGeoaLUQk__nA_-105958872")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_tXX5M1kyEeGeoaLUQk__nA_1251852084")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt1")]
    #endif
    [IsoXmlTag("IntrmyAgt1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_tXhDIFkyEeGeoaLUQk__nA_788772033")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt2")]
    #endif
    [IsoXmlTag("IntrmyAgt2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_tXhDIVkyEeGeoaLUQk__nA_1549537186")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt3")]
    #endif
    [IsoXmlTag("IntrmyAgt3")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, such as central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_tXhDIlkyEeGeoaLUQk__nA_-638538344")]
    [DisplayName("Receiving Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgAgt")]
    #endif
    [IsoXmlTag("RcvgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? ReceivingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? ReceivingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? ReceivingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, such as a central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_tXhDI1kyEeGeoaLUQk__nA_-135302165")]
    [DisplayName("Delivering Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgAgt")]
    #endif
    [IsoXmlTag("DlvrgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? DeliveringAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? DeliveringAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? DeliveringAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity that has the right to issue securities.
    /// </summary>
    [IsoId("_tXq0IFkyEeGeoaLUQk__nA_579614623")]
    [DisplayName("Issuing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssgAgt")]
    #endif
    [IsoXmlTag("IssgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? IssuingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? IssuingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? IssuingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Place where settlement of the securities takes place.|Usage: This is typed by a financial institution identification as this is the standard way to identify a securities settlement agent/central system.
    /// </summary>
    [IsoId("_tXq0IVkyEeGeoaLUQk__nA_904732130")]
    [DisplayName("Settlement Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPlc")]
    #endif
    [IsoXmlTag("SttlmPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? SettlementPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? SettlementPlace { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? SettlementPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary agent related to the underlying transaction.
    /// </summary>
    [IsoId("_tXq0IlkyEeGeoaLUQk__nA_-1025208769")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProprietaryAgent3? Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProprietaryAgent3? Proprietary { get; init; } 
    #else
    public ProprietaryAgent3? Proprietary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
