// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies all the parties involved in a serial payment transaction.
/// </summary>
[IsoId("_wPuVwDMlEeit26XNYhRFqg")]
[DisplayName("Customer Credit Transfer Transaction Parties")]
public partial record CustomerCreditTransferTransactionParties1
{
    #nullable enable
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_e2UkgDMmEeit26XNYhRFqg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? DebtorAgent { get; init; } 
    
    /// <summary>
    /// Agent through which the instructing agent (identified in the &quot;From&quot; element) will reimburse the instructed agent (identified in the &quot;To&quot; element).
    /// </summary>
    [IsoId("_UDjTkTMoEeit26XNYhRFqg")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? InstructingReimbursementAgent { get; init; } 
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_UJZu0TMmEeit26XNYhRFqg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? CreditorAgent { get; init; } 
    
    
    #nullable disable
    
}
