// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details on the regulatory notification.
/// </summary>
[IsoId("_c-VXQDmyEeWDb47rJ6ki4Q")]
[DisplayName("Regulatory Reporting Notification")]
public partial record RegulatoryReportingNotification1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the transaction notification.
    /// </summary>
    [IsoId("_sv4yMTm3EeWDb47rJ6ki4Q")]
    [DisplayName("Transaction Notification Identification")]
    [IsoXmlTag("TxNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionNotificationIdentification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_zGuYcjm3EeWDb47rJ6ki4Q")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification77 AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_zGuYczm3EeWDb47rJ6ki4Q")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required BranchAndFinancialInstitutionIdentification5 AccountServicer { get; init; } 
    
    /// <summary>
    /// Certificate against which all currency control transactions are registered.
    /// </summary>
    [IsoId("_YGMKUTm3EeWDb47rJ6ki4Q")]
    [DisplayName("Transaction Certificate")]
    [IsoXmlTag("TxCert")]
    public ValueList<TransactionCertificate1> TransactionCertificate { get; init; } = [];
    // ID for the above is _YGMKUTm3EeWDb47rJ6ki4Q
    
    
    #nullable disable
    
}
