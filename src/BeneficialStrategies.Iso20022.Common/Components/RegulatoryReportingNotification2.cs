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
[IsoId("_NcmF5249EeiU9cctagi5ow")]
[DisplayName("Regulatory Reporting Notification")]
public partial record RegulatoryReportingNotification2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the transaction notification.
    /// </summary>
    [IsoId("_Nl1hcW49EeiU9cctagi5ow")]
    [DisplayName("Transaction Notification Identification")]
    [IsoXmlTag("TxNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionNotificationIdentification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_Nl1hc249EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification135 AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_Nl1hdW49EeiU9cctagi5ow")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required BranchAndFinancialInstitutionIdentification6 AccountServicer { get; init; } 
    
    /// <summary>
    /// Certificate against which all currency control transactions are registered.
    /// </summary>
    [IsoId("_Nl1hd249EeiU9cctagi5ow")]
    [DisplayName("Transaction Certificate")]
    [IsoXmlTag("TxCert")]
    public ValueList<TransactionCertificate3> TransactionCertificate { get; init; } = new ValueList<TransactionCertificate3>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Nl1hd249EeiU9cctagi5ow
    
    
    #nullable disable
    
}
