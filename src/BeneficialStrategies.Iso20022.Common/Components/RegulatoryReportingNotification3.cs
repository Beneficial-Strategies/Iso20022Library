// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the regulatory notification.
/// </summary>
[IsoId("_o5oMsbGJEeuSTr8k0UEM8A")]
[DisplayName("Regulatory Reporting Notification")]
public partial record RegulatoryReportingNotification3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the transaction notification.
    /// </summary>
    [IsoId("_o6u_8bGJEeuSTr8k0UEM8A")]
    [DisplayName("Transaction Notification Identification")]
    [IsoXmlTag("TxNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionNotificationIdentification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_o6u_87GJEeuSTr8k0UEM8A")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification135 AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_o6u_9bGJEeuSTr8k0UEM8A")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required BranchAndFinancialInstitutionIdentification6 AccountServicer { get; init; } 
    
    /// <summary>
    /// Certificate against which all currency control transactions are registered.
    /// </summary>
    [IsoId("_o6u_97GJEeuSTr8k0UEM8A")]
    [DisplayName("Transaction Certificate")]
    [IsoXmlTag("TxCert")]
    public ValueList<TransactionCertificate4> TransactionCertificate { get; init; } = new ValueList<TransactionCertificate4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _o6u_97GJEeuSTr8k0UEM8A
    
    
    #nullable disable
    
}
