// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the references of an account management instruction message.
/// </summary>
[IsoId("_eQZ8AZTPEemqYPWMBuVawg")]
[DisplayName("Account Management Message Reference")]
public partial record AccountManagementMessageReference5
{
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message.
    /// </summary>
    [IsoId("_ejvuxZTPEemqYPWMBuVawg")]
    [DisplayName("Linked Reference")]
    [IsoXmlTag("LkdRef")]
    public LinkedMessage5Choice_? LinkedReference { get; init; } 
    
    /// <summary>
    /// Type of account management instruction for which the status is requested or a request to know the status of the account.
    /// </summary>
    [IsoId("_ejvux5TPEemqYPWMBuVawg")]
    [DisplayName("Status Request Type")]
    [IsoXmlTag("StsReqTp")]
    public required AccountManagementType3Code StatusRequestType { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or account modification instruction at application level.
    /// </summary>
    [IsoId("_ejvuyZTPEemqYPWMBuVawg")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    
    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_ejvuy5TPEemqYPWMBuVawg")]
    [DisplayName("Existing Account Identification")]
    [IsoXmlTag("ExstgAcctId")]
    public Account23? ExistingAccountIdentification { get; init; } 
    
    /// <summary>
    /// Account information for which the status of an account management instruction is requested.
    /// </summary>
    [IsoId("_ejvuzZTPEemqYPWMBuVawg")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    public InvestmentAccount77? InvestmentAccount { get; init; } 
    
    
    #nullable disable
    
}
