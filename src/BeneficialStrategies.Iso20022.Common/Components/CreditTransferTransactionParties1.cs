// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies all the parties involved in a cover payment transaction.
/// </summary>
[IsoId("_H1gUQDMmEeit26XNYhRFqg")]
[DisplayName("Credit Transfer Transaction Parties")]
public partial record CreditTransferTransactionParties1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial institution that owes an amount of money to the (ultimate) financial institutional creditor.
    /// </summary>
    [IsoId("_MYGuATMsEeit26XNYhRFqg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? Debtor { get; init; } 
    
    /// <summary>
    /// Identifies the financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_mHMX0TMrEeit26XNYhRFqg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? DebtorAgent { get; init; } 
    
    /// <summary>
    /// Identifies the agent between the debtor&apos;s agent and the creditor&apos;s agent.
    /// </summary>
    [IsoId("_oEMQATMrEeit26XNYhRFqg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? IntermediaryAgent1 { get; init; } 
    
    /// <summary>
    /// Identifies the financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_pvXYYTMrEeit26XNYhRFqg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? CreditorAgent { get; init; } 
    
    /// <summary>
    /// Identifies the financial institution that receives an amount of money from the financial institutional debtor.
    /// </summary>
    [IsoId("_EFU_gTMsEeit26XNYhRFqg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? Creditor { get; init; } 
    
    
    #nullable disable
    
}
