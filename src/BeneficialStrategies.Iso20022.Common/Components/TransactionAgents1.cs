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
/// Set of elements providing information specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_PyefZdp-Ed-ak6NoX_4Aeg_868982411")]
[DisplayName("Transaction Agents")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionAgents1
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
    [IsoId("_PyefZtp-Ed-ak6NoX_4Aeg_1518216745")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_PyefZ9p-Ed-ak6NoX_4Aeg_868982525")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the debtor agent and the intermediary agent 2.
    /// </summary>
    [IsoId("_PyefaNp-Ed-ak6NoX_4Aeg_2013944809")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt1")]
    #endif
    [IsoXmlTag("IntrmyAgt1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the intermediary agent 1 and the intermediary agent 3.
    /// </summary>
    [IsoId("_PynpUNp-Ed-ak6NoX_4Aeg_2013944549")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt2")]
    #endif
    [IsoXmlTag("IntrmyAgt2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the intermediary agent 2 and the creditor agent.
    /// </summary>
    [IsoId("_PynpUdp-Ed-ak6NoX_4Aeg_2013944869")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt3")]
    #endif
    [IsoXmlTag("IntrmyAgt3")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, eg, central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_PynpUtp-Ed-ak6NoX_4Aeg_868982892")]
    [DisplayName("Receiving Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgAgt")]
    #endif
    [IsoXmlTag("RcvgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? ReceivingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? ReceivingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? ReceivingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, eg, central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_PynpU9p-Ed-ak6NoX_4Aeg_868982928")]
    [DisplayName("Delivering Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgAgt")]
    #endif
    [IsoXmlTag("DlvrgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? DeliveringAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? DeliveringAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? DeliveringAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity that has the right to issue securities.
    /// </summary>
    [IsoId("_PynpVNp-Ed-ak6NoX_4Aeg_820756342")]
    [DisplayName("Issuing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssgAgt")]
    #endif
    [IsoXmlTag("IssgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? IssuingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? IssuingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? IssuingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Place where settlement of the securities takes place.||Note: this is typed by a financial institution identification - as this is the standard way of identifying eg securities settlement agent/central system.
    /// </summary>
    [IsoId("_PynpVdp-Ed-ak6NoX_4Aeg_1126443703")]
    [DisplayName("Settlement Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPlc")]
    #endif
    [IsoXmlTag("SttlmPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? SettlementPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? SettlementPlace { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? SettlementPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary agent related to the underlying transaction.
    /// </summary>
    [IsoId("_PynpVtp-Ed-ak6NoX_4Aeg_-1828368630")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProprietaryAgent1? Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProprietaryAgent1? Proprietary { get; init; } 
    #else
    public ProprietaryAgent1? Proprietary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
