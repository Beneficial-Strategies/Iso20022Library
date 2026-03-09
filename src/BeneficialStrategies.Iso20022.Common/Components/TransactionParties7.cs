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
/// Provides further details on the parties specific to the individual transaction.
/// </summary>
[IsoId("_2Wprx3L-EeidQ_AAdEzxQA")]
[DisplayName("Transaction Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionParties7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionParties7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionParties7( Party40Choice_ reqDebtor,Party40Choice_ reqCreditor )
    {
        Debtor = reqDebtor;
        Creditor = reqCreditor;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_2hFZ83L-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtDbtr")]
    #endif
    [IsoXmlTag("UltmtDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Party40Choice_? UltimateDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party40Choice_? UltimateDebtor { get; init; } 
    #else
    public Party40Choice_? UltimateDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_2hFZ9XL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party40Choice_ Debtor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party40Choice_ Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party40Choice_ Debtor { get; init; } 
    #else
    public Party40Choice_ Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_2hFZ93L-EeidQ_AAdEzxQA")]
    [DisplayName("Initiating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPty")]
    #endif
    [IsoXmlTag("InitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Party40Choice_? InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party40Choice_? InitiatingParty { get; init; } 
    #else
    public Party40Choice_? InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_2hFZ-XL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_2hFZ-3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsInstgAgt1")]
    #endif
    [IsoXmlTag("PrvsInstgAgt1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; set; } 
    #endif
    
    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_2hFZ_XL-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsInstgAgt2")]
    #endif
    [IsoXmlTag("PrvsInstgAgt2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; set; } 
    #endif
    
    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_2hFZ_3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsInstgAgt3")]
    #endif
    [IsoXmlTag("PrvsInstgAgt3")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_2hFaAXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt1")]
    #endif
    [IsoXmlTag("IntrmyAgt1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_2hFaA3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt2")]
    #endif
    [IsoXmlTag("IntrmyAgt2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_2hFaBXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt3")]
    #endif
    [IsoXmlTag("IntrmyAgt3")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_2hFaB3L-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_2hFaCXL-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party40Choice_ Creditor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party40Choice_ Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party40Choice_ Creditor { get; init; } 
    #else
    public Party40Choice_ Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_2hFaC3L-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtCdtr")]
    #endif
    [IsoXmlTag("UltmtCdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Party40Choice_? UltimateCreditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party40Choice_? UltimateCreditor { get; init; } 
    #else
    public Party40Choice_? UltimateCreditor { get; set; } 
    #endif
    
    
    #nullable disable
    
}
