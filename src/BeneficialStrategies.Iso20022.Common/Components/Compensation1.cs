// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of a payment compensation.
/// </summary>
[IsoId("_FXZXAIjYEeeDW7_wB-eK_g")]
[DisplayName("Compensation")]
public partial record Compensation1
{
    #nullable enable
    
    /// <summary>
    /// Amount of money to be paid in compensation.
    /// </summary>
    [IsoId("_Md3DYIjYEeeDW7_wB-eK_g")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// Usage: The debtor agent is the payer of the compensation amount.
    /// </summary>
    [IsoId("_PpMW8IjYEeeDW7_wB-eK_g")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; } 
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// Usage: The creditor agent is the payee of the compensation amount.
    /// </summary>
    [IsoId("_Sr1okIjYEeeDW7_wB-eK_g")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; } 
    
    /// <summary>
    /// Reason for the payment compensation.
    /// </summary>
    [IsoId("_lnYFgIjYEeeDW7_wB-eK_g")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CompensationReason1Choice_ Reason { get; init; } 
    
    
    #nullable disable
    
}
