// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the message reference of the account management instruction message for which the status is requested.
/// </summary>
[IsoId("_KUjOwQgvEeSy_NqeitQG4Q")]
[DisplayName("Account Management Message Reference")]
public partial record AccountManagementMessageReference2
{
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message.
    /// </summary>
    [IsoId("_wu2KcQgvEeSy_NqeitQG4Q")]
    [DisplayName("Linked Reference")]
    [IsoXmlTag("LkdRef")]
    public LinkedMessage2Choice_? LinkedReference { get; init; } 
    
    /// <summary>
    /// Specifies if the status request refers to an earlier account opening or modification instruction message.
    /// </summary>
    [IsoId("_KvVGTwgvEeSy_NqeitQG4Q")]
    [DisplayName("Status Request Type")]
    [IsoXmlTag("StsReqTp")]
    public required AccountManagementType1Code StatusRequestType { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or account modification instruction at application level.
    /// </summary>
    [IsoId("_KvVGUQgvEeSy_NqeitQG4Q")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    
    /// <summary>
    /// Account information for which the status of an account management instruction is requested.
    /// </summary>
    [IsoId("_KvVGUwgvEeSy_NqeitQG4Q")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    public InvestmentAccount45? InvestmentAccount { get; init; } 
    
    
    #nullable disable
    
}
