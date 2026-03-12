// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the party fields used to search for a payment.
/// </summary>
[IsoId("_72PJEKMgEeCJ6YNENx4h-w_-1323572611")]
[DisplayName("Payment Transaction Party")]
public partial record PaymentTransactionParty2
{
    #nullable enable
    
    /// <summary>
    /// Party that owes assets to the creditor, such as a result of receipt of goods or services, gifts, or charity payments. The debtor may also be the debit account owner.
    /// </summary>
    [IsoId("_72PJEaMgEeCJ6YNENx4h-w_-1027582954")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public BranchAndFinancialInstitutionIdentification5? Debtor { get; init; } 
    
    /// <summary>
    /// Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.
    /// </summary>
    [IsoId("_72PJEqMgEeCJ6YNENx4h-w_-702465447")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; } 
    
    /// <summary>
    /// Specifies the agent through which the instructing agent will reimburse the instructed agent.
    /// </summary>
    [IsoId("_72PJE6MgEeCJ6YNENx4h-w_-313123797")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingReimbursementAgent { get; init; } 
    
    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.
    /// </summary>
    [IsoId("_72PJFKMgEeCJ6YNENx4h-w_-1915260928")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedReimbursementAgent { get; init; } 
    
    /// <summary>
    /// Party within the settlement chain between the debtor and creditor agents.
    /// </summary>
    [IsoId("_72PJFaMgEeCJ6YNENx4h-w_499400728")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent { get; init; } 
    
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of an account owner, or other nominated party, and credits the account.
    /// </summary>
    [IsoId("_72PJFqMgEeCJ6YNENx4h-w_2082420107")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; } 
    
    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    [IsoId("_72PJF6MgEeCJ6YNENx4h-w_-739671062")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public BranchAndFinancialInstitutionIdentification5? Creditor { get; init; } 
    
    
    #nullable disable
    
}
